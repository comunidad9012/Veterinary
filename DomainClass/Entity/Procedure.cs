namespace Veterinary.Core.Entities
{
    public class Procedure
    {
        public int procedureId { get; set; }
        public string? procedure { get; set; }

        //Audit Data
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
