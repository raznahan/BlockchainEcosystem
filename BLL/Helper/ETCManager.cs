using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BLL.Helper
{
    public class ETCManager
    {
        public static async Task ImportLogo()
        {

            using (Context ctx = new Context())
            {
                var nodes = await ctx.Nodes.Where(m=>m.ID > 98).ToListAsync();

                foreach (var item in nodes)
                {
                    item.Image = "136.243.48.96:4545/Content/Logo/" + item.Label + ".jpg";
                }

                await ctx.SaveChangesAsync();

            }
        }
    }
}
