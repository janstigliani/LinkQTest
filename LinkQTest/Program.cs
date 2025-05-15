using System.Linq;

namespace LinkQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temperatures = new List<double> { 30.2, 32, 35, 28.4, 29.1, 33.7, 32.4, 25.6, 34.3, 29.9 };
            var cities = new List<string> { "Tokyo", "Osaka", "Kyoto", "Hokkaido", "Okinawa", "Oshino", "Nagato", "Hiroshima", "Nagasaki", "Kyushu" };
            var students = new List<Student>
            {
                new Student("Taro", 20, true),
                new Student("Hanako", 22, false),
                new Student("Jiro", 19, true),
                new Student("Sakura", 21, false),
                new Student("Saburo", 23, true),
                new Student("Yuki", 18, false),
                new Student("Kenta", 24, true),
                new Student("Kenta", 20, false),
                new Student("Kenta", 22, true),
            };

            var cityTemprerature = new Dictionary<string, double>()
            {
                {"Tokyo", 30.2},
                {"Osaka", 32},
                {"Kyoto", 35},
                {"Hokkaido", 28.4},
                {"Okinawa", 29.1},
                {"Oshino", 33.7},
                {"Nagato", 32.4},
                {"Hiroshima", 25.6},
                {"Nagasaki", 34.3},
                {"Kyushu", 29.9}
            };

            var nicknameStudents = new Dictionary<string, Student>()
            {
                { "Takkun", new Student("Taro", 20, true) },
                { "Hana-San", new Student("Hanako", 22, false) },
                { "Jii-Sama", new Student("Jiro", 19, true) },
                { "Sacchan", new Student("Sakura", 21, false) },
                { "Sab", new Student("Saburo", 23, true) },
                { "Yu", new Student("Yuki", 18, false) },
                { "Ken", new Student("Kenta", 24, true) },
                { "Ta-Senpai", new Student("Kenta", 20, false) },
                { "KenKen", new Student("Kenta", 22, true)}
            };

            var temperatureAbove30 = (from temp in temperatures
                                   where temp > 30
                                   select temp).ToList();

            var temperatureAbove30Sql = temperatures.Where(temp => temp > 30).ToList();

            var orderedTemperatureAbove30 = temperatures.Where(t => t > 30).OrderBy(t => -t).ToList();

            //var orderedTemperatureAbove30Sql = (from temp in temperatures
            //                                    where temp > 30
            //                                    select temp).OrderDescending().ToList();

            var orderedTemperatureAbove30Sql = (from temp in temperatures
                                                where temp > 30
                                                orderby temp descending
                                                select temp).ToList();

            var citiesStartingWithO = cities.Where(c => c.StartsWith("O")).Take(2).ToList();

            var orderedStudents = students.OrderBy(s => s.Name).ThenBy(s => -s.Age).ToList();

            //for ( var i = 0; i < citiesStartingWithO.Count; i++ )
            //{
            //    Console.WriteLine( citiesStartingWithO[i] );
            //}

            //for (var i = 0; i < orderedTemperatureAbove30Sql.Count; i++)
            //{
            //    Console.WriteLine($"Temperature above 30: {orderedTemperatureAbove30Sql[i]}");
            //}

            //for (var i = 0; i < orderedStudents.Count; i++)
            //{
            //    Console.WriteLine($"Student: {orderedStudents[i].Name}, {orderedStudents[i].Age}");
            //}

            var cityNameTemperatureAbove30 = cityTemprerature.Where(kv => kv.Value > 30).Select(kv => kv.Key).ToList();

            //for (var i = 0; i < cityNameTemperatureAbove30.Count; i++)
            //{
            //    Console.WriteLine($"Student: {cityNameTemperatureAbove30[i]}");
            //}

            var nicknameList = nicknameStudents.Select(kv => kv.Key).ToList();

            //for (var i = 0; i < nicknameList.Count; i++)
            //{
            //    Console.WriteLine($"Student: {nicknameList[i]}");
            //}

            var tempCitiesStartingWithO = cityTemprerature.Where(kv => kv.Key.StartsWith("O")).Select(kv => kv.Value).ToList();
            double avgTemp = 0;

            for (var i = 0; i < tempCitiesStartingWithO.Count; i++)
            {
                Console.WriteLine($"Temp: {tempCitiesStartingWithO[i]}");
                avgTemp += tempCitiesStartingWithO[i];

            }

            Console.WriteLine(avgTemp/tempCitiesStartingWithO.Count);

            var cityNameHigherTemp = cityTemprerature.Where(kv => Math.Max(kv.Value)).Select(Kv => Kv.Key);

            var citytempdict = cities.
        }
    }
}

//// riscrivere tutto fatto in classe con aggregate (opzionale)
//// scrive query linkQ tutti nick student onii-san
//// media temperature città che iniziano con O
/// nome città temp maggiore
/// prendi list cities e temperature e crea dizionario uguale a cityTemp (list to dictionary)
/// prendi nick e fai dizionario nick ed age
/// 
