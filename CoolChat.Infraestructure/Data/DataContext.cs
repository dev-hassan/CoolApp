using System.Data.Entity;
using CoolChat.Core.Models;

namespace CoolChat.Infraestructure.Data
{
    public class DataContext : BaseContext<DataContext>
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Chat> Chats { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
                   
    }
}