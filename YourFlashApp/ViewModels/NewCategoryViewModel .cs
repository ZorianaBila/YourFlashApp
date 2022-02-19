using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using YourFlash.ViewModels;
using YourFlashApp.Models;
using YourFlashApp.Services;

namespace YourFlashApp.ViewModels
{
    public class NewCategoryViewModel : BaseViewModel
    {
        DataStoreCategories dataStoreCategories = new DataStoreCategories();
        public string name;
        private Color color;
        public bool IsCategoryExist = false;
        

        public NewCategoryViewModel()
        {

        }
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public Color Color
        {
            get => color;
            set => SetProperty(ref color, value);
        }


        public bool ValidateSave()
        {
            CategoryExist();

            return !String.IsNullOrWhiteSpace(name)&&
                IsCategoryExist == false;
               
        }
        public async void OnSave()
        {
            if (ValidateSave())
            {
                Category newItem = new Category()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Name,
                    Color = Color,
                };
                await dataStoreCategories.AddItemAsync(newItem);
            }
           
        }

        private async void CategoryExist()
        {
            var categories = await dataStoreCategories.GetItemsAsync();
            int existCategory = categories.FindIndex(category => category.Name == Name);
            if (existCategory != -1)
            {
                IsCategoryExist = true;
            }
        }
    }
}
