using Model.Base;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public static class Extension
    {

        public static NodeVM ToVM(this Node node)
        {

            return new NodeVM() {

                id = node.ID,
                color = new Color() { background = "#fff", border= "#fcb917" },
                image= node.Image,
                label = node.Label,
                link = node.Link
               
            };
        }

        public static LinkVM ToVM(this Link link)
        {

            return new LinkVM() {
                color = link.Type.Equals("financed") ? new Color() { background= "#fff", border= "#2bb4df" } : new Color() { background = "#fff", border = "#b4ff00" },
                dashes = link.Type.Equals("un") ? true : false,
                from  = link.From.ToString(),
                to  = link.To.ToString(),
                title = link.Title
            };
        }
    }
}
