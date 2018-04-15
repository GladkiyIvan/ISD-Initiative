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
            base.Study();
            Console.WriteLine("I study excellent.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I read excellent.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I write excellent.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I relax badly.");
        }
    }
}
