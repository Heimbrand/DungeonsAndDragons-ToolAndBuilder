﻿namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Skill : BaseEntity
{
    // Acrobatics, Animal Handling, Arcana, Athletics, Deception, History, Insight, Intimidation etc...

    public int MonsterId { get; set; }
    public int CharacterId { get; set; }

    public string Name { get; set; } = default!; // i.e. Acrobatics
    public int Bonus { get; set; } //add the caracter's ability modifier to this and the proficiency bonus if the character is proficient in this skill
    public string Modifier { get; set; } = default!;  // i.e. Dexterity
    public bool IsPre5E { get; set; } = default!;
}