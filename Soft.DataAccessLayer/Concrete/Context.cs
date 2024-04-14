using Microsoft.EntityFrameworkCore;
using Soft.EntityLayer.Concrete;

namespace Soft.DataAccessLayer.Concrete
{
    public class Context : DbContext //Db context den miras alıyor.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-I5HOE43\\SQLEXPRESS;Database=SoftructureDemo;Trusted_Connection=true");

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I5HOE43\SQLEXPRESS;Database=SoftructureDemo;Trusted_Connection=true;TrustServerCertificate=True");



            //"Server=DESKTOP-I5HOE43\\SQLExpress;Database=netCore.Project;Trusted_Connection=True;MultipleActiveResultSets=true"
        }

        //Product nesnesini veritabanındaki producta bağlama işlemi
        public DbSet<Product> Products { get; set; }
    }
}
