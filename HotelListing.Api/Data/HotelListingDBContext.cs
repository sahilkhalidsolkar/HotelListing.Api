using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data;

public class HotelListingDBContext:DbContext
{
    public HotelListingDBContext(DbContextOptions options) : base(options)
    { 
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Hotel> Hotels { get; set; }

}
