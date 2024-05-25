namespace Homework
{
    class Programm
    {
       static void Main()
       {
          BOOK books = new BOOK(
            name: "Bahoriston", 
            author: "A. Jomiy", 
            price: "15 $", 
            page: "300");
          
          Console.WriteLine("1th book ");
          books.FirstBook(
            author : "A. Jomiy", 
            name: "Bahoriston", 
            price: "15 $", 
            page: " 300");
          
          Console.WriteLine("2nd book ");
          books.SecondBook(
            author : "Bodo Shefer", 
            name: "Law of winners", 
            price: "65$", 
            page: "240");
        
        Console.WriteLine("3rd book ");
        books.ThirdBook(
            author: "Jorj Samuel Kalison",
            name : "The rechest of Vavilone",
            price : "75$",
            page: "235");
        
        Console.WriteLine("4th Book ");
        books.ForthBook(
            name: "Xamsa", 
            author: "Alisher Navoiy", 
            page: "790", 
            price: "25$");
        }
    }
}