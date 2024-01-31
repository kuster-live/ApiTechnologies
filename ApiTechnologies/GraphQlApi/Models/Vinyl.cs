namespace GraphQlApi.Models;

public class Vinyl
{
    public string Name { get; set; }
    public DateOnly ReleaseDate { get; set; }

    public Artist Artist { get; set; }
}
