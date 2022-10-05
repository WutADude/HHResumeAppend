namespace HHResumeAppend.Helpers
{
    internal static class Requests
    {
        private static string _UserAgent = "ru.hh.android/6.91.1.11176";

        internal static HttpClient _MainClient { get; set; }

        private static void SetupClient(string Token)
        {
            _MainClient = new HttpClient();
            _MainClient.DefaultRequestHeaders.UserAgent.ParseAdd(_UserAgent);
            _MainClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {Token}");
        }

        internal static string GetJson(string Token, string URL)
        {
            if (_MainClient == null)
                SetupClient(Token);
            return _MainClient.GetStringAsync(URL).Result;
        }

        internal static async Task<bool> isSuccessAppended(string ResumeID)
        {
            var Response = await _MainClient.PostAsync($"https://api.hh.ru/resumes/{ResumeID}/publish?with_professional_roles=true&hhtmSource=resume_list&host=hh.ru&locale=RU", null);
            return Response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

    }
}
