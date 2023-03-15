using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Välj ett tal mellan 1 och 10 : ");
            int val = Convert.ToInt32(Console.ReadLine());

            Random slump = new Random();

            int snurr = slump.Next(1,11);

            Console.WriteLine("Lyckohjulet fick " + snurr);

            if (val==snurr)
            {
                Console.WriteLine("Du vann! ");
            } 
            else
            {
                Console.WriteLine("Du förlorade! ");
            }




        }
    }
}
