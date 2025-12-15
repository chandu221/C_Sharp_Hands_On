class BookDetail

{

     //[Key]
     public int BookDetail_Id { get; set; }
     public int NoOfChapters { get; set; }
     public int NumberOfPages { get; set; }
     public double Weight  { get; set; }
    
     //[ForeignKey("Book")]
     public int BookId { get; set; }
     public Book Book { get; set; }

}

class Book
{

    //[Key]
    public int BookId { get; set; }
    public string Title { get; set; }
    
    // [MaxLength(20)]
    // [Required]
    public string ISBN { get; set; }
    public double Price { get; set; }

    //[NotMapped]
    public string PriceRange { get; set; }
    public BookDetail BookDetail { get; set; }
 
    // [ForeignKey("Publisher")]
    public int Publisher_Id{get;set;}
    public Publisher Publisher{get;set;}

    public List<BookAuthorMap> BookAuthorMap{ get; set; }

}
 
class Publisher 
{

    //[Key]
    public int Publisher_Id{get;set;}

    //[Required]
    public string Name{get;set;}
    public string Location{get;set;}
    public ICollection<Book> Books {get; set;}

}
class Author
    {
        //[Key]
        public int Author_Id { get; set; }
        
        //[Required]
        //[MaxLength(50)]
        public string FirstName { get; set; }
        
        //[Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        
        //[NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public List<BookAuthorMap> BookAuthorMap{ get; set; }
    }

[PrimaryKey(nameof(Book_Id), nameof(Author_Id))]
    class BookAuthorMap
    {
        [ForeignKey("Book")]
        public int Book_Id { get; set; }
        [ForeignKey("Author")]
        public int Author_Id { get; set; }

        public Book Books { get; set; }
        public Author Authors { get; set; }
    }


class MyDbContext : DbContext

{

    public DbSet<Book> Books {get ; set;}=null!;

    public DbSet<BookDetail> BookDetails {get ; set;}=null!;

    public DbSet<Publisher> Publishers {get ; set;}=null!;

    public DbSet<Author> Authors {get ; set;}=null!;

    public DbSet<BookAuthorMap> BookAuthorMaps {get ; set;}=null!;
 
    public MyDbContext(DbContextOptions<MyDbContext> options)

        : base(options)

    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Book
        modelBuilder.Entity<Book>()
        .HasKey(c => c.BookId);

        modelBuilder.Entity<Book>()
        .Property(c => c.ISBN)
        .HasMaxLength(20)
        .IsRequired();

         modelBuilder.Entity<Book>()
        .Ignore(c => c.PriceRange);
 
        modelBuilder.Entity<Publisher>()
        .HasMany(e => e.Books)
        .WithOne(e => e.Publisher)
        .HasForeignKey(e => e.Publisher_Id)
        .IsRequired();

         modelBuilder.Entity<Book>()
        .HasMany(b => b.BookAuthorMap)
        .WithOne(b => b.Books)
        .HasForeignKey(b => b.Book_Id);

 
        //BookDetail
        modelBuilder.Entity<BookDetail>()
        .HasKey(c => c.BookDetail_Id);

        modelBuilder.Entity<Book>()
        .HasOne(e => e.BookDetail)
        .WithOne(e => e.Book)
        .HasForeignKey<BookDetail>(e => e.BookId)
        .IsRequired();

        //publisher
        modelBuilder.Entity<Publisher>()
        .HasKey(c => c.Publisher_Id);

        modelBuilder.Entity<Publisher>()
        .Property(c => c.Name)
        .IsRequired();

        //Author
         modelBuilder.Entity<Author>(entity =>
             {
                entity.HasKey(a => a.Author_Id);
                 
                entity.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(a => a.LastName)
                .IsRequired();

                entity.Ignore(a => a.FullName);
                 
                entity.HasMany(b => b.BookAuthorMap)
                .WithOne(b => b.Authors)
                .HasForeignKey(b => b.Author_Id);
            });


        //BookMapAuthor
        modelBuilder.Entity<BookAuthorMap>(entity =>
            {
                entity.HasKey(b => new { b.Book_Id, b.Author_Id });
                
                entity.HasOne(b => b.Books)
                .WithMany(b => b.BookAuthorMap)
                .HasForeignKey(b => b.Book_Id);

                entity.HasOne(b => b.Authors)
                .WithMany(a => a.BookAuthorMap)
                .HasForeignKey(b => b.Author_Id);
            });

   
    }

}
 