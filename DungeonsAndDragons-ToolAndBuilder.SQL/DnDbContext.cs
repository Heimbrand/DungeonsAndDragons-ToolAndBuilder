using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace DungeonsAndDragons_ToolAndBuilder.SQL;

public class DnDbContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Consumable> Consumables { get; set; }
    public DbSet<Crafting> Crafting { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Faction> Factions { get; set; }
    public DbSet<GameAction> GameActions { get; set; }
    public DbSet<Armor> Gear { get; set; }
    public DbSet<Heirloom> Heirlooms { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<MagicalArtifact> MagicalArtifacts { get; set; }
    public DbSet<MiscellaneousItem> MiscellaneousItems { get; set; }
    public DbSet<Monster> Monsters { get; set; }
    public DbSet<Npc> Npcs { get; set; }
    public DbSet<QuestItem> QuestItems { get; set; }
    public DbSet<SideQuest> SideQuests { get; set; }
    public DbSet<SubClass> SubClasses { get; set; }
    public DbSet<SubRace> SubRaces { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<World> Worlds { get; set; }


    public DnDbContext(DbContextOptions<DnDbContext> options) : base(options)
    {
    }
}