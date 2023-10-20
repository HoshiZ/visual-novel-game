using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGame.Events.EventArgs
{
    /// <summary>
    /// 窗口大小JSON模型,参数IsMaxSize, Width, Height或者IsMaxSize
    /// </summary>
    public class WindowSizeArgs
    {
        public bool IsFullWindow { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public WindowSizeArgs() 
        {
            IsFullWindow = false;
            Width = 0;
            Height = 0;
        }

        public WindowSizeArgs(bool isMaxSize) 
        {
            IsFullWindow = isMaxSize;
        }

        public WindowSizeArgs(bool isFullWindow, double width, double height) 
        {
            IsFullWindow = isFullWindow;
            Width = width;
            Height = height;
        }

    }

    public static class WindowSizeArgsFactory
    {
        public static WindowSizeArgs Create(bool isFullWindow, double? width = null, double? height = null)
        {
            if (width.HasValue &&  height.HasValue)
            {
                return new WindowSizeArgs(isFullWindow, width.Value, height.Value);
            }
            else
            {
                return new WindowSizeArgs(isFullWindow);
            }
        }
    }
}
