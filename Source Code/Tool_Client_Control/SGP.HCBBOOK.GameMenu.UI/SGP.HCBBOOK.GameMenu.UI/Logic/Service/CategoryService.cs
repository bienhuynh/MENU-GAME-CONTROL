using Newtonsoft.Json;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class CategoryService : ICategoryService
    {
        private string pathGame = Directory.GetCurrentDirectory();
        public CategoryService()
        {

        }

        public IList<CategoryGame> SyncCategoryGameCloudWithLocal(IList<GameItem> gameItems)
        {
            //Doc category cua local
            IList<CategoryGame> categoryGamesLocal = GetCategoryGamesOnLocal();
            //Gom category cua cloud lai thanh mot cum
            foreach (var item in gameItems)
            {
                foreach (var cateInput in item.CategoryGames)
                {
                    int i = 0;
                    foreach (var cateOutput in categoryGamesLocal)
                    {
                        if (cateInput.CategoryName == cateOutput.CategoryName)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (i == categoryGamesLocal.Count())
                    {
                        cateInput.Id = ++i;
                        categoryGamesLocal.Add(cateInput);
                    }
                }
            }

            return categoryGamesLocal;
        }

        public IList<CategoryGame> SyncCategoryGameCloudWithLocal(IList<CategoryGame> categoryGames)
        {
            var categoryGamesLocal = GetCategoryGamesOnLocal();
            if(categoryGamesLocal == null)
            {
                categoryGamesLocal = new List<CategoryGame>();
            }
            foreach (var item in categoryGames)
            {
                bool flag = true;

                foreach (var cate in categoryGamesLocal)
                {
                    if (item.CategoryName == cate.CategoryName)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    categoryGamesLocal.Add(item);
                }
            }
            return categoryGamesLocal;
        }

        public IList<CategoryGame> GetCategoryGamesOnLocal()
        {
            IJsonService jsonService = new JsonService();
            string datacategoryLocal = jsonService.ReadFile(pathGame, DataFile.CategorysGame);
            IList<CategoryGame> categoryGamesLocal = JsonConvert.DeserializeObject<IList<CategoryGame>>(datacategoryLocal);
            return categoryGamesLocal;
        }

        public bool SaveCategorysGame(IList<CategoryGame> categoryGames)
        {
            try
            {
                IJsonService jsonService = new JsonService();
                string data = JsonConvert.SerializeObject(categoryGames);
                jsonService.SaveFile(pathGame, DataFile.CategorysGame, data);
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }

        public bool SaveCategorysGameAndSync(IList<CategoryGame> categoryGames)
        {
            try
            {
                var list = SyncCategoryGameCloudWithLocal(categoryGames);
                return SaveCategorysGame(list);
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public bool DeleteCategory(CategoryGame categoryGame)
        {
            try
            {
                var categorys = GetCategoryGamesOnLocal();
                if (categorys != null)
                {
                    var cate = categorys.FirstOrDefault(m => m.CategoryName == categoryGame.CategoryName);
                    if (cate != null)
                    {
                        categorys.Remove(cate);
                    }
                }
                SaveCategorysGame(categorys);
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    }
}
