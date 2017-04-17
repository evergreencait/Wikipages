using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            this.Businesses = new HashSet<Business>();
        }

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
