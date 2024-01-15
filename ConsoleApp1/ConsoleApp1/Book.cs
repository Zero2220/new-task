using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book:Product
    {
        public Book(string Name,int Price,string Genre ) :base( Name, Price) 
        { 
        this.Genre = Genre;
        
        }

        public string Genre;
    }
}
