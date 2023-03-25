namespace StudentReport.Data
{
    public class Classes
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
