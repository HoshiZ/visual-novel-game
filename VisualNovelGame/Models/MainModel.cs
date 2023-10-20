using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGame.Models
{
    public class MainModel
    {

    }

    public class ScreenSize
    {
        private bool _isFullScreen;
        public bool IsFullScreen { get => _isFullScreen; set => _isFullScreen = value; }

        private int _width;
        public int Width { get => _width; set => _width = value; }
        
        private int _height;
        public int Height { get => _height; set => _height = value; }
    }
}
