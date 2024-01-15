using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Library
    {
        public Library(Book initialBook)
        {
            books = new Book[1];
            books[0] = initialBook;
            bookCount = 1;

        }
        

        public Book[] books;

        private int bookCount;
        


        public void addBook(Book book)
        {
            
            bool check = false;

            for(int i = 0; i < books.Length; i++)
            {

                if (books[i] == book)
                {
                    check = true;


                }



            }

            if (check != true)
            {






                Array.Resize(ref books, books.Length+1);
                books[bookCount] = book;
                bookCount++;




            }
            else Console.WriteLine("Bu kitab movcuddur");

        }

        public void removeBook(int num)
        {
              for(int i = 0;i < books.Length;i++)
              {
                if(num == i)
                {
                    num = i;
                    break;


                }


              }
            Book[] booksR = new Book[books.Length-1];
            int j = 0;
            for (int i=0;i<books.Length;i++)
            {
                if(i != num)
                {
                    booksR[j] = books[i];
                    j++;

                }


            }
                
            Array.Resize(ref books, books.Length-1);
            books= booksR;

        
        }

        public void displayBooks()
        {
            for(int i = 0;i < books.Length;i++)
            {
                
                
                Console.WriteLine($"Kitab nomresi  {i} {books[i].Name}");
                


            }


        }

        public void FindBookByName(string name1)
        {
            bool found = false;
            for (int i = 0; i < books.Length;i++)
            {

                if (name1 == books[i].Name)
                {
                    Console.WriteLine($"Kitabin adi:{books[i].Name}");
                    Console.WriteLine(books[i].Price);
                    Console.WriteLine(books[i].Genre);
                    found = true;
                    break;
                   
                }


            }

            if(!found)
            {
                Console.WriteLine("Bele bir kitab yoxdur");
                
            }

        }

        public void FindBookByChar(string a)
        {

            for (int i = 0;i<books.Length; i++)
            {
                books[i].Name.Contains(a);

                Console.WriteLine(books[i].Name);

            }


        }
    }
}
