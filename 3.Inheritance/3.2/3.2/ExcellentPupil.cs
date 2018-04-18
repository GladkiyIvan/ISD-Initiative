using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study excellent.");
        }
        public override void Read()
        {
            Console.WriteLine("I read excellent.");
        }
        public override void Write()
        {
            Console.WriteLine("I write excellent.");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax badly.");
        }
    }
}
