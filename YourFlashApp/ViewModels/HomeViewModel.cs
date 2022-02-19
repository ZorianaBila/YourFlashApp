using System;
using System.Collections.Generic;
using System.Windows.Input;
using YourFlashApp.Models;
using YourFlashApp.Services;

namespace YourFlash.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        DataStoreItems dataStoreItems = new DataStoreItems();
        List<Item> items;
        public HomeViewModel()
        {
            LoadWords();
        }

        private async void LoadWords()
        {
           items =  await dataStoreItems.GetItemsAsync();
        }
        public int CountAllWords()
        {
            return items.Count;

        }
        public int CountInProgress()
        {
            return items.FindAll(item => item.IsLerned == false).Count;

        }
        public int CountMemorized()
        {
            return items.FindAll(item => item.IsLerned == true).Count;

        }

    }
}