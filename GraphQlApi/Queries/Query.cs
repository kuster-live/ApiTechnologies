namespace GraphQlApi.Queries;

using Services;

public class Query
{
    private static IBookService _bookService;

    public Query(IBookService bookService) => _bookService = bookService;

    public List<Book> GetBooks() =>
        _bookService.GetAll();

    public Author? GetAuthor(int id) => _bookService.GetAuthorById(id);

    private static readonly Artist DummyArtist = new() { Name = "Pink Floyd" };

    public Vinyl GetVinyl() =>
        new()
        {
            Name = "The Dark Side of the Moon",
            ReleaseDate = new DateOnly(1973, 3, 1),
            Artist = DummyArtist
        };

    public Artist GetArtist() =>
        DummyArtist;
}
