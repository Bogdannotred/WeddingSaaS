namespace WeddingSaaS.Core.Entities;

public class Wedding
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    public List<Photo> Photos { get; set; } = new();
}