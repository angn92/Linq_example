namespace Linq_example.Domain
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

    }

    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public List<Club> ListClubs { get; set; }
    }
}
