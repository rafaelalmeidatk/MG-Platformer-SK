﻿using System.Collections.Generic;

using Microsoft.Xna.Framework;

namespace MG_Platformer_SK.Sprites
{
    public class FrameInfo
    {
        public Rectangle SpriteSheetInfo { get; set; }
        public List<SpriteCollider> AttackColliders { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }

        public FrameInfo(Rectangle spriteSheetInfo, int offsetX, int offsetY)
        {
            SpriteSheetInfo = spriteSheetInfo;
            AttackColliders = new List<SpriteCollider>();
            OffsetX = offsetX;
            OffsetY = offsetY;
        }
    }
}
