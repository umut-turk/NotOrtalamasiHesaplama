using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtalmasıHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1.   yazılı notunz");
            string girenNot1=Console.ReadLine();
            int yazili1=Convert.ToInt32(girenNot1);



            Console.WriteLine("2.   yazılı notunz");
            string girenNot2 = Console.ReadLine();
            int yazili2 = Convert.ToInt32(girenNot2);

            Console.WriteLine("1.   sozlu notunz");
           string girensozlu1 = Console.ReadLine();
         int sozlu1 = Convert.ToInt32(girensozlu1);


           Console.WriteLine("2.   sozlu notunz");
          string girensozlu2 = Console.ReadLine();
          int sozlu2 = Convert.ToInt32(girensozlu2);




            int ortlama = (yazili1 + yazili2 +sozlu1+sozlu2 )/4;


            if(yazili1>100 ||  yazili2>100|| sozlu1>100 || sozlu2 > 100)
            {
                Console.WriteLine("notların  hıc  biri  100 büyük olamza  ve  0 dan  kücük olamz ");
            }

            else if (yazili1 < 0 || yazili2 < 0 || sozlu1 < 0 || sozlu2 <=0)
            {
                Console.WriteLine("notların  hıc  biri  100 büyük olamza  ve  0 dan  kücük olamz ");
            }



             else if (ortlama >= 50)
             {
                Console.WriteLine("not   ortlamnız"+ " "  +ortlama + " "  +" sinfi gectınız");
            }


            else
            {
                Console.WriteLine("not   ortlamnız" + " " + ortlama + " " + " sinfi   gecemdınız");
            }
            Console.ReadLine();
        }
    }
}
