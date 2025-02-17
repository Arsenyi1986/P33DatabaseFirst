namespace Program;

using DbF.Models;

class Program
{
    public static void Main(string[] args)
    {
        Program.AddAuthor(new Author{FirstName="Chuck", LastName="Palahniuk"});
        Program.GetAllAuthors();
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