using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface human
    {
        public void Display();
    }

    public class HumanService : human
    {
        public void Display()
        {
            Console.WriteLine("Pikachu is an Electric type");
        }
    }
}
