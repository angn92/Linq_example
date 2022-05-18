using Linq_example.Domain;

namespace Linq_example
{
    public class TestData
    {
        public IEnumerable<Person> GetTestingData()
        {
            var list = new List<Person>
            {
                new Person
                {
                    Id = 1, FirstName = "Adam", LastName = "Nowak", Age = 20, Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 2, FirstName = "Andrzej", LastName = "Wiśniewski", Age = 35,Address = new Address { City = "Katowice", Country = "Poland" }
                },
                new Person
                {
                    Id = 3, FirstName = "Łukasz", LastName = "Wójcik", Age = 21,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 4, FirstName = "Anna", LastName = "Wiśniewska", Age = 21,Address = new Address { City = "Elbląg", Country = "Poland" }
                },
                new Person
                {
                    Id = 5, FirstName = "Mateusz", LastName = "Kowalczyk", Age = 42,Address = new Address { City = "Sopot", Country = "Poland" }
                },
                new Person
                {
                    Id = 6, FirstName = "Kamil", LastName = "Zielińska", Age = 32,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 7, FirstName = "Joanna", LastName = "Szymańska", Age = 45,Address = new Address { City = "Jelenia góra", Country = "Poland" }
                },
                new Person
                {
                    Id = 8, FirstName = "Barbara", LastName = "Kowalska", Age = 41,Address = new Address { City = "Łódź", Country = "Poland" }
                },
                new Person
                {
                    Id = 9, FirstName = "Kamila", LastName = "Zieliński", Age = 25,Address = new Address { City = "Płock", Country = "Poland" }
                },
                new Person
                {
                    Id = 10, FirstName = "Kamil", LastName = "Szymański", Age = 28,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 11, FirstName = "Damian", LastName = "Lewandowski", Age = 25,Address = new Address { City = "Radom", Country = "Poland" }
                },
                new Person
                {
                    Id = 12, FirstName = "Paweł", LastName = "Trudny", Age = 32,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 13, FirstName = "Piotr", LastName = "Dąbrowski", Age = 20,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 14, FirstName = "Wojtek", LastName = "Woźniak", Age = 37,Address = new Address { City = "Wieliczka", Country = "Poland" }
                },
                new Person
                {
                    Id = 15, FirstName = "Wojciech", LastName = "Kozłowski", Age = 39,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 16, FirstName = "Justyna", LastName = "Woźniak", Age = 38,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 17, FirstName = "Czesław", LastName = "Jankowski", Age = 30,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 18, FirstName = "Piotr", LastName = "Mazur", Age = 29,Address = new Address { City = "Radom", Country = "Poland" }
                },
                new Person
                {
                    Id = 19, FirstName = "Dawid", LastName = "Kwiatkowski", Age = 45,Address = new Address { City = "Radom", Country = "Poland" }
                },
                new Person
                {
                    Id = 20, FirstName = "Magdalena", LastName = "Wojciechowska", Age = 41,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 21, FirstName = "Tomasz", LastName = "Krawczyk", Age = 19,Address = new Address { City = "Olsztyn", Country = "Poland" }
                },
                new Person
                {
                    Id = 22, FirstName = "Jakub", LastName = "Kaczmarek", Age = 16,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 23, FirstName = "Emil", LastName = "Grabowski", Age = 16,Address = new Address { City = "Lubin", Country = "Poland" }
                },
                new Person
                {
                    Id = 24, FirstName = "Dominik", LastName = "Nowy", Age = 37,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 25, FirstName = "Marek", LastName = "Stary", Age = 36,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 26, FirstName = "Dariusz", LastName = "Pewny", Age = 20,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 27, FirstName = "Łukasz", LastName = "Niepewny", Age = 31,Address = new Address { City = "Radom", Country = "Poland" }
                },
                new Person
                {
                    Id = 28, FirstName = "Adam", LastName = "Zakręcony", Age = 30,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 29, FirstName = "Cezary", LastName = "Brzoza", Age = 40,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 30, FirstName = "Maciej", LastName = "Wczesny", Age = 25,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 31, FirstName = "Bogdan", LastName = "Śmiały", Age = 23,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 32, FirstName = "Bartosz", LastName = "Kwarc", Age = 28, Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 33, FirstName = "Artur", LastName = "hfgdfg", Age = 26,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 34, FirstName = "Arkadiusz", LastName = "bdfgdf", Age = 21,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 35, FirstName = "Albert", LastName = "ddfgdfg",Age = 22, Address = new Address { City = "Gdynia", Country = "Poland" }
                },
                new Person
                {
                    Id = 36, FirstName = "Alex", LastName = "dfgc", Age = 30,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 37, FirstName = "Adam", LastName = "Nowak", Age = 20, Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 38, FirstName = "Andrzej", LastName = "Wiśniewski", Age = 35,Address = new Address { City = "Katowice", Country = "Poland" }
                },
                new Person
                {
                    Id = 39, FirstName = "Łukasz", LastName = "Wójcik", Age = 21,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 40, FirstName = "Anna", LastName = "Wiśniewska", Age = 21,Address = new Address { City = "Elbląg", Country = "Poland" }
                },
                new Person
                {
                    Id = 41, FirstName = "Mateusz", LastName = "Kowalczyk", Age = 42,Address = new Address { City = "Sopot", Country = "Poland" }
                },
                new Person
                {
                    Id = 42, FirstName = "Kamil", LastName = "Zielińska", Age = 32,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 43, FirstName = "Joanna", LastName = "Szymańska", Age = 45,Address = new Address { City = "Jelenia góra", Country = "Poland" }
                },
                new Person
                {
                    Id = 44, FirstName = "Barbara", LastName = "Kowalska", Age = 41,Address = new Address { City = "Łódź", Country = "Poland" }
                },
                new Person
                {
                    Id = 45, FirstName = "Kamila", LastName = "Zieliński", Age = 25,Address = new Address { City = "Płock", Country = "Poland" }
                },
                new Person
                {
                    Id = 46, FirstName = "Kamil", LastName = "Szymański", Age = 28,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 47, FirstName = "Kamila", LastName = "Lewandowski", Age = 25,Address = new Address { City = "Radom", Country = "Poland" }
                },
                new Person
                {
                    Id = 48, FirstName = "Józef", LastName = "Trudny", Age = 32,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 49, FirstName = "Adam", LastName = "Dąbrowski", Age = 21,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 50, FirstName = "Wojtek", LastName = "Woźniak", Age = 37,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 51, FirstName = "Wojciech", LastName = "Kozłowski", Age = 46,Address = new Address { City = "Kraków", Country = "Poland" }
                },
                new Person
                {
                    Id = 52, FirstName = "Justyna", LastName = "Woźniak", Age = 65,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 53, FirstName = "Dawid", LastName = "Jankowski", Age = 34,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 54, FirstName = "Piotr", LastName = "Mazur", Age = 65,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 55, FirstName = "Dawid", LastName = "Kwiatkowski", Age = 45,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 56, FirstName = "Magdalena", LastName = "Wojciechowska", Age = 45,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 57, FirstName = "Tomasz", LastName = "Krawczyk", Age = 21,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 58, FirstName = "Paweł", LastName = "Kaczmarek", Age = 17,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 59, FirstName = "Jan", LastName = "Grabowski", Age = 57,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 60, FirstName = "Weronika", LastName = "Nowy", Age = 52,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
                new Person
                {
                    Id = 61, FirstName = "Marek", LastName = "Stary", Age = 36,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 62, FirstName = "Klaudiusz", LastName = "Pewny", Age = 55,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 63, FirstName = "Łukasz", LastName = "Niepewny", Age = 31,Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 64, FirstName = "Adam", LastName = "Zakręcony", Age = 35,Address = new Address { City = "Wrocław", Country = "Poland" }
                },
                new Person
                {
                    Id = 65, FirstName = "Cezary", LastName = "Brzoza", Age = 42,Address = new Address { City = "Opole", Country = "Poland" }
                },
                new Person
                {
                    Id = 66, FirstName = "Maciej", LastName = "Wczesny", Age = 56,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 67, FirstName = "Filip", LastName = "Śmiały", Age = 48,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 68, FirstName = "Bartosz", LastName = "Kwarc", Age = 28, Address = new Address { City = "Warszawa", Country = "Poland" }
                },
                new Person
                {
                    Id = 69, FirstName = "Artur", LastName = "hfgdfg", Age = 26,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 70, FirstName = "Marcin", LastName = "bdfgdf", Age = 21,Address = new Address { City = "Chorzów", Country = "Poland" }
                },
                new Person
                {
                    Id = 71, FirstName = "Miłosz", LastName = "ddfgdfg",Age = 22, Address = new Address { City = "Gdynia", Country = "Poland" }
                },
                new Person
                {
                    Id = 72, FirstName = "Alex", LastName = "dfgc", Age = 30,Address = new Address { City = "Gdansk", Country = "Poland" }
                },
            };
            return list;
        }
    }
}
