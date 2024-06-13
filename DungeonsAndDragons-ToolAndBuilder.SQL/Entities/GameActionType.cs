﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class GameActionType : IEntity<int>
{
    public int Id { get; set; }
    public int GameActionId { get; set; }
    public string Name { get; set; } = default!; // ClassAction, SubClassAction, RaceAction, SubRaceAction, MonsterAction, CharacterAction, NpcAction
    public string Prerequisite { get; set; } = default!; // Gnome, Rock Gnome, Wizard, Illusionist, Dragon, Red Dragon, Player, Non-Player Character etc
    public string? Description { get; set; }
}
    

