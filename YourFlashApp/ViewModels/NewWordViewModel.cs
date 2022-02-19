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
    class NewWordViewModel : BaseViewModel
    {
        DataStoreItems dataStoreItems = new DataStoreItems();
        DataStoreCategories dataStoreCategories = new DataStoreCategories();
        private string ukr;
        private string eng;
        private string example;
        private string category;

        public NewWordViewModel()
        {

        }
        public string UkrWord
        {
            get => ukr;
            set => SetProperty(ref ukr, value);
        }

        public string EngWord
        {
            get => eng;
            set => SetProperty(ref eng, value);
        }
        public string ExampleSentence
        {
            get => example;
            set => SetProperty(ref example, value);
        }
        public string Category
        {
            get => category;
            set => SetProperty(ref category, value);
        }


        
        public bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(ukr)
                && !String.IsNullOrWhiteSpace(eng)
                && !String.IsNullOrWhiteSpace(example)
                && !String.IsNullOrWhiteSpace(category)
                && ukr.All(c => char.IsLetter(c))
                && eng.All(c => char.IsLetter(c));
        }
        public async void OnSave()
        {
            if (ValidateSave())
            {
                Item newItem = new Item()
                {
                    Id = Guid.NewGuid().ToString(),
                    UkrWord = UkrWord,
                    EngWord = EngWord,
                    ExampleSentence = ExampleSentence,
                    Category = Category
                };
                await dataStoreItems.AddItemAsync(newItem);
            }            

        }

        public async void onChooseCategories(List<string> categoriesName)
        {
            var categories = await dataStoreCategories.GetItemsAsync();
            foreach (Category category in categories)
            {
                categoriesName.Add(category.Name);

            }

        }

    }
}
