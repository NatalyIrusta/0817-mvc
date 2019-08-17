using System.Data.Entity;

namespace _0817mvc.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<_0817mvc.Models.Student> Students { get; set; }
    }
}