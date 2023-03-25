namespace StudentReport.Data
{
    public class Countries
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
