namespace GraphQlApi.Services;

public interface IBookService
{
    List<Book> GetAll();

    Author? GetAuthorById(int id);

    Task<int> CreateBook(Book book);
}

public class BookService : IBookService
{
    private List<Book> Books { get; set; } =
    [
        new()
        {
            Id = 1,
            PublishDate = new DateOnly(2019, 3, 23),
            Title = "C# in depth.",
            Edition = "4th",
            Author = new()
            {
                Name = "Jon Skeet",
                Id = 1
            }
        }
    ];

    public List<Book> GetAll() => Books;

    public Author? GetAuthorById(int id) => Books.FirstOrDefault(x => x.Author.Id == id)?.Author;

    public Task<int> CreateBook(Book book)
    {
        Books.Add(book);

        return Task.FromResult(book.Id);
    }
}
