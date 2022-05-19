using Linq_example.Domain;

namespace Linq_example.Method
{
    public class LinqTest
    {
        public void TestMethod(IEnumerable<Person> testData)
        {
            //var findByNameMethod = testData.Where(x => x.FirstName == "Adam" && (x.Age >= 21 && x.Age < 30));

            //var findByNameQuery = from list in testData
            //                      where list.FirstName == "Adam" && list.Age >= 21 && list.Age < 30
            //                      select list;

            //Console.WriteLine("Metod syntax:");
            //PrintResultOnTheScreen(findByNameMethod);
            //Console.WriteLine();
            //Console.WriteLine("Query syntax");
            //PrintResultOnTheScreen(findByNameQuery);



            //var findByAddressMethod = testData.Where(x => x.Address.City == "Kraków")
            //                            .Select(z => new { Name = z.FirstName, Age = z.Age, City = z.Address.City });

            //var findByAddressQuery = from s in testData
            //                         where s.Address.City == "Kraków"
            //                         select new { Name = s.FirstName, Age = s.Age, City = s.Address.City };

            //Console.WriteLine("Metod syntax:");
            //PrintResultOnTheScreen(findByAddressMethod);
            //Console.WriteLine();
            //Console.WriteLine("Query syntax");
            //PrintResultOnTheScreen(findByAddressQuery);



            //var amoutOfElementsMethod = testData.Where(x => x.Age > 20 && x.Age < 25)
            //                              .Count();

            //var amoutOfElementsQuery = (from s in testData
            //                            where s.Age > 20 && s.Age < 25
            //                            select s ).Count();


            //Console.WriteLine("Metod syntax:");
            //PrintResultOnTheScreen(amoutOfElementsMethod);
            //Console.WriteLine();
            //Console.WriteLine("Query syntax");
            //PrintResultOnTheScreen(amoutOfElementsMethod);


            ////Asc for method syntax we're sorting by one field but if we want to sort through other field we use method 'ThenBy'
            //var orderTestAscMethod = testData.OrderBy(x => x.FirstName)
            //                        .ThenBy(x => x.Age)
            //                        .Take(5);
            //var orderTestDesMethod = testData.OrderByDescending(x => x.Age).Take(5);


            //// In query syntax multiple sorting looks like below after comma separated we put next field
            //var orderTestAscQuery = (from s in testData
            //                        orderby s.FirstName, s.Address.City ascending
            //                        select s).Take(5);

            //var orderTestDesQuery = (from s in testData
            //                         orderby s.Age descending
            //                         select s).Take(5);

            //Console.WriteLine("Metod syntax:");
            //Console.WriteLine("Asc");
            //PrintResultOnTheScreen(orderTestAscMethod);
            //Console.WriteLine("Des");
            //PrintResultOnTheScreen(orderTestDesMethod);
            //Console.WriteLine();
            //Console.WriteLine("Query syntax");
            //Console.WriteLine("Asc");
            //PrintResultOnTheScreen(orderTestAscQuery);
            //Console.WriteLine("Dsc");
            //PrintResultOnTheScreen(orderTestDesQuery);

            //Console.WriteLine("Method syntax");
            //var groupTestMethod = testData.GroupBy(x => x.Address.City);

            //foreach(var gtm in groupTestMethod)
            //{
            //    Console.WriteLine($"Group name: {gtm.Key}");
            //    foreach (var item in gtm)
            //    {
            //        Console.WriteLine($"Name: {item.FirstName}, Age: {item.Age}");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Query sytntax");

            //var groupTestQuery = from s in testData
            //                     orderby s.Age ascending
            //                     group s by s.Age;

            //foreach(var gtq in groupTestQuery)
            //{
            //    Console.WriteLine($"Group name: {gtq.Key}");
            //    foreach (var item in gtq)
            //    {
            //        Console.WriteLine($"Name: {item.FirstName}, City: {item.Address.City}");
            //    }
            //}

            var clubList = new List<Club>
            {
                new Club { Id = 1, Name = "Manchester Utd", CountryId = 1 },
                new Club { Id = 2, Name = "Real", CountryId = 2 },
                new Club { Id = 3, Name = "Barcelona", CountryId = 2 },
                new Club { Id = 4, Name = "Manchester City", CountryId = 1 },
                new Club { Id = 5, Name = "Bayern", CountryId = 3 },
                new Club { Id = 6, Name = "Liverpool", CountryId = 1 },
                new Club { Id = 7, Name = "Schalke", CountryId = 3 },
                new Club { Id = 8, Name = "Borussia", CountryId = 3 },
                new Club { Id = 9, Name = "Chelsea", CountryId = 1 },
                new Club { Id = 10, Name = "Arsenal", CountryId = 1 },
                new Club { Id = 11, Name = "Inter", CountryId = 4 },
                new Club { Id = 12, Name = "Milan", CountryId = 4 },
                new Club { Id = 13, Name = "Monaco", CountryId = 5 },
                new Club { Id = 14, Name = "Sevilla", CountryId = 2 },
                new Club { Id = 15, Name = "Tottenham", CountryId = 1 },
                new Club { Id = 15, Name = "PSG", CountryId = 5 },
                new Club { Id = 16, Name = "Roma", CountryId = 4 },
                new Club { Id = 17, Name = "RB Leipzig", CountryId = 3 }
            };

            var countryList = new List<Country>
            {
                new Country { Id = 1, CountryName = "England", ListClubs = clubList.Where(x => x.CountryId == 1).ToList() },
                new Country { Id = 2, CountryName = "Spain", ListClubs = clubList.Where(x => x.CountryId == 2).ToList() },
                new Country { Id = 3, CountryName = "Germany", ListClubs = clubList.Where(x => x.CountryId == 3).ToList() },
                new Country { Id = 4, CountryName = "Italy", ListClubs = clubList.Where(x => x.CountryId == 4).ToList() },
                new Country { Id = 5, CountryName = "France", ListClubs = clubList.Where(x => x.CountryId == 5).ToList() }
            };

            //// In this example clubList is outer sequence
            //// countryList is inner sequence, next we define which field should be match using lambda from first and second collection
            //// Matched elements are adding to result 
            //var joinTestMethod = clubList.Join(countryList,
            //                                    club => club.CountryId,
            //                                    country => country.Id,
            //                                    (club, country) => new
            //                                    {
            //                                        Name = club.Name,
            //                                        Country = country.CountryName
            //                                    }).GroupBy(x => x.Country);


            //foreach (var jtm in joinTestMethod)
            //{
            //    Console.WriteLine($"Group name: {jtm.Key}");
            //    foreach (var item in jtm)
            //    {
            //        Console.WriteLine($"Name: {item.Name}, City: {item.Country}");
            //    }
            //}

            //Console.WriteLine("Query:\n");

            //var joinTestQuery = from club in clubList 
            //                    join country in countryList
            //                    on club.CountryId equals country.Id
            //                    select new { Name = club.Name, Country = country.CountryName };

            //PrintResultOnTheScreen(joinTestQuery);

            Console.WriteLine("Query Group join:\n");

            var groupJoinQuery = from country in countryList
                                 join club in clubList
                                 on country.Id equals club.CountryId
                                 into countryGroup
                                 select new
                                 {
                                     Club = countryGroup,
                                     Country = country.CountryName
                                 };

            foreach (var item in groupJoinQuery)
            {
                Console.WriteLine($"\n{item.Country}\n");
                foreach (var club in item.Club)
                {
                    Console.WriteLine(club.Name);
                }
            }
        }

        private void PrintResultOnTheScreen(IEnumerable<Person> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Id + " " +
                    item.FirstName + " " +
                    item.LastName + " " +
                    item.Age + " " +
                    item.Address.City + " " +
                    item.Address.Country);
            }
        }

        private void PrintResultOnTheScreen(IEnumerable<object> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private void PrintResultOnTheScreen(Person obj)
        {
            Console.WriteLine(obj.Id + " " +
                    obj.FirstName + " " +
                    obj.LastName + " " +
                    obj.Age + " " +
                    obj.Address.City + " " +
                    obj.Address.Country);
        }

        private void PrintResultOnTheScreen(int amount)
        {
            Console.WriteLine($"Amount elements in list: {amount}");
        }
    }
}
