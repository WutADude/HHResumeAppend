using HHResumeAppend.Helpers;
using System.Threading;

namespace HHResumeAppend
{
    public partial class MainForm : Form
    {
        private API _Api { get; set; }
        private List<Control> _InfoLabels;

        internal bool _ISWorking;
        public MainForm()
        {
            InitializeComponent();
            _InfoLabels = new List<Control>() {FirstNameLabel, lastNameLabel, ResumeCountLabel };
            ReadSettings();
        }

        private void MainButton_Click(object sender, EventArgs e) => BeginOrStop();

        private void BeginOrStop()
        {
            CancellationTokenSource TokenSource = new CancellationTokenSource();
            CancellationToken CancelToken = TokenSource.Token;
            if (!_ISWorking)
            {
                _ISWorking = true;
                MainButton.Text = "Остановить";
                new Task(()=>{ _Api.MainWorker(); }, CancelToken).Start();
                TokenPasteLabel.Enabled = false;
            }
            else
            {
                _ISWorking = false;
                CancelToken.ThrowIfCancellationRequested();
                MainButton.Text = "Запустить";
                TokenPasteLabel.Enabled = true;
            }
        }

        private void GitLinkLabel_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() {FileName = "explorer.exe", Arguments = Properties.Settings.Default.GitHubURL });

        private void TokenPasteLabel_Click(object sender, EventArgs e)
        {
            string ClipText = Clipboard.GetText();
            if (!string.IsNullOrEmpty(ClipText))
            {
                (sender as Label).Text = ClipText;
                UpdateBearerToken(ClipText);
            }
        }

        private void ReadSettings()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BearerToken))
            {
                TokenPasteLabel.Text = Properties.Settings.Default.BearerToken;
                SetupAPIAndGetInfo();
            }
            else
                TokenPasteLabel.Text = "-> скопируйте токен и нажмите ЛКМ<-";
        }

        private void SetupAPIAndGetInfo()
        {
            try
            {
                _InfoLabels.ForEach(c => c.Text = "...");
                _Api = new API(Properties.Settings.Default.BearerToken);
                _Api._MainForm = this;
                FirstNameLabel.Text = _Api.FirstName;
                lastNameLabel.Text = _Api.LastName;
                ResumeCountLabel.Text = _Api.ResumesCount.ToString();
                MainButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При работе с API произошла ошибка! Текст:\n{ex.Message}", "API ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Requests._MainClient = null;
                MainButton.Enabled = false;
            }

        }

        private void UpdateBearerToken(string Token)
        {
            Properties.Settings.Default.BearerToken = Token;
            Properties.Settings.Default.Save();
            Requests._MainClient = null;
            SetupAPIAndGetInfo();
        }

        
    }
}