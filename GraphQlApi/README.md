# ChilliCream HotChocolate

[HotChocolate doc](https://chillicream.com/docs/hotchocolate/v13/get-started-with-graphql-in-net-core)


## query

```graphql
{
  books{
    title
    author{
      name
    }
  }

  author(id: 1){
    name,
    id
  }
  vinyl{
    name
    releaseDate
    artist{
      name
    }
  }
}
```

## mutation

```graphql
mutation {
  creatBook(
    book: {
      title: "this is sparta"
      author: { id: 2, name: "somebody" }
      edition: "1st"
      id: 2
      publishDate: "2024-01-31"
    }
  )
}

```
