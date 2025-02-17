namespace Program;

using DbF.Models;

class Program
{
    public static void Main(string[] args)
    {

    }
    /// <summary>
    /// Задание №1
    /// Написать реализацию для метода AddBook. Метод должен добавлять
    /// в контекст новую книжку и сохранять её в БД.
    /// </summary>
    static void AddBook(Book book)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задание №2
    /// Написать реализацию для метода AddPublisher. Метод должен 
    /// добавлять в контекст новое издательство и сохранить его в БД.
    /// </summary>
    static void AddPublisher(Publisher publisher)
    {
        throw new NotImplementedException();
    }

    static void AddAuthor(Author author)
    {
        using (LibraryContext context = new LibraryContext())
        {
            context.Authors.Add(author);
            context.SaveChanges();

            Console.WriteLine($"New author added: {author.LastName}");
        }
    }

    // static void GetAllAAuthors()
    // {
    //     using (LibraryContext context = new LibraryContext())
    //     {
    //         var au = context.Authors.Where((x) => x.LastName.StartsWith("A")).ToList();

    //         foreach (var a in au)
    //         {
    //             Console.WriteLine(a.FirstName + " " + a.LastName);
    //         } 
    //     }
    // }

    /// <summary>
    /// Задание №3
    /// Написать реализацию для метода GetAllBooks. Метод должен 
    /// выводить список книг.
    /// </summary>
    static void GetAllBooks()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задание №4
    /// Написать реализацию для метода GetAllPublishers. Метод должен 
    /// выводить список издательств.
    /// </summary>
    static void GetAllPublishers()
    {
        throw new NotImplementedException();
    }

    static void GetAllAAuthors()
    {
        using (LibraryContext context = new LibraryContext())
        {
            var au = (from x in context.Authors
                    where x.FirstName.StartsWith("A")
                    select x).ToList();

            foreach (var a in au)
            {
                Console.WriteLine(a.FirstName + " " + a.LastName);
            } 
        }
    }

    static void GetAllAuthors()
    {
        using (LibraryContext context = new LibraryContext())
        {
            var au = context.Authors.ToList();
            foreach (var a in au)
            {
                Console.WriteLine(a.FirstName + " " + a.LastName);
            }
        }
    }

    // static Author GetAuthorByName(string fname)
    // {
    //     using (LibraryContext context = new LibraryContext())
    //     {
    //         var author = context.Authors.Where((x) => x.FirstName == fname).FirstOrDefault();
    //         return author;
    //     }
    // }

    static Author GetAuthorByName(string fname)
    {
        using (LibraryContext context = new LibraryContext ())
        {
            var author = (from x in context.Authors
                        where x.FirstName == fname
                        select x).FirstOrDefault();
            return author;
        }
    }

    // static Author GetAuthorById(int id)
    // {
    //     using (LibraryContext context = new LibraryContext ())
    //     {
    //         var author = context.Authors.Where((x) => x.Id == id).SingleOrDefault();
    //         return author;
    //     }
    // }

    static Author GetAuthorById(int id)
    {
        using (LibraryContext context = new LibraryContext ())
        {
            var author = (from x in context.Authors
                        where x.Id == id
                        select x).SingleOrDefault();
            return author;
        }
    }
}