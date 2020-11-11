using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

using Models;

namespace Assignment.Data
{
    public class adultService : IAdultService
    {
        private string adultFile = "adult.json";
        private IList<Adult> _adults;

        public adultService()
        {
            string content = File.ReadAllText(adultFile);
            _adults = JsonSerializer.Deserialize<List<Adult>>(content);
        }

        private async Task WriteToFile() {
            string productsAsJson = JsonSerializer.Serialize(_adults);
            File.WriteAllText(adultFile, productsAsJson);
        }
        
        public async Task AddAdultAsync(Adult adult)
        {
            _adults.Add(adult);
            WriteToFile();
        }
        public async Task<IList<Adult>> GetAdultAsync()
        {
            return _adults;
        }
        
        private IList<T> ReadData<T>(string s) {
            using (var jsonReader = File.OpenText(s)) {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
    }
}