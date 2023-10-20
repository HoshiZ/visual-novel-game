using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualNovelGame.Controls.SystemControls.Template
{
    /// <summary>
    /// Footer.xaml 的交互逻辑
    /// </summary>
    public partial class Footer : UserControl, IRegionMemberLifetime
    {
        public bool KeepAlive => true;

        private readonly IRegionManager _regionManager;

        // 构造函数
        public Footer(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
        }
    }
}
