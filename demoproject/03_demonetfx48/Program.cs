using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_demonetfx48
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AdventureWorks2016Entities())
            {
                var query = from p in db.SalesOrderDetail
                    from q in db.SalesOrderHeader

                    orderby p.ProductID
                    select p;
                var lists = query.ToListAsync();
                Console.WriteLine(lists);
            }
        }
    }
}
