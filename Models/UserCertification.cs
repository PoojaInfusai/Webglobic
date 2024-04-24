using System;
using System.ComponentModel.DataAnnotations;

namespace Webglobic.Models
{
    public class UserCertification
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "User is required.")]
        public string User { get; set; }

        [Required(ErrorMessage = "Certification Type is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Certification Type must be between 3 and 50 characters.")]
        public string CertificationType { get; set; }

        [Required(ErrorMessage = "Issue Date is required.")]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage = "Expiry Date is required.")]
        public DateTime ExpiryDate { get; set; }

        [StringLength(255, MinimumLength = 10, ErrorMessage = "Certificate 1 must be between 10 and 255 characters.")]
        public string Certificate1 { get; set; }

        [StringLength(255, MinimumLength = 10, ErrorMessage = "Certificate 2 must be between 10 and 255 characters.")]
        public string Certificate2 { get; set; }

        [StringLength(255, MinimumLength = 10, ErrorMessage = "Certificate 3 must be between 10 and 255 characters.")]
        public string Certificate3 { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Remarks must be between 5 and 100 characters.")]
        public string Remarks { get; set; }
    }
}
