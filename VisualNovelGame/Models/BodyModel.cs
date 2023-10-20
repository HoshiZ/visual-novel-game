using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGame.Models
{
    public class BodyModel
    {
        public class ScreenSize
        {
            public bool Is
            { get; set; }
            public int Height { get; set; }
            public int Width { get; set; }
        }

        public class SystemSettings
        {
            public ScreenSize ScreenSize { get; set; }
        }
    }
}
