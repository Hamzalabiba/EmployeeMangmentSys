using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DtoModel
{
    public class BaseEntityDto
    {
        public Guid Id { get; set; }
        public string? DefaultDesc { get; set; } = string.Empty;
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatadDate { get; set; }
        public string? _CreatadDate => CreatadDate.ToString("dd/MM/yyyy");
        public DateTime ModifiedDate { get; set; }
        public string? _ModifiedDate => ModifiedDate.ToString("dd/MM/yyyy");
    }
}
