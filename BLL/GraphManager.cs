using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model.Base;
using Model.ViewModel;
using BLL.Helper;
using System.Text.RegularExpressions;

namespace BLL
{
    public class GraphManager
    {

        public static async Task<object> GetGraphData()
        {

            using (Context ctx = new Context())
            {
                var links = await ctx.Links.ToListAsync();
                var linksVm = links.Select(m => m.ToVM()).ToList();

                var nodes = await ctx.Nodes.ToListAsync();
                var nodesVm = nodes.Select(m => m.ToVM()).ToList();


                List<string> labels = new List<string>();

                foreach (var item in nodesVm.Select(m => m.label).ToList())
                {

                    labels.Add(item.ToLowerInvariant());
                }

                return new NetworkVM() { GraphData = new GraphVM() { nodes = nodesVm, edges = linksVm }, Labels = labels, Nodes = nodes.Select(m=>m.ID.ToString()).ToList() };

            }

        }
    }
}
