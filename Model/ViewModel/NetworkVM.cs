using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class NetworkVM
    {
        public GraphVM GraphData { get; set; }

        public List<string> Labels { get; set; }

        public List<string> Nodes { get; set; }
    }
}
