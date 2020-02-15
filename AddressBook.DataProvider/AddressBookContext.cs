using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.DataProvider
{
    public class AddressBookContext : DbContext 
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
