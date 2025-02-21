using System.Text.Json;
using static MyPostmanLibrary.Enums;

namespace MyPostmanLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient _client = new();

    public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
    {
        var response = await _client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }
    public bool isValidUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri outputUri)
            && (outputUri.Scheme == Uri.UriSchemeHttps);
        return output;
    }
}