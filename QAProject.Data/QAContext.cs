using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QAProject.Data
{
    public class QAContext : DbContext, IDisposable
    {
        public QAContext()
            : base("name=DefaultConnection")
        { }
        public DbSet<Message> Message {get; set;}       
    }
}
