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
            base.Study();
            Console.WriteLine("I study good.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I read good.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I write good.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I relax good");
        }
    }
}
