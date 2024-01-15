using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = null;
            string opr;
            do
            {

                Console.WriteLine("-------------------------Menu--------------------------");
                Console.WriteLine("1. Kitab elave et");
                Console.WriteLine("2. Kitab sil");
                Console.WriteLine("3. Bütün kitablara bax");
                Console.WriteLine("4. secilmiş kitaba bax (ada görə)");
                Console.WriteLine("5. ada göre axtariş et ");
                Console.WriteLine("0. emeliyyati bitir");
                opr = Console.ReadLine();    

                switch (opr)
                {

                    case "1":
                        int price;
                        string priceStr;
                        string name;
                        do
                        {

                            Console.WriteLine("Adi daxil edin");
                            name = Console.ReadLine();

                            

                        }
                        while (name.Length<3 ||name.Length>20);
                        do
                        {
                            Console.WriteLine("Qiymeti daxil edin ");
                            priceStr = Console.ReadLine();

                        }
                        while (!int.TryParse(priceStr,out price) || price<0);
                        
                        Console.WriteLine("Janri daxil edin");
                        string genre = Console.ReadLine();

                        Book book = new Book(name, price, genre);

                        if (library == null)
                        {
                            library = new Library(book);
                        }
                        else
                        {
                            library.addBook(book);
                        }

                        Console.WriteLine("Kitab elave edildi!");

                        break;

                    case "2":

                        if (library != null)
                        {
                            library.displayBooks();
                            Console.WriteLine("Kitap nomresini secin");
                            int num =Convert.ToInt32(Console.ReadLine());
                            library.removeBook(num);


                        }
                        else Console.WriteLine("Kitabxana bosdur");


                        break;

                    case "3":

                        if(library == null)
                        {

                            Console.WriteLine("Kitabxana bosdur");

                        }
                        else library.displayBooks();


                        break;

                    case "4":

                        Console.WriteLine("Adi daxil edin");

                        string name1 =Console.ReadLine();

                        library.FindBookByName(name1);


                        break;

                    case "5":
                        string nameSearch;
                        
                        
                        do
                        {
                            Console.WriteLine("Herfi daxil edin");

                            nameSearch = Console.ReadLine();
                        }
                        while (nameSearch.Length>1);
                            

                        library.FindBookByChar(nameSearch);
                        

                        break;

                    default: Console.WriteLine("yanlish emeliyyat");

                        break;



                }


            }
            while (opr != "0");

        }
    }
}
