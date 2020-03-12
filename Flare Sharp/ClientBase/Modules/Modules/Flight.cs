﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Flight : Module
    {
        public Flight() : base("Flight", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }

        public override void onDisable()
        {
            base.onDisable();
            Minecraft.clientInstance.localPlayer.isFlying = 0;
        }

        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.localPlayer.isFlying = 1;
        }
    }
}
