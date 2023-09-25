using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_1_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hello C#

            //Console.WriteLine("Hello CSharp");

            #endregion

            #region Throwing Exception 

            throw new NotImplementedException("Intended Exception");
            Console.WriteLine("Hello C#!");   // because of thrown exception this code is not reachable

            #endregion

        }
    }
}
