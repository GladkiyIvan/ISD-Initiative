using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            if (!File.Exists(appPath))
            {
                using (StreamWriter myFile = File.CreateText($@"{appPath}/file"))
                {
                    myFile.WriteLine("My head is haunting me and my heart feels like a ghost");
                    myFile.WriteLine("I need to feel something, 'cause I'm still so far from home");
                    myFile.WriteLine("Cross your heart and hope to die");
                    myFile.WriteLine("Promise me you'll never leave my side");
                }
            }

            using (StreamReader myFile = File.OpenText($@"{appPath}/file"))
            {
                string s = "";
                while ((s = myFile.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
