using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace vidly3.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }

}
