﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface IHeirloomRepository : IRepository<Heirloom, int>
{
    Task<IEnumerable<Heirloom>> GetHeirloomsByAdventure(string adventure);

}