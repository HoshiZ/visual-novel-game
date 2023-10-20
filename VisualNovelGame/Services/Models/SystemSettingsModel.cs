using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SystemSettingsModel
{
    public class RootEntity
    {
        [JsonProperty("SystemSetting")]
        public SystemSettingEntity SystemSetting { get; set; }

    }

    public class SystemSettingEntity
    {
        [JsonProperty("Display")]
        public DisplayEntity Display { get; set; }
        [JsonProperty("General1")]
        public General1Entity General1 { get; set; }
        [JsonProperty("General2")]
        public General2Entity General2 { get; set; }
        [JsonProperty("Text")]
        public TextEntity Text { get; set; }
        [JsonProperty("Sound")]
        public SoundEntity Sound { get; set; }
        [JsonProperty("Dialog")]
        public DialogEntity Dialog { get; set; }
        [JsonProperty("Mouse")]
        public MouseEntity Mouse { get; set; }
        [JsonProperty("Keyboard")]
        public KeyboardEntity Keyboard { get; set; }
        [JsonProperty("GamePad")]
        public GamePadEntity GamePad { get; set; }

    }

    public class DisplayEntity
    {
        [JsonProperty("WindowType")]
        public bool WindowType { get; set; }
        [JsonProperty("AspectRatio")]
        public bool AspectRatio { get; set; }
        [JsonProperty("VisualEffects")]
        public bool VisualEffects { get; set; }
        [JsonProperty("Animation")]
        public bool Animation { get; set; }
        [JsonProperty("ESCKeyFunction")]
        public bool ESCKeyFunction { get; set; }
        [JsonProperty("PanicButton")]
        public PanicButtonEntity PanicButton { get; set; }
        [JsonProperty("AlwaysOnTop")]
        public bool AlwaysOnTop { get; set; }
        [JsonProperty("UIDisplay")]
        public UIDisplayEntity UIDisplay { get; set; }
        [JsonProperty("ChapterDisplay")]
        public ChapterDisplayEntity ChapterDisplay { get; set; }
        [JsonProperty("MusicTitleDisplay")]
        public MusicTitleDisplayEntity MusicTitleDisplay { get; set; }
        [JsonProperty("CharacterPortraits")]
        public bool CharacterPortraits { get; set; }
        [JsonProperty("ShowPop_upWindow")]
        public ShowPopUpWindowEntity ShowPopUpWindow { get; set; }

    }

    public class PanicButtonEntity
    {
        [JsonProperty("Minimize")]
        public bool Minimize { get; set; }
        [JsonProperty("Image1")]
        public bool Image1 { get; set; }
        [JsonProperty("Image2")]
        public bool Image2 { get; set; }
        [JsonProperty("CustomImage")]
        public bool CustomImage { get; set; }

    }

    public class UIDisplayEntity
    {
        [JsonProperty("ProgressIcon")]
        public bool ProgressIcon { get; set; }
        [JsonProperty("ProgressMeter")]
        public bool ProgressMeter { get; set; }
        [JsonProperty("WindowMenu")]
        public bool WindowMenu { get; set; }
        [JsonProperty("TouchUI")]
        public bool TouchUI { get; set; }

    }

    public class ChapterDisplayEntity
    {
        [JsonProperty("Off")]
        public bool Off { get; set; }
        [JsonProperty("Value")]
        public long Value { get; set; }
        [JsonProperty("On")]
        public bool On { get; set; }

    }

    public class MusicTitleDisplayEntity
    {
        [JsonProperty("Off")]
        public bool Off { get; set; }
        [JsonProperty("Value")]
        public long Value { get; set; }
        [JsonProperty("On")]
        public bool On { get; set; }

    }

    public class ShowPopUpWindowEntity
    {
        [JsonProperty("Mouse_over")]
        public bool MouseOver { get; set; }
        [JsonProperty("RightClick")]
        public bool RightClick { get; set; }

    }

    public class General1Entity
    {
        [JsonProperty("AutoSkipOrjumpOverReadText")]
        public bool AutoSkipOrjumpOverReadText { get; set; }
        [JsonProperty("AutoSkipOrjumpSetting")]
        public AutoSkipOrjumpSettingEntity AutoSkipOrjumpSetting { get; set; }
        [JsonProperty("AutoCursor")]
        public bool AutoCursor { get; set; }
        [JsonProperty("AutoCursorDefaultOption")]
        public bool AutoCursorDefaultOption { get; set; }
        [JsonProperty("HideMouseCursor")]
        public HideMouseCursorEntity HideMouseCursor { get; set; }
        [JsonProperty("SaveOrloadConfirmation")]
        public SaveOrloadConfirmationEntity SaveOrloadConfirmation { get; set; }
        [JsonProperty("ShowUnreadScenesInFlowchart")]
        public bool ShowUnreadScenesInFlowchart { get; set; }
        [JsonProperty("WhenWindowInInactive")]
        public bool WhenWindowInInactive { get; set; }
        [JsonProperty("TaskbarPreview")]
        public bool TaskbarPreview { get; set; }
        [JsonProperty("Suspend")]
        public bool Suspend { get; set; }

    }

    public class AutoSkipOrjumpSettingEntity
    {
        [JsonProperty("Skip")]
        public bool Skip { get; set; }
        [JsonProperty("Junp")]
        public bool Junp { get; set; }

    }

    public class HideMouseCursorEntity
    {
        [JsonProperty("Never")]
        public bool Never { get; set; }
        [JsonProperty("FiveSeconds")]
        public bool FiveSeconds { get; set; }
        [JsonProperty("TenSeconds")]
        public bool TenSeconds { get; set; }
        [JsonProperty("TwentySeconds")]
        public bool TwentySeconds { get; set; }

    }

    public class SaveOrloadConfirmationEntity
    {
        [JsonProperty("DoubleClick")]
        public bool DoubleClick { get; set; }
        [JsonProperty("SingleClick")]
        public bool SingleClick { get; set; }

    }

    public class General2Entity
    {
        [JsonProperty("GameSpeed")]
        public GameSpeedEntity GameSpeed { get; set; }
        [JsonProperty("VoicePlaybackSpeed")]
        public VoicePlaybackSpeedEntity VoicePlaybackSpeed { get; set; }
        [JsonProperty("SkipSpeed")]
        public SkipSpeedEntity SkipSpeed { get; set; }
        [JsonProperty("SkipStyle")]
        public SkipStyleEntity SkipStyle { get; set; }
        [JsonProperty("RightClickSkipsMovies")]
        public bool RightClickSkipsMovies { get; set; }
        [JsonProperty("SkipMoviesDuringSkipMode")]
        public bool SkipMoviesDuringSkipMode { get; set; }
        [JsonProperty("DramaticMode")]
        public DramaticModeEntity DramaticMode { get; set; }
        [JsonProperty("ScreenshotSettings")]
        public ScreenshotSettingsEntity ScreenshotSettings { get; set; }

    }

    public class GameSpeedEntity
    {
        [JsonProperty("Value")]
        public long Value { get; set; }
        [JsonProperty("Max")]
        public bool Max { get; set; }

    }

    public class VoicePlaybackSpeedEntity
    {
        [JsonProperty("Value")]
        public long Value { get; set; }

    }

    public class SkipSpeedEntity
    {
        [JsonProperty("Value")]
        public long Value { get; set; }
        [JsonProperty("Max")]
        public bool Max { get; set; }

    }

    public class SkipStyleEntity
    {
        [JsonProperty("Normal")]
        public bool Normal { get; set; }
        [JsonProperty("Fast")]
        public bool Fast { get; set; }
        [JsonProperty("Text")]
        public bool Text { get; set; }

    }

    public class DramaticModeEntity
    {
        [JsonProperty("VoicedLines")]
        public VoicedLinesEntity VoicedLines { get; set; }
        [JsonProperty("ProtagonistsLines")]
        public ProtagonistsLinesEntity ProtagonistsLines { get; set; }
        [JsonProperty("OtherLines")]
        public OtherLinesEntity OtherLines { get; set; }

    }

    public class VoicedLinesEntity
    {
        [JsonProperty("AlwaysShow")]
        public bool AlwaysShow { get; set; }
        [JsonProperty("HideInAuto_mode")]
        public bool HideInAutoMode { get; set; }
        [JsonProperty("AlwaysHide")]
        public bool AlwaysHide { get; set; }

    }

    public class ProtagonistsLinesEntity
    {
        [JsonProperty("AlwaysShow")]
        public bool AlwaysShow { get; set; }
        [JsonProperty("HideInAuto_mode")]
        public bool HideInAutoMode { get; set; }
        [JsonProperty("AlwaysHide")]
        public bool AlwaysHide { get; set; }

    }

    public class OtherLinesEntity
    {
        [JsonProperty("AlwaysShow")]
        public bool AlwaysShow { get; set; }
        [JsonProperty("HideInAuto_mode")]
        public bool HideInAutoMode { get; set; }
        [JsonProperty("AlwaysHide")]
        public bool AlwaysHide { get; set; }

    }

    public class ScreenshotSettingsEntity
    {
        [JsonProperty("DateOrtime")]
        public bool DateOrtime { get; set; }
        [JsonProperty("InputFilename")]
        public bool InputFilename { get; set; }

    }

    public class TextEntity
    {
        [JsonProperty("TextSpeed")]
        public long TextSpeed { get; set; }
        [JsonProperty("AutoModeSpeed")]
        public long AutoModeSpeed { get; set; }
        [JsonProperty("TimePerCharacter")]
        public long TimePerCharacter { get; set; }
        [JsonProperty("AutoModeType")]
        public AutoModeTypeEntity AutoModeType { get; set; }
        [JsonProperty("SkipUnreadText")]
        public bool SkipUnreadText { get; set; }
        [JsonProperty("SkipModeAfterChoice")]
        public bool SkipModeAfterChoice { get; set; }
        [JsonProperty("CtrlSkip")]
        public bool CtrlSkip { get; set; }
        [JsonProperty("AutoModeAfterChoice")]
        public bool AutoModeAfterChoice { get; set; }
        [JsonProperty("TextSettingsWithColor")]
        public TextSettingsWithColorEntity TextSettingsWithColor { get; set; }

    }

    public class AutoModeTypeEntity
    {
        [JsonProperty("Normal")]
        public bool Normal { get; set; }
        [JsonProperty("Voice")]
        public bool Voice { get; set; }
        [JsonProperty("Speed")]
        public bool Speed { get; set; }

    }

    public class TextSettingsWithColorEntity
    {
        [JsonProperty("TextBox")]
        public TextBoxEntity TextBox { get; set; }
        [JsonProperty("OtherPOV")]
        public OtherPOVEntity OtherPOV { get; set; }
        [JsonProperty("UnreadText")]
        public UnreadTextEntity UnreadText { get; set; }
        [JsonProperty("ReadText")]
        public ReadTextEntity ReadText { get; set; }
        [JsonProperty("TextBoxOpacity")]
        public long TextBoxOpacity { get; set; }

    }

    public class TextBoxEntity
    {
        [JsonProperty("Color")]
        public long Color { get; set; }

    }

    public class OtherPOVEntity
    {
        [JsonProperty("Color")]
        public long Color { get; set; }

    }

    public class UnreadTextEntity
    {
        [JsonProperty("Color")]
        public long Color { get; set; }

    }

    public class ReadTextEntity
    {
        [JsonProperty("Color")]
        public long Color { get; set; }

    }

    public class SoundEntity
    {
        [JsonProperty("MasterVolumn")]
        public long MasterVolumn { get; set; }
        [JsonProperty("BGM")]
        public long BGM { get; set; }
        [JsonProperty("BGMDuringVoicPlayback")]
        public long BGMDuringVoicPlayback { get; set; }
        [JsonProperty("SFX")]
        public long SFX { get; set; }
        [JsonProperty("Movie")]
        public long Movie { get; set; }
        [JsonProperty("SystemSFX")]
        public long SystemSFX { get; set; }
        [JsonProperty("SystemVoice")]
        public long SystemVoice { get; set; }
        [JsonProperty("System")]
        public SystemEntity System { get; set; }
        [JsonProperty("Voice")]
        public long Voice { get; set; }
        [JsonProperty("CharacterVolumes")]
        public CharacterVolumesEntity CharacterVolumes { get; set; }
        [JsonProperty("CutVoicePlayBackOnTextAdvance")]
        public bool CutVoicePlayBackOnTextAdvance { get; set; }

    }

    public class SystemEntity
    {
        [JsonProperty("SoundEffect")]
        public bool SoundEffect { get; set; }
        [JsonProperty("Character")]
        public bool Character { get; set; }
        [JsonProperty("Individual")]
        public IndividualEntity Individual { get; set; }

    }

    public class IndividualEntity
    {
        [JsonProperty("SystemVoiceSettings")]
        public SystemVoiceSettingsEntity SystemVoiceSettings { get; set; }
        [JsonProperty("CharacterVoice")]
        public CharacterVoiceEntity CharacterVoice { get; set; }

    }

    public class SystemVoiceSettingsEntity
    {
        [JsonProperty("Disclaimer")]
        public bool Disclaimer { get; set; }
        [JsonProperty("TitleScreen")]
        public bool TitleScreen { get; set; }
        [JsonProperty("Save")]
        public bool Save { get; set; }
        [JsonProperty("FavoritedVoices")]
        public bool FavoritedVoices { get; set; }
        [JsonProperty("Backlog")]
        public bool Backlog { get; set; }
        [JsonProperty("Settings")]
        public bool Settings { get; set; }
        [JsonProperty("Extra")]
        public bool Extra { get; set; }
        [JsonProperty("Dialog")]
        public bool Dialog { get; set; }
        [JsonProperty("Logos")]
        public bool Logos { get; set; }
        [JsonProperty("Bindings")]
        public bool Bindings { get; set; }
        [JsonProperty("Load")]
        public bool Load { get; set; }
        [JsonProperty("AddFavorite")]
        public bool AddFavorite { get; set; }
        [JsonProperty("FlowChart")]
        public bool FlowChart { get; set; }
        [JsonProperty("SettingsTabs")]
        public bool SettingsTabs { get; set; }
        [JsonProperty("Quit")]
        public bool Quit { get; set; }

    }

    public class CharacterVoiceEntity
    {

    }

    public class CharacterVolumesEntity
    {
        [JsonProperty("Rino")]
        public long Rino { get; set; }
        [JsonProperty("Tsubasa")]
        public long Tsubasa { get; set; }

    }

    public class DialogEntity
    {
        [JsonProperty("Saving")]
        public bool Saving { get; set; }
        [JsonProperty("Overwriting")]
        public bool Overwriting { get; set; }
        [JsonProperty("DirectSave")]
        public bool DirectSave { get; set; }
        [JsonProperty("Loading")]
        public bool Loading { get; set; }
        [JsonProperty("Quicksaving")]
        public bool Quicksaving { get; set; }
        [JsonProperty("QuiclLoading")]
        public bool QuiclLoading { get; set; }
        [JsonProperty("ReturningToTitle")]
        public bool ReturningToTitle { get; set; }
        [JsonProperty("JumpingFromBacklog")]
        public bool JumpingFromBacklog { get; set; }
        [JsonProperty("JumpingFromFlowchart")]
        public bool JumpingFromFlowchart { get; set; }
        [JsonProperty("JumpingToTheNextChoice")]
        public bool JumpingToTheNextChoice { get; set; }
        [JsonProperty("JumpingToThePreviousChoice")]
        public bool JumpingToThePreviousChoice { get; set; }
        [JsonProperty("JumpingToTheNextScene")]
        public bool JumpingToTheNextScene { get; set; }
        [JsonProperty("JumpingToThePreviousScene")]
        public bool JumpingToThePreviousScene { get; set; }
        [JsonProperty("FavoritingAVoiceLine")]
        public bool FavoritingAVoiceLine { get; set; }
        [JsonProperty("ResettingToDefaultSettings")]
        public bool ResettingToDefaultSettings { get; set; }
        [JsonProperty("ResettingInSpriteMode")]
        public bool ResettingInSpriteMode { get; set; }
        [JsonProperty("DeletingASave")]
        public bool DeletingASave { get; set; }
        [JsonProperty("MovingASave")]
        public bool MovingASave { get; set; }
        [JsonProperty("CopyingASave")]
        public bool CopyingASave { get; set; }
        [JsonProperty("ClosingTheGame")]
        public bool ClosingTheGame { get; set; }
        [JsonProperty("SuspendingTheGame")]
        public bool SuspendingTheGame { get; set; }

    }

    public class MouseEntity
    {
        [JsonProperty("MouseGestures")]
        public MouseGesturesEntity MouseGestures { get; set; }

    }

    public class MouseGesturesEntity
    {

    }

    public class KeyboardEntity
    {
        [JsonProperty("Save")]
        public SaveEntity Save { get; set; }
        [JsonProperty("Load")]
        public LoadEntity Load { get; set; }

    }

    public class SaveEntity
    {
        [JsonProperty("ShortCutKey1")]
        public ShortCutKey1Entity ShortCutKey1 { get; set; }
        [JsonProperty("ShortCutKey2")]
        public ShortCutKey2Entity ShortCutKey2 { get; set; }

    }

    public class ShortCutKey1Entity
    {
        [JsonProperty("Modifier")]
        public List<string> Modifier { get; set; }
        [JsonProperty("Key")]
        public string Key { get; set; }

    }

    public class ShortCutKey2Entity
    {
        [JsonProperty("Modifier")]
        public Object Modifier { get; set; }
        [JsonProperty("Key")]
        public string Key { get; set; }

    }

    public class LoadEntity
    {

    }

    public class GamePadEntity
    {

    }

}