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

            Console.WriteLine("Method syntax");
            var groupTestMethod = testData.GroupBy(x => x.Address.City);

            foreach(var gtm in groupTestMethod)
            {
                Console.WriteLine($"Group name: {gtm.Key}");
                foreach (var item in gtm)
                {
                    Console.WriteLine($"Name: {item.FirstName}, Age: {item.Age}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Query sytntax");

            var groupTestQuery = from s in testData
                                 orderby s.Age ascending
                                 group s by s.Age;

            foreach(var gtq in groupTestQuery)
            {
                Console.WriteLine($"Group name: {gtq.Key}");
                foreach (var item in gtq)
                {
                    Console.WriteLine($"Name: {item.FirstName}, City: {item.Address.City}");
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
