using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicOfCsharp
{
    internal class AreaOfCircle


    {
        static double calculateAreaOfCircle(double redius) 
        {
            return 3.14 * redius * redius;
        
        }
        static void main(String[] args)
            
        {
          Console.WriteLine( "Area of circle" +AreaOfCircle.calculateAreaOfCircle(100));

        }
    }
}
