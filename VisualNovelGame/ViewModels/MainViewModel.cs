using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Models;

namespace VisualNovelGame.ViewModels
{
    public class MainViewModel
    {
        public ScreenSize ScreenSize { get; set; }

        public MainViewModel(ScreenSize screenSize) 
        {
            ScreenSize = screenSize;
        }
    }
}
