using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webglobic.Models
{
    public class Tester
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Testing office is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Testing office must be between 5 and 50 characters.")]
        public string TestingOffice { get; set; }

        [Required(ErrorMessage = "Name/designation company is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name/designation company must be between 5 and 50 characters.")]
        public string NameDesignationCompany { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(13, MinimumLength = 6, ErrorMessage = "Phone must be between 6 and 13 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(30, ErrorMessage = "Country must be up to 30 characters.")]
        public string Country { get; set; }

        // Assume the signature image is handled separately, perhaps as a file upload

        public List<string> CertificationType { get; set; }

        // Assume the certificate upload is handled separately, perhaps as a file upload
        public List<string> CertificateUpload { get; set; }

        public List<DateTime> DateOfIssueCertificate { get; set; }

        public List<DateTime> ExpiryDateCertificate { get; set; }
    }
}
