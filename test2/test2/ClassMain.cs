using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librarySpell;

namespace testSpell
{
    public class ClassMain
    {
        static void Main(string[] args)
        {
            spellClass s = new spellClass();
            DateTime date = DateTime.Today;
            Console.WriteLine(s.spell(date));
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.Read();
        }
    }
}
