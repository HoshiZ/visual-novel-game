using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGameDB.Models;

namespace VisualNovelGameDB.Services.IServices
{
    public interface IVNCService
    {
        GameDataModel GetGameDataModel();
    }
}
