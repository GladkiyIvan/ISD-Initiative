using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil Yakov = new BadPupil();
            GoodPupil Ilya = new GoodPupil();
            ExcellentPupil Mark = new ExcellentPupil();
            ExcellentPupil Ivan = new ExcellentPupil();
            ClassRoom DNU = new ClassRoom(Yakov, Ilya, Mark ,Ivan);
            Console.ReadKey();
        }
    }
}
