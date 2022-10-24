namespace DomainClass.Common
{
    public class BaseEntity
    {
        //[Key]//clave principal
        public long Id { get; set; }
        public long CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }//el signo de interrogación es nulo
        public long LastModifiedBy { get; set; }//quien lo modificó
        public DateTime? LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
