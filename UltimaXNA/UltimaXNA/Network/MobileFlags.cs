﻿/***************************************************************************
 *   MobileFlags.cs
 *   Part of UltimaXNA: http://code.google.com/p/ultimaxna
 *   
 *   begin                : May 31, 2009
 *   email                : poplicola@ultimaxna.com
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace UltimaXNA.Network
{
    public class MobileFlags
    {
        /// <summary>
        /// These are the only flags sent by RunUO
        /// 0x02 = female
        /// 0x04 = poisoned
        /// 0x08 = blessed/yellow health bar
        /// 0x40 = warmode
        /// 0x80 = hidden
        /// </summary>
        readonly byte _flags;

        public bool IsFemale { get { return ((_flags & 0x02) != 0); } }
        public bool IsPoisoned { get { return ((_flags & 0x04) != 0); } }
        public bool IsBlessed { get { return ((_flags & 0x08) != 0); } }
        public bool IsWarMode { get { return ((_flags & 0x40) != 0); } }
        public bool IsHidden { get { return ((_flags & 0x80) != 0); } }

        public MobileFlags(byte flags)
        {
            _flags = flags;
        }
    }
}