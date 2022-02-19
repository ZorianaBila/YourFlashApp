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
    class StudyViewModel : BaseViewModel
    {
        DataStoreItems dataStoreItems = new DataStoreItems();
        List<Item> items;
        int seenItems = 0;
        int rememberedItems = 0;
        public Item item;
        private int isRemembered;
        private bool isLearned;


        public StudyViewModel()
        {
            LoadItems();
            RefreshCard(true);
        }
        public int IsRemembered
        {
            get => isRemembered;
            set => SetProperty(ref isRemembered, value);
        }
        public bool IsLerned
        {
            get => isLearned;
            set => SetProperty(ref isLearned, value);
        }



        public async void OnRemember()
        {
            Item newItem = new Item()
            {
                Id = item.Id,
                UkrWord = item.UkrWord,
                EngWord = item.EngWord,
                ExampleSentence = item.ExampleSentence,
                Category = item.Category,
                IsRemembered = item.IsRemembered + 1,
                IsLerned = (item.IsRemembered >= 6),
                Date = DateTime.Now

            };
            await dataStoreItems.UpdateItemAsync(newItem);

        }

        private async void LoadItems()
        {
            items = await dataStoreItems.GetItemsAsync();

        }

        public bool RefreshCard(bool remember)
        {
            if (seenItems < items.Count && remember)
            {

                seenItems += 1;
                rememberedItems += 1;
                item = items[seenItems - rememberedItems];
                return true;
            }
            else if (seenItems < items.Count && !remember)
            {
                seenItems += 1;
                item = items[seenItems - rememberedItems];
                return true;
            }
            else return false;
        }
       
    }
}
