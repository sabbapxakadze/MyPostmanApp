namespace MyPostmanLibrary;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, string content, Enums.HttpAction action = Enums.HttpAction.GET, bool formatOutput = true, string? jwtToken = null);
    Task<string> CallApiAsync(string url, HttpContent? content = null, Enums.HttpAction action = Enums.HttpAction.GET, bool formatOutput = true, string? jwtToken = null);
    bool isValidUrl(string url);
}