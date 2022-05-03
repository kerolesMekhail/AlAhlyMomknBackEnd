using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.DAL.Models
{
    public partial class Step
    {
        public Step()
        {
            items = new HashSet<Item>();
        }
        public int Id { get; set; }
        public string stepName { get; set; }
        public int stepNumber { get; set; }
        public ICollection<Item> items { get; set; }
    }
}
