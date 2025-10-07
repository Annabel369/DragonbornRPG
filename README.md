# 🐉 Dragonborn RPG Plugin
Version: 2.0.0

Author: Annabel, Aurorapar/show_inferno.cs
 
Special thanks to: AuroraPar for their contribution to the inferno system logic (Aurorapar/show_inferno.cs)

Description: A Counter-Strike 2 plugin that introduces RPG elements for Dragonborn players, including XP, leveling, cooldown-based abilities, and MySQL integration.

# 📦 Features

    - 🔥 Dragonborn Inferno Ability
    Players can cast a powerful inferno effect with a cooldown and visual feedback.
    - 🧠 XP and Level System
    Players earn XP for using abilities and level up automatically when reaching XP thresholds.
    - 🗃️ MySQL Integration
    All player stats are stored and synced using a MySQL database.
    - ⚙️ Configurable Settings
    Easily customize database credentials and access flags via DragonbornRPG.json.

# 📁 Configuration
    Upon first load, the plugin automatically generates a config file at:
    csgo/addons/counterstrikesharp/configs/plugins/DragonbornRPG.json


    Example Config:
    {
      "MySQLHost": "localhost",
      "MySQLUser": "root",
      "MySQLPassword": "0073007",
      "MySQLDatabase": "mariusbd",
      "RequiredFlags": ["@css/root", "@css/ban"]
    }



# 🧪 Commands
    |  |  | 
    | dragonborn_inferno |  | 
    | dragonborn_stats |  | 



# 🛠️ Requirements
    - CounterStrikeSharp API v80+
    - MySQL server with access credentials
    - Proper permissions for players to use abilities (RequiredFlags)

# 🙏 Credits
    Special thanks to AuroraPar for her foundational work on show_inferno.cs, which helped shape the visual and control logic of this plugin.
