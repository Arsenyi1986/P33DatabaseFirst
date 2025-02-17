using System;
using System.Collections.Generic;

namespace DbF.Models;

public partial class Book
{
    public int Id { get; set; }

    public int AuthorId { get; set; }

    public string Title { get; set; } = null!;

    public int? Price { get; set; }

    public int? Pages { get; set; }

    public int PublisherId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Publisher Publisher { get; set; } = null!;
}
