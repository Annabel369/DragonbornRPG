using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonbornRPG;

public class PlayerStats
{
    public ulong SteamId { get; set; }
    public int XP { get; set; } = 0;
    public int Level { get; set; } = 1;
    public DateTime? LastInferno { get; set; }
}
