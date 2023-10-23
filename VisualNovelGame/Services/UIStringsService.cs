using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using VisualNovelGame.Events;
using VisualNovelGame.Resources.Languages;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.Services
{
	public class UIStringsService : BindableBase , IUIStringsService
	{
        private LanguageState languageSettingState = (LanguageState)Properties.Settings.Default.CurrentLanguage;
        private readonly IEventAggregator _eventAggregator;

        public UIStringsService(IEventAggregator eventAggregator) 
        {
            _eventAggregator = eventAggregator;
        }

        public void UpdateUI()
        {
            string code = languageSettingState.ToCode();
            Language.Strings.Culture = new CultureInfo(code);

            _eventAggregator.GetEvent<LanguageChangedEvent>().Publish();
        }

        public void ChangeUIStrings()
        {
            CurrentLanguage = (LanguageState)(((int)CurrentLanguage + 1) % Enum.GetNames(typeof(LanguageState)).Length);
        }

        public LanguageState CurrentLanguage
        {
            get { return languageSettingState; }
            set
            {
                if (languageSettingState != value)
                {
                    SetProperty(ref languageSettingState, value);
                    Properties.Settings.Default.CurrentLanguage = (int)CurrentLanguage;
                    Properties.Settings.Default.Save();
                    UpdateUI();
                }
            }
        }

        public string NewGame => Language.Strings.NewGame;
        public string LanguageChange => Language.Strings.Language;
        public string Load => Language.Strings.Load;
        public string System => Language.Strings.System;
        public string Quit => Language.Strings.Quit;
        public string AlwaysOnTop => Language.Strings.AlwaysOnTop;
        public string Animation => Language.Strings.Animation;
        public string AutoModeAfterChoice => Language.Strings.AutoModeAfterChoice;
        public string AutoModeAfterChoice_A => Language.Strings.AutoModeAfterChoice_A;
        public string AutoModeAfterChoice_B => Language.Strings.AutoModeAfterChoice_B;
        public string AutoModeSpeed => Language.Strings.AutoModeSpeed;
        public string Basic => Language.Strings.Basic;
        public string BGM => Language.Strings.BGM;
        public string BGMDuringVoicePlayback => Language.Strings.BGMDuringVoicePlayback;
        public string Button_OFF => Language.Strings.Button_OFF;
        public string Button_ON => Language.Strings.Button_ON;
        public string ChapterDisplay => Language.Strings.ChapterDisplay;
        public string CharacterVolumns => Language.Strings.CharacterVolumns;
        public string CharacterVolumns_Litangdingzhen => Language.Strings.CharacterVolumns_Litangdingzhen;
        public string CharacterVolumns_RinHoshizora => Language.Strings.CharacterVolumns_RinHoshizora;
        public string CharacterVolumns_Tsubasakido => Language.Strings.CharacterVolumns_Tsubasakido;
        public string ClosingTheGame => Language.Strings.ClosingTheGame;
        public string Color => Language.Strings.Color;
        public string CtrlSkip => Language.Strings.CtrlSkip;
        public string CtrlSkip_A => Language.Strings.CtrlSkip_A;
        public string CtrlSkip_B => Language.Strings.CtrlSkip_B;
        public string Defaults => Language.Strings.Defaults;
        public string Dialog => Language.Strings.Dialog;
        public string Display => Language.Strings.Display;
        public string ESCKeyFunction => Language.Strings.ESCKeyFunction;
        public string ESCKeyFunction_A => Language.Strings.ESCKeyFunction_A;
        public string ESCKeyFunction_B => Language.Strings.ESCKeyFuncion_B;
        public string GameSpeed => Language.Strings.GameSpeed;
        public string General1 => Language.Strings.General1;
        public string General2 => Language.Strings.General2;
        public string HideMouseCursor => Language.Strings.HideMouseCursor;
        public string HideMouseCursor_A => Language.Strings.HideMouseCursor_A;
        public string HideMouseCursor_B => Language.Strings.HideMouseCursor_B;
        public string HideMouseCursor_C => Language.Strings.HideMouseCursor_C;
        public string HideMouseCursor_D => Language.Strings.HideMouseCursor_D;
        public string Language2 => Language.Strings.Language;
        public string MasterVolumn => Language.Strings.MasterVolumn;
        public string PanicButton => Language.Strings.PanicButton;
        public string PanicButton_A => Language.Strings.PanicButton_A;
        public string PanicButton_B => Language.Strings.PanicButton_B;
        public string PanicButton_C => Language.Strings.PanicButton_C;
        public string PanicButton_D => Language.Strings.PanicButton_D;
        public string ResettingToDefaultSettings => Language.Strings.ResettingToDefaultSettings;
        public string Return => Language.Strings.Return;
        public string ReturningToTitle => Language.Strings.ReturningToTitle;
        public string SkipModeAfterChoice => Language.Strings.SkipModeAfterChoice;
        public string SkipModeAfterChoice_A => Language.Strings.SkipModeAfterChoice_A;
        public string SkipModeAfterChoice_B => Language.Strings.SkipModeAfterChoice_B;
        public string SkipSpeed => Language.Strings.SkipSpeed;
        public string SkipUnreadText => Language.Strings.SkipUnreadText;
        public string SkipUnreadText_A => Language.Strings.SkipUnreadText_A;
        public string SkipUnreadText_B => Language.Strings.SkipUnreadText_B;
        public string Sound => Language.Strings.Sound;
        public string SoundEffects => Language.Strings.SoundEffects;
        public string Text => Language.Strings.Text;
        public string TextBoxOpacity => Language.Strings.TextBoxOpacity;
        public string TextSettings => Language.Strings.TextSettings;
        public string TextSettings_A => Language.Strings.TextSettings_A;
        public string TextSettings_B => Language.Strings.TextSettings_B;
        public string TextSettings_C => Language.Strings.TextSettings_C;
        public string TextSettings_D => Language.Strings.TextSettings_D;
        public string TextSpeed => Language.Strings.TextSpeed;
        public string TitleScreen => Language.Strings.TitleScreen;
        public string UIDisplay => Language.Strings.UIDisplay;
        public string UIDisplay_A => Language.Strings.UIDisplay_A;
        public string UIDisplay_B => Language.Strings.UIDisplay_B;
        public string UIDisplay_C => Language.Strings.UIDisplay_C;
        public string UIDisplay_D => Language.Strings.UIDisplay_D;
        public string VisualEffects => Language.Strings.VisualEffects;
        public string Voice => Language.Strings.Voice;
        public string WindowSize => Language.Strings.WindowSize;
        public string WindowSize_A => Language.Strings.WindowSize_A;
        public string WindowSize_B => Language.Strings.WindowSize_B;
        public string WindowType => Language.Strings.WindowType;
    }
}
