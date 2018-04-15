using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("I study bad.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I read badly.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I write badly.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I relax excellent");
        }
    }
}
