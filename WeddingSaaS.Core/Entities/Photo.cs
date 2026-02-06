namespace WeddingSaaS.Core.Entities;

public class Photo
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;


    public Guid WeddingId { get; set; }
    public Wedding Wedding { get; set; } = null!;
}