using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSettingsModel;
using VisualNovelGame.Events.EventArgs;

namespace VisualNovelGame.Services.Interfaces
{
    public interface ISystemSettingsService
    {
        //// 获取设置中的窗口长度和宽度
        //WindowSizeArgs GetWindowSizeFromSystemSettings();

        //// 将窗口的长度和宽度到设置中，返回bool判定是否保存成功
        //bool SetWindowSizeToSystemSettings(WindowSizeArgs windowSizeArgs);

        // 读取JSON文件内容并反序列化
        RootEntity GetSystemSettings();

        // 保存JSON文件内容
        void SaveSystemSettings();

        // 获取屏幕是否设置最大化
        bool GetWindowType();

        // 获取画面比例设置项
        bool GetAspectRatio();

        // 保存画面比例设置项
        void SaveAspectRatio(bool flag);
    }
}
