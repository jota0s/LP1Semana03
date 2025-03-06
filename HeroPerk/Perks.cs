using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3,
        none = 0
    }
}
