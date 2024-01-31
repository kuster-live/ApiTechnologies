namespace GraphQlApi.Queries;

using Services;

public class Mutations
{
    private readonly IBookService _service;

    public Mutations(IBookService service) => _service = service;

    public async Task<int> CreatBook(Book book)
        => await _service.CreateBook(book);
}
