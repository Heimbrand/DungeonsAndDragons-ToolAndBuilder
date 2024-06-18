
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace DungeonsAndDragons_ToolAndBuilder.SQL;

public class DnDbContext : DbContext
{

    public DbSet<Alignment> Alignments { get; set; }
    public DbSet<Armor> Armors { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<ClassFeature> ClassFeatures { get; set; }
    public DbSet<Condition> Conditions { get; set; }
    public DbSet<Consumable> Consumables { get; set; }
    public DbSet<Crafting> Craftings { get; set; }
    public DbSet<DamageType> DamageTypes { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Faction> Factions { get; set; }
    public DbSet<Feat> Feats { get; set; }
    public DbSet<GameAction> GameActions { get; set; }
    public DbSet<Heirloom> Heirlooms { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<MagicalArtifact> MagicalArtifacts { get; set; }
    public DbSet<Monster> Monsters { get; set; }
    public DbSet<MiscellaneousItem> MiscellaneousItems { get; set; }
    public DbSet<MonsterType> MonsterTypes { get; set; }
    public DbSet<MonsterTrait> MonsterTraits { get; set; }
    public DbSet<Npc> Npcs { get; set; }
    public DbSet<Proficiency> Proficiencies { get; set; }
    public DbSet<ProficiencyType> ProficiencyTypes { get; set; }
    public DbSet<QuestItem> QuestItems { get; set; }
    public DbSet<Race> Races { get; set; }
    public DbSet<RacialTrait> RacialTraits { get; set; }
    public DbSet<Reaction> Reactions { get; set; }
    public DbSet<Sense> Senses { get; set; }
    public DbSet<SideQuest> SideQuests { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SubClass> SubClasses { get; set; }
    public DbSet<SubClassFeature> SubClassFeatures { get; set; }
    public DbSet<SubRace> SubRaces { get; set; }
    public DbSet<SubRacialTrait> SubRacialTraits { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<World> Worlds { get; set; }
    public DnDbContext(DbContextOptions<DnDbContext> options) : base(options)
    {
        
    }
}