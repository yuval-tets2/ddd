using Microsoft.EntityFrameworkCore;

namespace Ddd_1.Infrastructure;

public class Ddd_1DbContext : DbContext
{
    public Ddd_1DbContext(DbContextOptions<Ddd_1DbContext> options)
        : base(options) { }
}
