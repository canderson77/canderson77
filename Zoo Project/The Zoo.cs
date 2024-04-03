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
           Tiger Tim = new Tiger();
           Tiger.legs = 4;
           Tiger.color = orange;
           Tiger.ability = run;
           int runningSpeed = Tiger.run(x+500);
           Console.WriteLine(runningSpeed);
           Tiger.animalSound;

           Flamingo Fred = new Flamingo();
           Flamingo.legs = 2;
           Flamingo.color = pink;
           Flamingo.ability = hop;
           int hoppingSpeed = Flamingo.hop(x-2);
           Console.WriteLine(hoppingSpeed);
           Flamingo.animalSound;

           Hippo Harry = new Hippo();
           Hippo.legs = 4;
           Hippo.color = gray;
           Hippo.ability = waddle;
           int waddlingSpeed = Hippo.waddle(x+2*5);
           Console.WriteLine(waddlingSpeed);
           Hippo.animalSound;

       }
    }
}
