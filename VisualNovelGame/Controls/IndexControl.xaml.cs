using Prism.Commands;
using Prism.Events;
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
using Unity;
using VisualNovelGame.ViewModels;
using static VisualNovelGame.Services.EventAggregatorService;

namespace VisualNovelGame.Controls
{
    /// <summary>
    /// Home_IndexControl.xaml 的交互逻辑
    /// </summary>
    public partial class IndexControl : UserControl
    {
        public readonly IEventAggregator _eventAggregator;

        public IndexControl(IEventAggregator eventAggregator, IndexControlViewModel indexControlViewModel)
        {
            InitializeComponent();
            DataContext = indexControlViewModel;
            //_eventAggregator = eventAggregator;
        }

        //private void TogoSystem(string Page)
        //{
        //    _eventAggregator.GetEvent<IndexTogoEvent>().Publish("System");
        //}

        //private void TogoGame(string Page)
        //{
        //    _eventAggregator.GetEvent<>
        //}

    }
}
