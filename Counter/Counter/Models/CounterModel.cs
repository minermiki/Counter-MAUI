using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.Models
{
    internal class CounterModel
    {
        public string CounterName { get; set; }

        public string EditorPlaceholderText => "Wpisz nazwe licznika";
    }
}
