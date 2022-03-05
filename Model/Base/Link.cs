using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    public class Link
    {

        public Link()
        {
            Created = DateTime.UtcNow;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Source")]
        public int From { get; set; }


        [ForeignKey("Target")]
        public int To { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public bool Dashes { get; set; }

        public DateTime Created { get; set; }

        public virtual Node Source { get; set; }

        public virtual Node Target { get; set; }
    }
}
