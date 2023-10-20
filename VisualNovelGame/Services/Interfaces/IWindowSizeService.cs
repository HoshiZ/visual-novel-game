using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Events.EventArgs;

namespace VisualNovelGame.Services.Interfaces
{
    public interface IWindowSizeService
    {
        // 根据传过来的参数，设置窗口的大小值
        void SetWindowSize(WindowSizeArgs args);

        // 设置窗口为最大值
        void SetWindowSizeMax();

        // 根据配置文件返回窗口的大小的参数
        WindowSizeArgs GetWindowSizeFromSystemSettings();

        // 保存窗口的大小值到配置文件
        bool SaveWindowSizeToSystemSettings(WindowSizeArgs args);
    }
}
