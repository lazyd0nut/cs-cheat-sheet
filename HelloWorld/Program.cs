using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndieHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef(); //parent class
            chef1.MakeDish();

            ItalianChef italchf = new ItalianChef(); //subclass
            italchf.MakeDish();
            italchf.MakeIalianFood();

        }
  }
}  


//------------Hat------------//
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;


// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
           

//         }
//     }
// }



//------------Types of Data------------//
// string phrase = "hello world";
// char grade = 'A';
// int age = 20;
// Console.WriteLine(age);
// age += age;
// Console.WriteLine(age);
// double agqw = 3.3;
// bool good = false;

//------------String + WriteLine + ReadLine------------//
// string phrase = "Hellol world";
// Console.WriteLine(phrase.IndexOf("H"));

// Console.WriteLine(5*8);
// Console.ReadLine();

// Console.WriteLine("Inut your name:");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name + "!");
// Console.ReadLine();

//------------SimpleCalc------------//
// Console.WriteLine("Calc app v1.0");
// Console.Write("Enter num1:");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter num2:");
// double num2 = Convert.ToDouble(Console.ReadLine()); 
// Console.WriteLine(num1 + num2);
// Console.ReadLine();


//------------MadLibGame------------//
// string color, pluralNoun, celebrity;

// Console.WriteLine("Enter color:");
// color = Console.ReadLine();

// Console.WriteLine("Enter plural noun:");
// pluralNoun = Console.ReadLine();

// Console.WriteLine("Enter celebrity name:");
// celebrity = Console.ReadLine();
// Console.WriteLine("Roses are " + color);
// Console.WriteLine(pluralNoun + " are blue");
// Console.WriteLine("I love " + "Tom Hanks");
// Console.ReadLine();

//------------Arrays------------//
// int [] someArray = {1 ,2 ,3 ,4 ,5 ,6 ,7};
//string newstr = new string[5];
// string[] someStrArray = {"hello", "world",  "!"};
// Console.WriteLine(someArray[3]);
// Console.WriteLine(someStrArray[1]);
// someArray[3] = 9212;
// someStrArray[1] = "bro";
// Console.WriteLine(someArray[3]);
// Console.WriteLine(someStrArray[1]);

//------------Func/Method(No return)------------//
        // static void Main(string[] args)
        // {
            
        //     SayHi("Johny", 33);
        //     Console.ReadLine();
        // }

        // static void SayHi(string name, int age)
        // {
        //     Console.WriteLine("Hi, " + name + ". Your age is " + age);
        // } 




//------------Func/Method(With return)------------//
    //             static void Main(string[] args)
    //     {
    //         Console.WriteLine(cube(3));
    //         Console.ReadLine();
    //     }

    //     static int cube(int num)
    //     {
    //         int result = num * num * num;
    //         return result;
    //     } 
    // }


//------------if------------//
            //     Console.Write("Are you dolboeb?");
            // string answr = Console.ReadLine();
            // bool iamDolboeb = true;
            // bool makeIndieGame;

            // if(answr == "no")
            // {
            //     Console.WriteLine("Pizdish.");
            // }

            // if(iamDolboeb == true)
            // {
            //     makeIndieGame = true;
            //     Console.WriteLine("Make indie game = " + makeIndieGame);
            // }


//------------Switch------------//
// static void Main(string[] args)
//         {
            
//             Console.Write("Enter your day:");
//             Console.Write(GetDay(Convert.ToInt16(Console.ReadLine())));
//             Console.ReadLine();
//         }
//         static string GetDay(int dayNum)
//         {
//             string dayName;
//             switch(dayNum)
//             {
//                 case 0:
//                     dayName = "Sunday";
//                     break;
//                 case 1:
//                     dayName = "Monday";
//                     break;
//                 case 2:
//                     dayName = "Tuesday";
//                     break;
//                 case 3:
//                     dayName = "Friday";
//                     break;
//                 default:
//                     dayName = "Day is not included";
//                     break;
//             }
//             return dayName;;
//         }
//     }


//------------DoWhile------------//
//  int index = 6;
//             do
//             {
//                 Console.WriteLine(index);
//                 index++;
//             }
//             while(index <= 5);           
//             Console.ReadLine();



//------------For loops------------//
            // Console.Write("Enter your number: ");
            // int a = Convert.ToInt16(Console.ReadLine());
            // Console.Write("Enter your pow num:");
            // int b = Convert.ToInt16(Console.ReadLine());

            // for(int i = 1; i <= b; i++)
            // {
            //     a = a * a;
            //     Console.WriteLine(a);
            // }
            // Console.Write("Your num is: " + a);
            // Console.ReadLine();

        //func edition
        // static void Main(string[] args)
        // {
        //     Console.Write(GetPow(2,2));
        //     Console.ReadLine();
        // }
        // static int GetPow(int a, int b) {
        //     for(int i = 1; i < b; i++)
        //     {
        //         a = a * a;
        //     }
        //     return a;
        // }

//------------2D Arrays------------//
            //         int[,] numberGrid = {
            //     {1, 2, 3},
            //     {4, 5, 6},
            // };
            // for(int i = 0; i < numberGrid.GetLength(0); i++)
            // {
            //     for(int j = 0; j < numberGrid.GetLength(1); j++)
            //     {
            //         Console.Write(numberGrid[i, j]);
            //     }
            //     Console.WriteLine();
            // }
            // Console.ReadLine();

//------------Exception------------//
//             try
//             {
//                 Console.Write("Enter your num1: ");
//                 int num1 = Convert.ToInt16(Console.ReadLine());
//                 Console.Write("Enter your num2: ");
//                 int num2 = Convert.ToInt16(Console.ReadLine());
//                 Console.WriteLine(num1/num2);
//                 Console.ReadLine();
//             }
//             catch(FormatException e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//             catch(Exception e)
//             {
//                 Console.WriteLine(e.Message);
//             }


//------------declare Class------------//
    //     static void Main(string[] args)
    //     {
    //        Book book1 = new Book();
    //        book1.author = "Author";
    //        book1.title = "idk";
    //        book1.pages = 100;

    //        Console.WriteLine(book1.pages);

    //         Book book2 = new Book();

    //        Console.ReadLine();
    //     }
    // }


//------------Better Class------------//
        //     static void Main(string[] args)
        // {
        //     Book book1 = new Book("Author", "Title", 455);
        //     Console.WriteLine(book1.author);
        //     book1.title = "Another title";
        //
        //     Console.ReadLine();
        // }

//------------Class-Method------------//
        //         static void Main(string[] args)
        // {
        //     Vehicle veh1 = new Vehicle("Lamborgins", "blue", 33242);
        //     Vehicle veh2 = new Vehicle("xxx", "black", 900);
        //     Console.WriteLine("Expensive = " + veh1.isExpensive());
        //     Console.WriteLine("Expensive = " + veh2.isExpensive());            
        // }


//------------Static Class Attribute------------//
        // static void Main(string[] args)
        // {
        //     Vehicle veh1 = new Vehicle("Lamborgins", "bbvlv", 33242);
        //     Vehicle veh2 = new Vehicle("xxx", "red", 900);
        //     Console.WriteLine("Expensive = " + veh1.isExpensive());
        //     Console.WriteLine("Expensive = " + veh2.isExpensive());
        //     Console.WriteLine(veh1.Color);
        //     Console.WriteLine(Vehicle.VehCount);
        //     Console.WriteLine(veh1.getVehCount());
        // }

//------------Static Methods&Classes------------//
        // UsefulTools.SayHi("Billy Herrington");