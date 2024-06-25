using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WeaponRepository(DnDbContext context) : IWeaponRepository
{
    public async Task<Weapon> GetByIdAsync(int id)
    {
        var weapon = await context.Weapons.FindAsync(id);

        if (weapon is null)
            throw new Exception("No Weapon found with that ID");

        return weapon;
    }

    public async Task<IEnumerable<Weapon>> GetAllAsync()
    {
        var allWeapons = await context.Weapons.ToListAsync();

        if (allWeapons is null)
            throw new Exception("No Weapons found");

        return allWeapons;
    }

    public async Task<IEnumerable<Weapon>> GetMany(int start, int count)
    {
        var getManyWeapons = await context.Weapons.Skip(start).Take(count).ToListAsync();

        if (getManyWeapons is null)
            throw new Exception("No Weapons found");

        return getManyWeapons;
    }

    public async Task AddAsync(Weapon entity)
    {
        var addWeapon = await context.Weapons.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Weapon entity)
    {
        var oldWeapon = await context.Weapons.FindAsync(entity.Id);

        if (oldWeapon is null)
            throw new Exception("No Weapon found with that ID");

        context.Entry(oldWeapon).CurrentValues.SetValues(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var weaponToDelete = await context.Weapons.FindAsync(id);

        if (weaponToDelete is null)
            throw new Exception("No Weapon found with that ID");

        context.Weapons.Remove(weaponToDelete);
    }

    public async Task<IEnumerable<Weapon>> GetWeaponByName(string name)
    {
        var weaponByName = await context.Weapons.ToListAsync();

        var fuzzyScored = weaponByName.Select(weapon => new
            {
                Weapon = weapon,
                Score = FuzzySharp.Fuzz.PartialRatio(weapon.Name, name)
            })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Weapon);

        return fuzzyScored;
    }
    public async Task<IEnumerable<Weapon>> GetWeaponsByType(string type)
    {
        var weaponsByType = await context.Weapons.Where(x => x.WeaponType == type).ToListAsync();

        if (weaponsByType is null)
            throw new Exception("No Weapons found with that type");

        return weaponsByType;
    }

    public async Task<IEnumerable<Weapon>> GetWeaponsByDamageType(string damageType)
    {
        var weaponsByDamageType = await context.Weapons.Where(x => x.DamageType == damageType).ToListAsync();

        if (weaponsByDamageType is null)
            throw new Exception("No Weapons found with that damage type");

        return weaponsByDamageType;
    }

    public async Task<IEnumerable<Weapon>> GetWeaponByRarity(string rarity)
    {
        var weaponsByRarity = await context.Weapons.Where(x => x.Rarity == rarity).ToListAsync();

        if (weaponsByRarity is null)
            throw new Exception("No Weapons found with that rarity");

        return weaponsByRarity;
    }

    public async Task<IEnumerable<Weapon>> GetWeaponByProperties(string properties)
    {
        var weaponsByProperties = await context.Weapons.Where(x => x.Properties == properties).ToListAsync();

        if (weaponsByProperties is null)
            throw new Exception("No Weapons found with that property");

        return weaponsByProperties;
    }
}