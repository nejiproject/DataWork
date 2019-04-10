using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataWork.Class
{
    public class WorkerContext : DbContext
    {
        public WorkerContext() : base("DbConnection") { }
        public DbSet<Worker> Workers { get; set; }
    }
}
