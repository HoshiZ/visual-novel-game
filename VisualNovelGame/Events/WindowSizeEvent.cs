﻿using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Events.EventArgs;

namespace VisualNovelGame.Events
{
    public class WindowSizeEvent : PubSubEvent<WindowSizeArgs>
    {
    }
}
