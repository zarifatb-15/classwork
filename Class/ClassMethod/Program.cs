namespace ClassMethod;

class Program
{
    static void Main(string[] args)
    {
      Book book1 = new Book();
      book1.Author = "Babayeva Zarifa";
      book1.Title = "edit class";
      book1.Pages = "45";
      
      Book book2=new Book();
      book2.Author = "dosteyevski";
      book2.Title = "suc ve ceza";
      book2.Pages = "600";

      Book book3 = new Book();
      book3.Author = "Qurban Seid";
      book3.Title = "Eli ve Nino";
      book3.Pages = "350";
      
      book1.Print();
      book2.Print();
      book3.Print();

    }
}
class Book
{
    public string Title;
    public string Author;
    public string Pages;

    public void Print()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, Pages: {Pages}");
    }
}

class Student
{
    public string Name;
    public string Surname;
    public int Age;
    public string Email;

    public void Print()
    {
        Console.WriteLine($"Student: {Name}, Surname: {Surname}, Age: {Age}, Email: {Email}");
    }
}