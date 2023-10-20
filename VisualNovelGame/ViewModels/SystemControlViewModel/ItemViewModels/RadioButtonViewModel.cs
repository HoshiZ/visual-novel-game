using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels
{
    public class ItemForRadioButtonViewModel
    {
        public string ItemTitle { get; set; }
        public ObservableCollection<RadioButtonViewModel> RadioButtons { get; set; } = new ObservableCollection<RadioButtonViewModel>();
    }

    public class RadioButtonViewModel : BindableBase
    {
        public RadioButtonViewModel()
        {

        }

        private string _content;
        private DelegateCommand<object> _delegateCommand;
        private string _commandParameter;
        private bool _isChecked;
        private string _groupName;

        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public DelegateCommand<object> DelegateCommand
        {
            get => _delegateCommand;
            set => SetProperty(ref _delegateCommand, value);
        }

        public string CommandParameter
        {
            get => _commandParameter;
            set => SetProperty(ref _commandParameter, value);
        }

        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }

        public string GroupName
        {
            get => _groupName;
            set => SetProperty(ref _groupName, value);
        }
    }
}
