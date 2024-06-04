using Microsoft.EntityFrameworkCore;
using WAD_REFDEF_BACKEND_14016.Models;

namespace WAD_REFDEF_BACKEND_14016.Data
{
public class KeyUseDbContext : DbContext
{
    public KeyUseDbContext(DbContextOptions<KeyUseDbContext> options) : base(options) { }
    public DbSet<Key> Keys { get; set; }
    public DbSet<User> Users { get; set; }
}
}

