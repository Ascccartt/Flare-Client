﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class ClickTP : Module
    {
        public ClickTP() : base("ClickTP", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            KeybindHandler.clientKeyDownEvent += DownKeyHeld;
        }

        public void DownKeyHeld(object sender, clientKeyEvent e)
        {
            if (enabled)
            {
                if(e.key == (char)0x02)
                {
                    if(Statics.blockPosY > 0)
                    {
                        Minecraft.clientInstance.localPlayer.teleport((float)Statics.blockPosX, (float)Statics.blockPosY + 1, (float)Statics.blockPosZ);
                    }
                }
            }
        }
    }
}
