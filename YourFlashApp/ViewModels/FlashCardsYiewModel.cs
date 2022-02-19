using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using YourFlash.ViewModels;
using YourFlashApp.Models;
using YourFlashApp.Services;

namespace YourFlashApp.ViewModels
{
    class FlashCardsViewModel : BaseViewModel
    {
        DataStoreItems dataStoreItems = new DataStoreItems();
        DataStoreCategories dataStoreCategories = new DataStoreCategories();
        public List<Item> filtered = new List<Item>();
        public List<Category> categories = new List<Category>();
       
        public FlashCardsViewModel()
        {
            
        }
   
        public async void LoadsItems(List<Item> items)
        {
            var data = await dataStoreItems.GetItemsAsync();
            foreach (Item item in data)
            {
                items.Add(item);

            }
        }
        public async void onChooseCategories(List<string> categoriesName)
        {
            categories = await dataStoreCategories.GetItemsAsync();
            foreach (Category category in categories)
            {
                categoriesName.Add(category.Name);

            }

        }

        public Category FindCategory(Item item)
        {
            Category result = categories[0];
            foreach(Category category in categories)
            {
                if(category.Name == item.Category)
                {
                    result = category;
                    break;
                }
            }
            return result;
        }

        public void FilterItems(List<Item> items, string category, bool ismemorized)
        {
            if (category != "All categories")
            {
                filtered = items.FindAll(item => item.Category == category && item.IsLerned == ismemorized);
            }
            else filtered = items.FindAll(item => item.IsLerned == ismemorized);
        }

    }
}
