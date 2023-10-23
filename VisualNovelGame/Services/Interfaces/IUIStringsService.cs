using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using VisualNovelGame.Resources.Languages;

namespace VisualNovelGame.Services.Interfaces
{
    public interface IUIStringsService
	{
        void UpdateUI();
        void ChangeUIStrings();
        LanguageState CurrentLanguage { get; set; } 
        string NewGame { get; }
        string LanguageChange { get; }
        string Load { get; }
        string System { get; }
        string Quit { get; }
        string AlwaysOnTop { get; }
        string Animation { get; }
        string AutoModeAfterChoice { get; }
        string AutoModeAfterChoice_A { get; }
        string AutoModeAfterChoice_B { get; }
        string AutoModeSpeed { get; }
        string Basic {  get; }
        string BGM { get; }
        string BGMDuringVoicePlayback { get; }
        string Button_OFF { get; }
        string Button_ON { get; }
        string ChapterDisplay { get; }
        string CharacterVolumns { get; }
        string CharacterVolumns_Litangdingzhen {  get; }
        string CharacterVolumns_RinHoshizora { get; }
        string CharacterVolumns_Tsubasakido {  get; }
        string ClosingTheGame {  get; }
        string Color {  get; }
        string CtrlSkip { get; }
        string CtrlSkip_A { get; }
        string CtrlSkip_B { get; }
        string Defaults { get; }
        string Dialog {  get; }
        string Display {  get; }
        string ESCKeyFunction { get; }
        string ESCKeyFunction_A { get; }
        string ESCKeyFunction_B {  get; }
        string GameSpeed { get; }
        string General1 { get; }
        string General2 { get; }
        string HideMouseCursor { get; }
        string HideMouseCursor_A { get; }
        string HideMouseCursor_B { get; }
        string HideMouseCursor_C { get; }
        string HideMouseCursor_D { get; }
        string Language2 { get; }
        string MasterVolumn { get; }
        string PanicButton { get; }
        string PanicButton_A { get; }
        string PanicButton_B { get; }
        string PanicButton_C { get; }
        string PanicButton_D { get; }
        string ResettingToDefaultSettings { get; }
        string Return { get; }
        string ReturningToTitle { get; }
        string SkipModeAfterChoice { get; }
        string SkipModeAfterChoice_A { get; }   
        string SkipModeAfterChoice_B { get; }
        string SkipSpeed { get; }
        string SkipUnreadText { get; }
        string SkipUnreadText_A { get; }
        string SkipUnreadText_B { get; }
        string Sound {  get; }
        string SoundEffects { get; }
        string Text { get; }
        string TextBoxOpacity { get; }
        string TextSettings { get; }
        string TextSettings_A { get; }
        string TextSettings_B { get; }
        string TextSettings_C { get; }
        string TextSettings_D { get; }
        string TextSpeed { get; }
        string TitleScreen { get; }
        string UIDisplay { get; }
        string UIDisplay_A { get; }
        string UIDisplay_B { get; }
        string UIDisplay_C { get; }
        string UIDisplay_D { get; }
        string VisualEffects { get; }
        string Voice { get; }
        string WindowSize { get; }
        string WindowSize_A { get; }
        string WindowSize_B { get; }
        string WindowType { get; }
    }
}
