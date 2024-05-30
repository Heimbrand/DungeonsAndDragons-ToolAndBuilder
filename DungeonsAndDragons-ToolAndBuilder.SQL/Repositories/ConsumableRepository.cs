﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ConsumableRepository : IConsumableRepository
{
    public Task<Consumable> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Consumable>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Consumable>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Consumable> AddAsync(Consumable entity)
    {
        throw new NotImplementedException();
    }

    public Task<Consumable> UpdateAsync(Consumable entity)
    {
        throw new NotImplementedException();
    }

    public Task<Consumable> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}