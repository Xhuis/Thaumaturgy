# Thaumaturgy
A mod for Terraria including magic and a doomed scholar.

Thaumaturgy adds an upgraded work bench, the Thaumatrestle, which is sold by a new town NPC, the Thaumaturge, a haunted academic who wants to put his skills to use. The Thaumatrestle can be used to break down fallen stars and mana crystals into power sources - auric shards and auric cores - which can then be used to craft, shape, transform, brew, and change objects in any way you can imagine.

The Thaumaturge will move in after defeating the Eye of Cthulhu. They are also eligibile from the get-go if the world is in Expert mode. They sell the Thaumatrestle for 1 gold, and pale stars for 10 silver. Pale stars can be used to ineffeciently make auric shards and auric cores, but have none of the other uses that fallen stars do.

Examples of recipes added by Thaumaturgy use include transmuting 25 crimstone into 25 ebonstone with an auric shard, creating a cloud in a bottle with 1 bottle, 20 clouds, and 3 auric shards, or replicating a piece of wood into 75 wood with an auric shard. All recipes are made at a Thaumatrestle, and most require a specialized focus nearby, which you can also purchase from the Thaumaturge.

A mod like Recipe Browser is highly recommended!

You are free to decompile, modify etc. this mod under the MIT License. The mod is available in-game through the mod browser, and will always be up-to-date.

# Credit Where Due

* **Xhuis** - Code, sprites.
* **Ilysen** - Code, sprites, and writing after 1.0.15.0.
* **Flaqzar** - Sprites for the starbrass armor set, starbrass tools, auric steel, auric steel tools, and all of the elixirs, potions, and draughts.
* **Re-Logic** - Terraria, and the sprites used as reference and basis for Thaumaturgy's.

# Changelog

### Feb. 4, 2020

#### 1.0.19.0

* Heavy cleanup of internal code structure and file hierarchy.
* The aural tether is no longer usable while your inventory window's open, to prevent accidental clearing of your mark.
* Added a recipe to directly craft an auric core with 6 fallen stars, instead of having to craft 2 mana crystals first.
* Added the rising star, a hardmode variant of the falling flame with infinite uses.
* Prevented the falling flame from clipping you out of bounds and requiring a relog.
* Removed the Falling Star cosmetic buff. This was a buff that got applied to you after using a falling flame, but because of how fast you were moving, none of its effects were visible.
* Resprited the Champion's Crest and added Starbrass to its recipe.
* Resprited the Aura Aegis.
* Made the Aura Aegis a bit more expensive.
* The Aura Aegis no longer protects from Electrified and Gravitation.
* Changed the Aura Aegis' rarity to reflect its status as an Expert-mode item.

### Jan. 31, 2020

#### 1.0.18.13

Been a while!

* Starbrass is now sold after Skeletron, instead of after the Eater of Worlds/Brain of Cthulhu. Because these bosses are sometimes skipped, it caused a strange hole in progression through the mod.
* Brightened the thaumatrestle's sprite.
* The Conjurer's Lamp now provides light while held in-hand.
* The Conjurer's Lamp can now consistently place glimmer lights underwater.
  * This was always intended design, but I originally hit a roadblock trying to make the torches linger underwater. I now know a lot more about C#, and so I'm able to rectify this.
* Fixed the Champion's Crest recipe not requiring a Hive Pack.
* Tidied up some code.

### Aug. 20, 2019

#### 1.0.18.12

* Fixes towards multiplayer use of the two tablet types.

### Aug. 19, 2019

#### 1.0.18.11

* Reduced the cost of the falling flame, from 10 -> 1 fallen star or 20 -> 2 pale stars.
* The falling flame can no longer be worn as an accessory, due to weirdness with it. Instead, a new accessory - called Velocity in a Jar - can be crafted using it that replicates the same effect.

### Aug. 15, 2019

#### 1.0.18.10

* Micro-optimisations to Thaumic Pie, which no longer takes up a buff.

#### 1.0.18.9

* New sprites for all elixirs, potions, and draughts by Flaqzar. Thank you very much.
* The aural tether's sprite swap now only adjusts the "mirror" portion of the item, instead of the frame as well.

#### 1.0.18.8

* Added the Champion's Crest, which combines the effects of all pre-Moon Lord expert accessories.
* Reduced auric core and shard costs across the board.
* Changed bottled lightning to use an auric shard in its recipe instead of an auric core, and removed its starfish requirement.
* The aural tether now has two different sprites, for telling if its mark is set at a glance.

### Aug. 14, 2019

#### 1.0.18.7

* Fixed an issue with Avarice's gem yield buff not working in multiplayer. (Thanks, jopojelly!)
* Added recipes for the enchanted nightcrawler and wand of sparking.

### Aug. 13, 2019

#### 1.0.18.6

* Added the Eternal Ordeal accessory, which prevents invasions from ending while worn. Farm away!
* Added the Purity Tablet, which prematurely ends Blood Moons and Solar Eclipses.
* Flasks can now be reused infinitely.
* Fixed the Auric Steel Waraxe using starbrass in its recipe instead of actual auric steel.
* Avarice now causes gem ores to drop extra gems!
* Slightly tweaked the Kaleidoscopic's Focus recipe (again) by adding souls of light, night, and flight to it.
* Removed crystal shards and the radar from the fish finder alternate recipe. (what the heck why were those there)
* Added the Terra Treads, a combination of frostspark boots and lava waders.
* Also added late-PH recipes for water walking boots and the lava charm to compensate for their rarity.

There are currently no safeguards in place preventing use of Eternal Ordeal and Purity Tablet in multiplayer. If someone wants to grief, they can; I can't easily fix that. Please be aware of that.

### Aug. 11, 2019

#### 1.0.18.5

* Rebalanced the value of tools and accessories to not make reforging wholly unfeasible.
* Added the Starbrass Pickaxe and Starbrass Hamaxe. Both deal magic damage instead of melee damage!
* Corrected the Auric Gunshell's tooltip stating that it had no knockback; guns would add knockback to it in spite of it having no innate knockback.
* Added Auric Steel. Make it with starbrass, meteorite, and iron or lead bars. It's included in the recipe for auromechanical armor, and can be used to make the Auric Steel Waraxe.
* Added the Auric Steel Waraxe, which is a pre-Hardmode melee weapon with high critical chance and deals magic damage.

### Aug. 10, 2019

#### 1.0.18.4

* Renamed alchemical brass to starbrass ~~because it sounds cooler~~ to differentiate it from Minecraft's Thaumcraft.
* Added the Starbrass armor set, an early pre-Hardmode magic armor set made of starbrass and auric ingredients.
* Added the Auromechanical armor set, an upgraded version of Starbrass armor with stronger effects.
* Fixed a bug where the Thaumaturge wouldn't sell to you if you'd beaten the Lunatic Cultist but not the Moon Lord.
* The Falling Flame can now also be worn as an accessory to boost max move speed! Its original use still exists.

### Aug. 7, 2019

#### 1.0.18.3

* Added the Potion of Soothing Embers and its elixir counterpart, the Elixir of Utter Calm, which hugely reduce enemy spawns.

#### 1.0.18.2

* The Kaleidoscopic Focus now functions as a Replication Focus. The Celestial Focus now also functions as both a Kaleidoscopic Focus and Replication Focus. In short: upgraded versions keep their recipes. You don't need one of each now.
* The Celestial Focus now requires one of reach lunar fragment.
* Added the Universal Focus, which functions as every focus. Craft it with all three foci and several auric cores.d
* The Thaumaturge now sells a new ingredient, Alchemical Brass, after the defeat of the Eater of Worlds/Brain of Cthulhu. Use it to make new stuff.
* Added the Aural Tether, which lets you mark a point, then later recall to it. Synthesise it with a magic mirror, alchemical brass, and auric cores.
* The Terran Bore now requires alchemical brass instead of meteorite, and has been recolored.
* The Auric Gunshell now requires alchemical brass, and has a new sprite.
* Added the Aura Aegis, which is synthesized by combining the Shield of Cthulhu and the Ankh Shield and provides both of their effects, as well as granting immunity to more debuffs.
* The Aurelian Harness can be stabilized using souls of flight, upgrading them to roughly on par with the Leaf Wings.
* Gave Ethereal Bullets (from the Auric Gunshell) fancy particles.
* Added the Falling Flame consumable item, which hurls you far into the distance. Craft several with a few fallen stars, a torch, and an auric core.
* The taumatrestle now functions as a table in NPC housing.
* Minor grammar changes.

#### 1.0.17.2

* Yes, Ava, you did in fact include the Auric Gunshell changelog. This patch removes that duplicate changelog. >>

#### 1.0.17.1

* Updated the homepage to the new forum thread. Yes, it's really me!

#### 1.0.17.0

* Added recipes for the endless quiver and endless musket pouch so that they're obtainable pre-Hardmode. They don't break balance!
* Added the Bind-Shackle accessory, which increases mining speed.
* Added the Auric Gunshell ammo item, which functions in the vein of the musket pouch, but higher damage and piercing at the cost of no knockback.
* Added the Pathfinder's Lamp accessory, which provides a small amount of light when worn.
* **Note:** Both of the following changes are made in an effort to balance out the power of elixirs and draughts. Both are currently almost entirely money-gated. In order to preevent it from just being a mindless material grind, the actual material costs are fairly low for each of the items; it's mostly a test of "can you get these materials during this progression point."
* Added the Treated Flask material (made with Meteorite, Hellstone, and Obsidian) and added it to the recipes for flasks.
* Added the Crystal Phial material (made with Crystal Shards and Souls of Light) and added it to the recipes for draughts.
* Added the Draught of Daredevilry, which combines both draughts into one!
* Updated sprites for all elixirs and draughts to represent the new bottles.
* Reduced the cost of all flasks by replacing their auric core cost with auric shards.

#### 1.0.16.3

* Fixed a long-standing bug with foci duplicating when they're hit.

### Jul. 30, 2019

#### 1.0.16.2

* Renamed Thaum Noms to Thaumic Pie.
* Thaumic Pie now automatically applies Well Fed, and is not consumed.
* Made Thaumic Pie a bit harder to craft, owing to being infinite.

#### 1.0.16.1

* Added increased reach to the conjurer's lamp, and reduced its rarity to blue. (It looks better with its colors. Don't judge.)
* Renamed auric torches to glimmer lights.
* Added a very small mana cost to the conjurer's lamp.
* Added phoenix down.

#### 1.0.16.0

* Massively reduced the chance of the Aurelian Harness malfunctioning, from 1 in 500 per frame to 1 in 20000.
* The Thaumaturge now only drops his goggles 10% of the time.
* Renamed the Elixir of Everburning Depths to the Elixir of Paradoxical Candleflame.
* Resprited the Watery Embers buff icon.
* Resprited the Slate Tablet.
* Buffed the Watery Embers potion a bit.
* Rewrote the Thaumaturge's lines.
* Removed fallen stars from the Thaumaturge's inventory - it broke balance both in vanilla and across mods. To compensate, pale stars are now much cheaper in hardmode.
* Stopped the Terran Bore from breaking into the temple.
* Made the Kaleidoscopic Focus require Pearlstone to prevent super fast rushing pre-Hardmode, breaking any semblance of balance.
* Replicating life crystals now requires an auric core.
* Added a recipe for the Rod of Discord.
* Added a replication recipe for life fruit with the Celestial Focus.
* Added the conjurer's lamp.
* Added a new mod browser icon.
* Rewrote the code for, and resprited, the aurelian harness.
* Various code cleanups.

### Feb. 21, 2019

#### 1.0.15.0

* Added the Potion of Watery Embers, which greatly increases spawn rate.
* Added a new sprite for the Thaumatrestle.

#### 1.0.14.0

* Further doubled the duration of the Draughts to 1 hour.
* The Draught of Daring now requires the Elixir of the Baron's Hoard, and has its effects.
* Removed grass seeds from the recipe for Thaum Noms.
* Added a new sprite for Thaum Noms.
* Pale stars now convert directly into auric cores instead of mana crystals. You'll still need fallen stars to up your mana.
* Removed the one-time texts for entering Hardmode and defeating Skeletron due to issues with multiplayer.
* Increased the cost of fallen stars in Hardmode.
* Removed the message for the Massive Terran Bore due to silliness with the chat log.
* Draught buffs are now preserved when saving and reloading.

### Jul. 14, 2018

#### 1.0.13.0
* Added the Glacial Highway potion, which forms a bridge of ice beneath you as you walk. Craft it with shiverthorn and a snow cloud.
  * Also added the Elixir of Ice Floes, the elixir form of the Glacial Highway potion.
* Recolored the Draught of Daring to reduce contrast clashing in its sprite.
* Elixirs and Draughts now only stack to 1 due to their reusable nature.
* Doubled the duration of both Draughts, from 15 minutes to 30 minutes.

### Jul. 13, 2018

#### 1.0.12.0
* Added the Massive Terran Bore, a quick and easy hellevator solution similar to the Instavator from Fargo's mod.

### Jul. 11, 2018

#### 1.0.11.1
* Adjusted the Void buff. Now it regenerates mana instead of setting the amount.
* Added elixir varieties of Avarice, Evasion, and Void potions.

### Jul. 10, 2018

#### 1.0.11.0
* Re-added healing elixirs! You can now craft non-consumable healing potions using thaumaturgy.
* Added three new potions: Avarice, Evasion, and Void.
  * Avarice potions increase coin pickup range. Craft them with daybloom and a silver coin.
  * Evasion potions allow a tabi dash if no dash item is active. Craft them with a shiverthorn and moonglow.
  * Void potions cause mana expenditure below 50% mana to drain health instead. Craft them with fallen stars, shiverthorn, and obsidian.

### Jul. 5, 2018

#### 1.0.10.3
* Removed Independence Day mod icon.
* Added the Aurelian Harness, a pre-hardmode substitute for wings. Craft it with wood, iron/lead, wire, meteorite, obsidian, and auric materials.

### Jul. 4, 2018

#### 1.0.10.2
* Happy Independence Day for American users!
* Some minor optimizations in code
* Begun work on late pre-hardmode wing substitute; not craftable yet

### Jul. 3, 2018

#### 1.0.10.1
* Added recipes for PDA composite ingredients using thaumaturgy, some unobtainable until hardmode.

#### 1.0.10.0
* Added a costly recipe for the Ankh Charm for use in mid-to-late hardmode.
* Added a recipe for Ice Skates.
* Accessory recipes now require a Synthesis Focus.
* Removed the recipe for Spellbound Water; it's now purchase-only.

### Jul. 1, 2018

#### 1.0.9.2
* Migration to new versioning system! Now W.X.Y.Z, where W is major release, X is large patch, Y is minor patch, and Z is tweak
* Massively reduced duplication rates on all recipes
* Made thaum noms slightly more expensive

#### 1.0.9
* Integrated recipes for Zerg and Zen potions from Calamity

#### 1.0.8
* Fixed an improper recipe for glowing mushroom duplication
* Added transmutation between wood types
* Added a recipe for spellbound water before Skeletron is defeated

### Jun. 30, 2018

#### 1.0.7
* Temporarily removed healing elixir recipes due to bugs; quick heal causes them to be used up

### Jun. 29, 2018

#### 1.0.5
* Modified healing elixir sprites to be more in-line with the main game

#### 1.0.3
* Added mod browser icon and changed changelog entry in the description.

#### 1.0.0
* Initial release and publication to GitHub.
* Licensed under MIT.
