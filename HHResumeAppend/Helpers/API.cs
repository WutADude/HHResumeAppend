namespace HHResumeAppend.Helpers
{
    internal class API
    {
        private string Token { get; set; }
        internal MainForm _MainForm;
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int ResumesCount { get; set; }
        internal Dictionary<string, DateTime> Resumes = new Dictionary<string, DateTime>();

        internal API(string BToken)
        {
            Token = BToken;
            GetUserInfo();
        }

        internal async void MainWorker()
        {
            try
            {
                while (_MainForm._ISWorking)
                {
                    foreach (var Resume in Resumes)
                    {
                        if (DateTime.Compare(DateTime.Now, Resume.Value) >= 0 && _MainForm._ISWorking)
                        {
                            try
                            {
                                if (await Requests.isSuccessAppended(Resume.Key))
                                {
                                    _MainForm.AppendsCountLabel.Text = $"Последнее поднятие:\n{DateTime.Now.ToString("HH:mm dd.MM.yyyy")}";
                                    Resumes[Resume.Key] = Resume.Value.AddHours(4).AddMinutes(1);
                                }
                                else
                                    _MainForm.AppendsCountLabel.Text = "Не удалось поднять резюме!";
                            }
                            catch { }
                        }
                        _MainForm.ClosestAppendLabel.Text = $"{GetClosestAppendDate.ToString("HH:mm dd.MM.yyyy")}";
                    }
                    Thread.Sleep((int)TotalSleepMilisec.TotalMilliseconds);
                }
            }
            catch { }
        }

        private void GetUserInfo()
        {
            
            string JSON = Requests.GetJson(Token, "https://api.hh.ru/me?with_user_statuses=true&host=hh.ru&locale=RU");
            FirstName = JsonParser.GetFirstName(JSON);
            LastName = JsonParser.GetLastName(JSON);
            ResumesCount = JsonParser.GetResumesCount(JSON); 
            foreach (var Element in JsonParser.GetResums(Requests.GetJson(Token, $"https://api.hh.ru/mobile/resumes/mine?page=0&per_page={ResumesCount}&host=hh.ru&locale=RU")).EnumerateArray())
            {
                string Resume_ID = Element.GetProperty("resume").GetProperty("id").GetString();
                try
                {
                    if (!Resumes.ContainsKey(Resume_ID))
                        Resumes.Add(Resume_ID, DateTime.Parse(Element.GetProperty("resume").GetProperty("next_publish_at").GetString()).AddMinutes(1));
                    else
                        Resumes[Resume_ID] = DateTime.Parse(Element.GetProperty("resume").GetProperty("next_publish_at").GetString()).AddMinutes(1);
                }
                catch { } // Some have no next_publish date
            }
        }

        private DateTime GetClosestAppendDate => Resumes.OrderBy(r => r.Value).First().Value;

        private TimeSpan TotalSleepMilisec => GetClosestAppendDate - DateTime.Now;
    }
}


