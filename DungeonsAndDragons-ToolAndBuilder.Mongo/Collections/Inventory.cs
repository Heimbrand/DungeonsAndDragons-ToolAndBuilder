﻿using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class Inventory : BaseDocument
{
    public string Name { get; set; }
    public int MaxWeight { get; set; }
    public int CurrentWeight { get; set; }
    public string InventoryImg { get; set; }

}