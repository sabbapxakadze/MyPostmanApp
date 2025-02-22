using System.Text;
using System.Text.Json;
using static MyPostmanLibrary.Enums;

namespace MyPostmanLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient _client = new();

    public async Task<string> CallApiAsync(
        string url,
        string content,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
        )
    {
        StringContent? stringContent = new(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput);
    }

    public async Task<string> CallApiAsync(
        string url,
        HttpContent? content = null,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
        )
    {
        HttpResponseMessage? response;

        switch (action)
        {
            case HttpAction.GET:
                response = await _client.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await _client.PostAsync(url, content);
                break;
            case HttpAction.PUT:
                response = await _client.PutAsync(url, content);
                break;
            case HttpAction.PATCH:
                response = await _client.PatchAsync(url, content);
                break;
            case HttpAction.DELETE:
                response = await _client.DeleteAsync(url);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }
        
        response = await _client.GetAsync(url);

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