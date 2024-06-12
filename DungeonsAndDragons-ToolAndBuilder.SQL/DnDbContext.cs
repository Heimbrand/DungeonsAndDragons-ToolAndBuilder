
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace DungeonsAndDragons_ToolAndBuilder.SQL;

public class DnDbContext : DbContext
{

    public DnDbContext(DbContextOptions<DnDbContext> options) : base(options)
    {
    }
}