using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface ICategoryService
    {
        /// <summary>
        /// Lay category game tu may local
        /// </summary>
        /// <param name="gameItems"></param>
        /// <returns></returns>
        IList<CategoryGame> SyncCategoryGameCloudWithLocal(IList<GameItem> gameItems);
        IList<CategoryGame> SyncCategoryGameCloudWithLocal(IList<CategoryGame> categoryGames);
        /// <summary>
        /// Lay category tu local
        /// </summary>
        /// <returns></returns>
        IList<CategoryGame> GetCategoryGamesOnLocal();

        /// <summary>
        /// Them category in file database category local machine
        /// </summary>
        /// <param name="categoryGames"></param>
        /// <returns>true if success else return false</returns>
        bool SaveCategorysGame(IList<CategoryGame> categoryGames);
        /// <summary>
        /// Luu danh sach category nhung co kiem tra dong bo truoc khi luu
        /// </summary>
        /// <param name="categoryGames"></param>
        /// <returns></returns>
        bool SaveCategorysGameAndSync(IList<CategoryGame> categoryGames);
        /// <summary>
        /// Xoa Category
        /// </summary>
        /// <param name="categoryGame"></param>
        /// <returns></returns>
        bool DeleteCategory(CategoryGame categoryGame);
    }
}
