namespace GraphQlApi.Models;

public class Book
{
    public int Id { get; set; }
    public DateOnly? PublishDate { get; set; }
    public string Title { get; set; }
    public string Edition { get; set; }

    public Author Author { get; set; }
}
