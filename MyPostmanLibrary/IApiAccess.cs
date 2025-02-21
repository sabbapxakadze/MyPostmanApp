namespace MyPostmanLibrary;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, bool formatOutput = true, Enums.HttpAction action = Enums.HttpAction.GET);
    bool isValidUrl(string url);
}