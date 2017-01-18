﻿namespace Rasa.Structures
{
    public class Inventory
    {
        // 0-49 Equipment, 50-99 Consumables, 100-149 Crafting, 150-199 Mission, 200-249 Misc
        public uint[] PersonalInventory { get; set; }  = new uint[250]; // change index
        // 250 weapon, 251 helmet, 252 boots, 253 gloves, 254 unknown, 255 unknown
        // 256 unknown, 257 unknown, 258 unknown, 259 unknown, 260 unknown
        // 261 unknown, 262 unknown, 263 unknown, 264 unknown, 265 vest
        // 266 legs, 267 unknown, 268 unknown, 269 eyeweare, 270 unknown
        // 271 mask    (there is maybe more)         
        public uint[] EquippedInventory { get; set; } = new uint[22];
        // 272 weapondraver1, 273 weapondraver2, 274 weapondraver3, 275 weapondraver4, 276 weapondraver5
        // 277 weapondraver1ammo, 278 weapondraver2ammo, 279 weapondraver3ammo, 280 weapondraver4ammo, 281 weapondraver5ammo
        public uint[] WeaponDrawer { get; set; }  = new uint[5];
        //public uint[] slot { get; set; } = new uint[250 + 22 + 5];
        public int ActiveWeaponDrawer { get; set; }
    }
}
