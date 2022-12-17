using System.ComponentModel.DataAnnotations;

namespace BasicMVC.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters", MinimumLength = 11)]
        public string Document { get; set; }

        public SupplierType SupplierType { get; set; }

        public Address Address { get; set; }

        public bool Active { get; set; }

        // EF Relations

        public IEnumerable<Product> Products { get; set; }
    }
}
