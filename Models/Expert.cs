namespace AcademicPlatform.Models;

public class Expert
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public double Rating { get; set; }
    public int ReviewsCount { get; set; }
    public int CompletedProjects { get; set; }
}
