using ConsoleApp14.Models;
using System.Threading.Channels;

Book[] Books = new Book[2];
for (int i = 0; i < Books.Length; i++)
{
    Console.WriteLine("Kitabin adi :");

    string name = Console.ReadLine();

    Console.WriteLine("Kitabin seife Sayi :");

    int page = int.Parse(Console.ReadLine());
    
    while (!ChekName(name))
    {
        Console.WriteLine("adi duzgun daxil et");
        name= Console.ReadLine();
    }
    while (!ChekCount(page))
    {
        Console.WriteLine("page duzgun daxil et");
        page = int.Parse(Console.ReadLine());
    }
    

    Book book = new Book(name, page);
    Books[i] = book;
}

bool ChekName(string name)
{
    if(!string.IsNullOrWhiteSpace(name)&&name.Length>2)
        return true;
    return false;
}

    

bool ChekCount(int pageCount)
{
    if(pageCount>10)
        return true;
    return false;
}
foreach (Book book in Books)
{
    Console.WriteLine($"Name :{book.Name}   pageCount:{book.PageCount}");
}