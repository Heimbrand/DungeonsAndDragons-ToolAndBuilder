# DungeonsAndDragons-ToolAndBuilder

## What kind of a project is this?

This is a private project, which I have chosen to do purely out of passion for both DnD and coding. This project will be a work in progress for a long while. I plan on constantly working on improving it. The reason is that I want to have something that will help me advance my skills in .NET full-stack development, and also to make a proper application which people who enjoy DnD can actually make use of.

> The purpose of the app is split into two parts so far. The first part is that it will be a databank of sorts for everything that I manage to import into my many databases which I will use. My goal is that it will be a platform where you can gather and view everything that is needed to know when either planning an adventure as a DM or when questions arise during an adventure, for DMs and players alike.

> The second part is focused more on interaction with the program. I plan on making it possible for users to have a secure account with hashed passwords. With their own account, people will be able to build their characters on there with a character sheet, collect items, import subclasses, and engage in battles. Everything will be limited by the rules of DnD 5e, meaning you can only import a subclass when your level is high enough, you can only equip gear if the requirements are met, etc.

> As for the battles: I plan on first implementing a battle simulator of sorts. Where you can choose to battle different kinds of opponents such as NPCs, other players, and monsters to view what your odds are in a real battle. If/When I ever get happy enough with the implementation of battles, meaning; it's close enough to a real DnD battle, then I might recommend it for "live use" in actual fights in adventures.

## Current state of App: 

New project, working on the design of the databases.

---

### Tables/Collections

* ApplicationUser - SQL
* Characters - SQL
* Classes - SQL
* Consumables - SQL
* Crafting (Work in progress) - SQL
* Events - SQL
* Factions - SQL
* GameActions - SQL
* Gear - SQL
* Heirlooms - SQL
* Locations - SQL
* Magical artifacts - SQL
* MiscellaneousItems - SQL
* Monster - SQL
* Npc's - SQL
* Quest items - SQL
* Sidequests - SQL
* Subclasses - SQL
* SubRaces - SQL
* Tag - SQL
* Weapons - SQL
* WeaponProperty - SQL
* Worlds - SQL
* LegendaryActions - SQL
* Type - SQL
* Alignments - SQL
* Reaction - SQL
* Skill - SQL
* Size - SQL
* DamageType - SQL
* Condition - SQL
* Sense - SQL
* Challenge - SQL
* Language - SQL
* WeaponType - SQL
* Ability - SQL
* Trait - SQL


* Inventory - MongoDb
* InventoryItems - MongoDb
  
  ---

### Features

* A personal login where you can build your own characters
* Create adventures
* Create Sidequests
* Store Maps
* Store events such as certain scenarios for the adventurers (if you are DM)
* Keep a journal of the adventure
* Simulate fights between both other characters aswell as monsters to see how good your chances are. If i am satisfied with how "close to the truth" i get with the actual fights, i will also recommend it for in game usage.
* View % chances of winning/losing
* View Fighting logs (if you dont wish to follow the fights step by step)
  
---
