using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels
{
    public class ItemForSliderDisplayViewModel
    {
        public string ItemTitle { get; set; }
        public ObservableCollection<SliderDisplayViewModel> SliderDisplay { get; set; } = new ObservableCollection<SliderDisplayViewModel>();
    }

    public class SliderDisplayViewModel : BindableBase
    {
        public SliderDisplayViewModel()
        {

        }

        private int _currentValue;
        private int _maximum;
        private int _minimum;
        private int _interval;
        private DelegateCommand<object>? _sliderCommand;
        public int CurrentValue
        {
            get => _currentValue;
            set => SetProperty(ref _currentValue, value);
        }
        public int Maximum
        {
            get => _maximum;
            set => SetProperty(ref _maximum, value);
        }
        public int Minimum
        {
            get => _minimum;
            set => SetProperty(ref _minimum, value);
        }
        public int Interval
        {
            get => _interval;
            set => SetProperty(ref _interval, value);
        }

        public DelegateCommand<object>? SliderCommand
        {
            get { return _sliderCommand; }
            set => SetProperty(ref _sliderCommand, value);
        }
    }
}
