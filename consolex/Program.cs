using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolex
{
    class Program
    {
        Stock astock;
        string choice = "";
        Stock[] assetarray = new Stock[100];
        int i = 0;
        string result = "";
        

        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Run();
        }
        
        void Run()
        {
            
            while(choice != "1")
            {
                Console.WriteLine("If you want to add a stock press 1 otherwise 2");
                string choice = Console.ReadLine();
                



                if (choice == "1")
                {
                    
                    
                    DoAction();
                }
                else if (choice == "2")
                {
                    for(int y= 0; y<i; y++)
                    {
                        result += assetarray[y].Symbol + " ";
                    }
                    Console.WriteLine(result);
                    
                }
            }

            
            
            
            
        }

        void DoAction()
        {
            
            Console.WriteLine("Your stock's name is: ");
            string asymbol = Console.ReadLine();
            Console.WriteLine(">>PRESS ENTER<<");
            Console.WriteLine("Price: ");
            string stringprice = Console.ReadLine();
            double price = Convert.ToDouble(stringprice);
            Console.WriteLine(">>PRESS ENTER<<");
            Console.WriteLine("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">>PRESS ENTER<<");
            astock = new Stock(asymbol, price, number);
            assetarray[i] = astock;
            i++;
            



        }
            
            

        

    }
}
