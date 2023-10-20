using System.Windows.Controls;
using VisualNovelGame.ViewModels.SystemControlViewModel;

namespace VisualNovelGame.Controls.SystemControls
{
    /// <summary>
    /// Interaction logic for Basic
    /// </summary>
    public partial class Basic : UserControl
    {
        public Basic(BasicViewModel basicViewModel)
        {
            InitializeComponent();
            this.DataContext = basicViewModel;
        }
    }
}
