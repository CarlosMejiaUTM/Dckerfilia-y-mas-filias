using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace ContosoUniversity.Infrastructure.Data
{
    public class DBLocalContosoUniversity
    {
        private const string fileName = "DBLocalContosoUniversity.json";
        private const string dataPath = "Infrastructure\\Data";
        private List<Person> _persons;

        private void LoadData()
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, dataPath, fileName);
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                _persons = JsonSerializer.Deserialize<List<Person>>(jsonString)!;

            }
        }

        public IEnumerable<Person> Persons => _persons;
        public DBLocalContosoUniversity()
        {
            _persons = new List<Person>();
            LoadData();
        }







    }


}