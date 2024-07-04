namespace EmployeeSys.Web.Models
{
    public class BaseEntityDto
    {
        public Guid Id { get; set; }
        public string? DefaultDesc { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatadDate { get; set; }
        public string _CreatadDate => CreatadDate !=null? CreatadDate.ToString("dd/MM/yyyy"):"NA";
        public DateTime? ModifiedDate { get; set; }
        public string _ModifiedDate => ModifiedDate != null ? ModifiedDate.ToString():"NA";
    }
}
