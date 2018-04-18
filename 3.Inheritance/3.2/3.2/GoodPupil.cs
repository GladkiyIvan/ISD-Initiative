using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study good.");
        }
        public override void Read()
        {
            Console.WriteLine("I read good.");
        }
        public override void Write()
        {
            Console.WriteLine("I write good.");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax good");
        }
    }
}
