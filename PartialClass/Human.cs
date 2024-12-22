using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Human
    {
        public string foodType {  get; set; }
        public void Display() {
            Console.WriteLine("his food type is:" + foodType);
        }
    }
}
