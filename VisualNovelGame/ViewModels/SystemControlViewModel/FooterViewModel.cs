using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using VisualNovelGame.Events;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel(IUIStringsService uIStringsService, IEventAggregator eventAggregator)
        {
            _UIStringsService = uIStringsService;
            eventAggregator.GetEvent<LanguageChangedEvent>().Subscribe(UpdateStrings);
        }

        private readonly IUIStringsService _UIStringsService;

        public string Defaults => _UIStringsService.Defaults;
        public string TitleScreen => _UIStringsService.TitleScreen;
        public string Return => _UIStringsService.Return;

        public void UpdateStrings()
        {

        }
    }
}
