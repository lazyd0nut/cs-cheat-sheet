using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndieHorror
{
    class Vehicle
    {
        public string name;
        private string color = "no_color";
        public int cost;

        public static int VehCount = 0;

        public Vehicle(string aName, string aColor, int aCost)
        {
            name = aName;
            Color = aColor;
            cost = aCost;
            
            Console.WriteLine(name);
            Console.WriteLine(color);
            Console.WriteLine(cost);
            VehCount++;
        }
        public bool isExpensive()
        {
            if(cost < 1000)
            {
                return false;
            }
            return true;
        }
        public string Color
        {
            get{return color;}
            set{
                if(value == "red" || value == "green" || value == "blue" || value == "no_color")
                {
                    color = value;
                }
                else
                {
                    color = "no_color";
                }                
            }
        }
        public int getVehCount()
        {
            return VehCount;
        }
    }
}



//------------Class------------//
// namespace IndieHorror
// {
//     class Book
//     {
//         public string title;
//         public string author;
//         public int pages;
//     }
// }

//------------Constructor------------//
        // public Book(string title, string author, int pages)
        // {
        //     Console.WriteLine("Title: " + title);
        //     Console.WriteLine("Author: " + author);
        //     Console.WriteLine("Pages: " + pages);
        // }

//------------Better Class/Constructor------------//
    // class Book
    // {
    //     public string title;
    //     public string author;
    //     public int pages;

    //     public Book(string aTitle, string aAuthor, int aPages)
    //     {
    //         title = aTitle;
    //         author = aAuthor;
    //         pages = aPages;
    //         Console.WriteLine("Title: " + title);
    //         Console.WriteLine("Author: " + author);
    //         Console.WriteLine("Pages: " + pages);
    //     }
    // }


    //------------Class build Method and Constructor------------//
    //     class Vehicle
    // {
    //     public string name;
    //     public string color;
    //     public int cost;

    //     public Vehicle(string aName, string aColor, int aCost)
    //     {
    //         name = aName;
    //         color = aColor;
    //         cost = aCost;

    //         Console.WriteLine(name);
    //         Console.WriteLine(color);
    //         Console.WriteLine(cost);
    //     }
    //     public bool isExpensive()
    //     {
    //         if(cost < 1000)
    //         {
    //             return false;
    //         }
    //         return true;
    //     }
    // }



    //------------Class Private attribute. Getter, Setter.------------//
    // class Vehicle
    // {
    //     public string name;
    //     private string color;
    //     public int cost;

    //     public Vehicle(string aName, string aColor, int aCost)
    //     {
    //         name = aName;
    //         Color = aColor;
    //         cost = aCost;
            

    //         Console.WriteLine(name);
    //         Console.WriteLine(color);
    //         Console.WriteLine(cost);
    //     }
    //     public bool isExpensive()
    //     {
    //         if(cost < 1000)
    //         {
    //             return false;
    //         }
    //         return true;
    //     }
    //     public string Color
    //     {
    //         get{return color;}
    //         set{
    //             if(value == "red" || value == "green" || value == "blue" || value == "no_color")
    //             {
    //                 color = value;
    //             }
    //             else
    //             {
    //                 color = "no_color";
    //             }                
    //         }
    //     }
    // }


    //------------Static Class Attribute------------//
    //    class Vehicle
    // {
    //     public string name;
    //     private string color = "no_color";
    //     public int cost;

    //     public static int VehCount = 0;

    //     public Vehicle(string aName, string aColor, int aCost)
    //     {
    //         name = aName;
    //         Color = aColor;
    //         cost = aCost;
            
    //         Console.WriteLine(name);
    //         Console.WriteLine(color);
    //         Console.WriteLine(cost);
    //         VehCount++;
    //     }
    //     public bool isExpensive()
    //     {
    //         if(cost < 1000)
    //         {
    //             return false;
    //         }
    //         return true;
    //     }
    //     public string Color
    //     {
    //         get{return color;}
    //         set{
    //             if(value == "red" || value == "green" || value == "blue" || value == "no_color")
    //             {
    //                 color = value;
    //             }
    //             else
    //             {
    //                 color = "no_color";
    //             }                
    //         }
    //     }
    //     public int getVehCount()
    //     {
    //         return VehCount;
    //     }
    // }