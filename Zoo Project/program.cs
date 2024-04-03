using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    class Program
    {
       static void Main(string[] args)
       {
        string menu = "Welcome!\n Press 1 for Tiger \n Press 2 for Flamingos \n Press 3 to exit";
        Console.WriteLine(menu);
        int menuOption;
        try
        {
            menuOption= Convert.ToInt32(Console.ReadLine());
            Animal myAnimal = new Animal();
            Tiger myTiger = new Tiger();
            Flamingo myFlamingo = new Flamingo();
            Hippo myHippo = new Hippo();
            switch (menuOption)
            {
                case 1: 
                Console.WriteLine("What is your tigers name?");
                myTiger.name = Console.ReadLine();
                Console.WriteLine("What color is your tiger?");
                myTiger.color = Console.ReadLine();
                Console.WriteLine("How old is your tiger?");
                myTiger.age = Convert.ToInt(Console.ReadLine());
                filesave.save(myTiger);
                break;

                case 2:
                Console.WriteLine("What is your flamingos name?");
                myFlamingo.name = Console.ReadLine();
                Console.WriteLine("What color is your flamingo?");
                my.Flamingo.color = Console.ReadLine();
                Console.WriteLine("How old is your flamingo?");
                myFlamingo.age = Convert.ToInt(Console.ReadLine());
                Console.WriteLine("What is your flamingos wingspan?");
                myFlamingo.wingSpan = Convert.ToInt(Console.ReadLine());
                filesave.save(myFlamingo);
                break;

                case 3:
                Console.WriteLine("What is your hippos name?");
                myHippo.name = Console.ReadLine();
                Console.WriteLine("What color is your hippo?");
                myHippo.color = Console.ReadlLine();
                Console.WriteLine("How old is your hippo?");
                myHippo.age = Convert.To.Int(ConsoleReadLine());
                Console.WriteLine("How much does your hippo weigh?");
                myHippo.weight - Convert.To.Int(Console.ReadLine());
                filesave.save(myHippo);
                break; 
            }
        }
       }
