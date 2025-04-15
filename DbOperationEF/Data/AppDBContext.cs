using Microsoft.EntityFrameworkCore;

namespace DbOperationEF.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }
    }
}
