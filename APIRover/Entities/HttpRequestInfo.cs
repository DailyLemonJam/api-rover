using APIRover.Enums;

namespace APIRover.Entities;

public class HttpRequestInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public HttpMethodType Method { get; set; }
    public string RequestURL { get; set; } = string.Empty; // Mb Uri instead?
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // TODO add response types
}
