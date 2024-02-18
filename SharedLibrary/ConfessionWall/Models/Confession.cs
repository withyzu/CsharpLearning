namespace SharedLibrary.ConfessionWall.Models;
public class Confession {
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;

    public DateTime CreateTime { get; set; }

    public bool IsPublicShow { get; set; }
}
