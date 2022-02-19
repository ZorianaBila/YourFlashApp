using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourFlashApp.Models;

namespace YourFlashApp.Services
{
    class DataStoreCategories: IDataStore<Category>
    {
        readonly List<Category> items= new List<Category>();
        private string path = @"D:\Унівєр\Курсова\YourFlashApp\categoriesData";
       
        
        public DataStoreCategories()
        {
            var text = File.ReadAllLines(path);
           
            foreach (string line in text)
            {
                var item = JsonConvert.DeserializeObject<Category>(line);
                items.Add(item);
            }

           

        }

        public  async Task<bool> AddItemAsync(Category item)
        {
            var itemWrote = JsonConvert.SerializeObject(item) + "\n";
            File.AppendAllText(path, itemWrote);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Category item)
        {
            var oldItem = items.Where((Category arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Category arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Category> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<List<Category>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}

