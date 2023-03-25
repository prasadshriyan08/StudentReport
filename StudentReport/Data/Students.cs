using System.ComponentModel.DataAnnotations.Schema;

namespace StudentReport.Data
{
    public class Students
    {
        public int Id { get; set; }
        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public DateOnly DOB { get; set; }

        public virtual Classes Classes { get; set; }
        public virtual Countries Countries { get; set; }
    }
}
