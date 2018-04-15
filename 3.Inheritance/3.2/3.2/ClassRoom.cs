using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class ClassRoom
    {
        public ClassRoom(Pupil name)
        {
            name.Study();
        }
        public ClassRoom(Pupil name, Pupil name1) : this(name)
        {
            name1.Study();
        }
        public ClassRoom(Pupil name, Pupil name1, Pupil name2) : this(name, name1)
        {
            name2.Study();
        }
        public ClassRoom(Pupil name, Pupil name1, Pupil name2, Pupil name3) : this(name, name1, name2)
        {
            name3.Study();
        }
    }
}
