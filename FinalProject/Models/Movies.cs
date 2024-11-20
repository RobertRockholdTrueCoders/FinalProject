namespace FinalProject.Models;

public class Movies
{
    public int ID { get; set; }
    public string MovieTitle { get; set; }
    public int YearOfRelease { get; set; }
    public bool SeenBefore { get; set; }
    public int Rating { get; set; }
}