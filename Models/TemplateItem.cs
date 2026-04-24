namespace AcademicPlatform.Models;

public class TemplateItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string CitationStyle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
