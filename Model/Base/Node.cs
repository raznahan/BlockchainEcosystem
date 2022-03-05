using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    public class Node
    {

        public Node()
        {
            Created = DateTime.UtcNow;
        }
        public int ID { get; set; }

        public string Label { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }
        


    }
}
