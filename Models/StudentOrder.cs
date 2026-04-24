namespace AcademicPlatform.Models;

public class StudentOrder
{
    public int Id { get; set; }
    public string StudentName { get; set; } = string.Empty;
    public string ServiceName { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public int Progress { get; set; }
    public DateTime DueDate { get; set; }
    public string ExpertName { get; set; } = string.Empty;
}
