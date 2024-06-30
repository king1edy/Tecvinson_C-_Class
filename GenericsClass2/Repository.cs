using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GenericsClass2
{
    public class Repository<T> where T : class
    {
        public Repository()
        { }

        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }

        public List<T> GetItems()
        { return items; }

        public List<T> UpdateAtIndex(T model, int index)
        {
            items[index] = model;
            return items;
        }

        public void Delete(int index)
        {
            items.RemoveAt(index);
        }

        public Task<string> SerializeClass(T model)
        {
            return Task.FromResult(JsonSerializer.Serialize(model));
        }

        public string SerializeList(List<T> list)
        {
            return JsonSerializer.Serialize(list);
        }
    }
}