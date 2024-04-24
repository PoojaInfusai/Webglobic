using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webglobic.Models
{
    public class Owner
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Object/building is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Object/building must be between 5 and 50 characters.")]
        public string ObjectBuilding { get; set; }

        [Required(ErrorMessage = "Name/designation is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name/designation must be between 5 and 50 characters.")]
        public string NameDesignation { get; set; }

        [StringLength(150, MinimumLength = 10, ErrorMessage = "Address2 must be between 10 and 150 characters.")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Street, Hsnr. is required.")]
        [StringLength(200, ErrorMessage = "Street, Hsnr. must be up to 200 characters.")]
        public string StreetHsnr { get; set; }

        [Required(ErrorMessage = "Postcode is required.")]
        [StringLength(10, ErrorMessage = "Postcode must be up to 10 characters.")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(50, ErrorMessage = "Location must be up to 50 characters.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(30, ErrorMessage = "Country must be up to 30 characters.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Contact person (first and last name) is required.")]
        [StringLength(40, ErrorMessage = "Contact person (first and last name) must be up to 40 characters.")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(13, MinimumLength = 6, ErrorMessage = "Phone must be between 6 and 13 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [StringLength(255, ErrorMessage = "Remark must be up to 255 characters.")]
        public string Remark { get; set; }

        [StringLength(255, ErrorMessage = "Field must be up to 255 characters.")]
        public string Field { get; set; }
    }
}
