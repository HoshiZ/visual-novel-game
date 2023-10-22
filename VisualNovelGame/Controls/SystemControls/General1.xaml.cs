﻿using Prism.Events;
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
using VisualNovelGame.ViewModels.SystemControlViewModel;

namespace VisualNovelGame.Controls.SystemControls
{
    /// <summary>
    /// General1.xaml 的交互逻辑
    /// </summary>
    public partial class General1 : UserControl
    {
        private readonly IEventAggregator _eventAggregator;

        public General1(General1ViewModel general1ViewModel)
        {
            InitializeComponent();
            DataContext = general1ViewModel;
        }
    }
}