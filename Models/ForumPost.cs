namespace AcademicPlatform.Models;

public class ForumPost
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Replies { get; set; }
    public DateTime CreatedAt { get; set; }
}
