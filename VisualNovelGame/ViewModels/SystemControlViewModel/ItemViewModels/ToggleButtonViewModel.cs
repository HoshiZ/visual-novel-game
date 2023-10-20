using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels
{
    public class ItemForToggleButtonViewModel
    {
        public string ItemTitle { get; set; }
        public ObservableCollection<ToggleButtonViewModel> ToggleButtons { get; set; } = new ObservableCollection<ToggleButtonViewModel>();
    }

    public class ToggleButtonViewModel : BindableBase
    {
        public ToggleButtonViewModel()
        {

        }

        private string _content;
        private DelegateCommand<Tuple<bool, object>> _delegateCommand;
        private string _commandParameter;
        private bool? _isChecked; // 使用 bool? 使其可以有三种状态

        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public DelegateCommand<Tuple<bool, object>> DelegateCommand
        {
            get => _delegateCommand;
            set => SetProperty(ref _delegateCommand, value);
        }

        public string CommandParameter
        {
            get => _commandParameter;
            set => SetProperty(ref _commandParameter, value);
        }

        public bool? IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }
    }
}
