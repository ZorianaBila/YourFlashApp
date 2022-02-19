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
    class DataStoreItems: IDataStore<Item>
    {
        readonly List<Item> items= new List<Item>();
        private string path = @"D:\Унівєр\Курсова\YourFlashApp\itemsData";
       
        
        public DataStoreItems()
        {
            var text = File.ReadAllLines(path);
            foreach(string line in text)
            {
               var  item = JsonConvert.DeserializeObject<Item>(line);
                items.Add(item);
            }

        }

        public  async Task<bool> AddItemAsync(Item item)
        {
            var itemWrote = JsonConvert.SerializeObject(item) + "\n";
            File.AppendAllText(path, itemWrote);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item newItem)
        {
            var oldItem = items.Where((Item arg) => arg.Id == newItem.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(newItem);

            File.WriteAllText(path, "");
            foreach(Item item in items)
            {
                var itemWrote = JsonConvert.SerializeObject(item) + "\n";
                File.AppendAllText(path, itemWrote);
            }


            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            File.WriteAllText(path, "");
            foreach (Item item in items)
            {
                var itemWrote = JsonConvert.SerializeObject(item) + "\n";
                File.AppendAllText(path, itemWrote);
            }

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<List<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}

