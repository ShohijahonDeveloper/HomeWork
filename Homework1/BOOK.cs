namespace Homework
{
    class BOOK
    {
       
        public string Pages { get; set; }
        public string Price { get; set; }
        public string BooksName { get; set; }
        public string Author { get; set; }

    public BOOK(
        string name, 
        string author, 
        string price, 
        string page)
    {
        BooksName = name;
        Author = author;
        Pages = page;
        Price = price;
        }
     public void FirstBook(
        string name, 
        string author, 
        string price, 
        string page)
       {
          Console.WriteLine($" Author: {author}, Book: {name}, Price: {price}, Pages: {page}");
       }
    
     
     public void SecondBook(
        string name, 
        string author, 
        string price, 
        string page)
     {
        Console.WriteLine($" Author: {author}, Book: {name}, Price: {price}, Pages: {page}");
     }
      
    public void ThirdBook(
        string name, 
        string author, 
        string price, 
        string page)
    {
      Console.WriteLine($" Author: {author}, Book: {name}, Price: {price}, Pages: {page}");
    }

    public void ForthBook(
        string name, 
        string author, 
        string price, 
        string page)
    {
       Console.WriteLine($" Author: {author}, Book: {name}, Price: {price}, Pages: {page}");
    }

  

    }
}