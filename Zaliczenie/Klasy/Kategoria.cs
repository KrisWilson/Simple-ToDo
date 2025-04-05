using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaliczenie
{
    public partial class Kategoria
    {
        public int Id { get; set; }
        static int next = -1;
        static int NextId()
        {
            next++;
            return next;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public GroupBox representation { get; set; }

        public LinkedList<Wpis> Wpis = new LinkedList<Wpis>();
        public Kategoria(string name, string desc) {
            Id = NextId();
            Name = name;
            Description = desc;
            Wpis.AddLast(new Wpis());
        }



        
    }
}
