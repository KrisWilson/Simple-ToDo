using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zaliczenie
{
    public class Wpis
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Wpis()
        {
            Name = "Zakupy";
            Description = "Będę jeść banany" + Environment.NewLine + "Uwielbiam kakako" + Environment.NewLine + "Nie bede myśleć o sesji";
            Deadline = DateTime.Today.AddHours(1);
        }
        public Wpis(string name, string description, DateTime deadline)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
        }
    }
}
