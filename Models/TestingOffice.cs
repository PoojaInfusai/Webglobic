using System;
using System.ComponentModel.DataAnnotations;

namespace Webglobic.Models
{
    public class TestingOffice
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must be up to 50 characters.")]
        public string Name { get; set; }

        [StringLength(15, ErrorMessage = "Customer number must be up to 15 characters.")]
        public string CustomerNumber { get; set; }

        [StringLength(150, ErrorMessage = "Address2 must be up to 150 characters.")]
        public string Address2 { get; set; }

        [StringLength(200, ErrorMessage = "Street, Hsnr. must be up to 200 characters.")]
        public string Street { get; set; }

        [StringLength(10, ErrorMessage = "Postcode must be up to 10 characters.")]
        public string Postcode { get; set; }

        [StringLength(50, ErrorMessage = "Location must be up to 50 characters.")]
        public string Location { get; set; }

        [StringLength(30, ErrorMessage = "Country must be up to 30 characters.")]
        public string Country { get; set; }

        [StringLength(20, ErrorMessage = "First Name must be up to 20 characters.")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "Last Name must be up to 20 characters.")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "Phone must be up to 15 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Remark must be up to 100 characters.")]
        public string Remark { get; set; }

        [StringLength(150, ErrorMessage = "Entrepreneur's declaration must be up to 150 characters.")]
        public string EntrepreneursDeclaration { get; set; }

        [StringLength(255, ErrorMessage = "Show business declaration in reports must be up to 255 characters.")]
        public string ShowBusinessDeclarationInReports { get; set; }

        [StringLength(150, ErrorMessage = "Field must be up to 150 characters.")]
        public string Field { get; set; }

        [StringLength(20, ErrorMessage = "Department must be up to 20 characters.")]
        public string Department { get; set; }
    }
}
