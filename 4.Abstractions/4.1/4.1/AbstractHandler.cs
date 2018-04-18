using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();
    }
}
