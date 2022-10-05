using System.Text.Json;

namespace HHResumeAppend.Helpers
{
    internal static class JsonParser
    {
        internal static string GetFirstName(string JSON) => JsonDocument.Parse(JSON).RootElement.GetProperty("first_name").GetString();
        internal static string GetLastName(string JSON) => JsonDocument.Parse(JSON).RootElement.GetProperty("last_name").GetString();
        internal static int GetResumesCount(string JSON) => JsonDocument.Parse(JSON).RootElement.GetProperty("counters").GetProperty("resumes_count").GetInt32();
        internal static JsonElement GetResums(string JSON) => JsonDocument.Parse(JSON).RootElement.GetProperty("resumes").GetProperty("items");
    }
}
