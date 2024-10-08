﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

public interface ISubRaceRepository : IRepository<SubRace, int>
{
    Task<SubRace> GetSubRaceByCharacterId(int id);
  
}