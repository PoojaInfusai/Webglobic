using System;
using System.ComponentModel.DataAnnotations;

namespace Webglobic.Models
{
    public class TestObjectSystem
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Trade/System type is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Trade/System type must be between 3 and 50 characters.")]
        public string TradeSystemType { get; set; }

        [Required(ErrorMessage = "Object/Building is required.")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Object/Building must be between 10 and 150 characters.")]
        public string ObjectBuilding { get; set; }

        [Required(ErrorMessage = "Name/Designation is required.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Name/Designation must be between 10 and 50 characters.")]
        public string NameDesignation { get; set; }

        [Required(ErrorMessage = "System identification test office is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "System identification test office must be between 5 and 50 characters.")]
        public string SystemIdentificationTestOffice { get; set; }

        [Required(ErrorMessage = "System identifier customer/operator is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "System identifier customer/operator must be between 5 and 50 characters.")]
        public string SystemIdentifierCustomerOperator { get; set; }

        [Required(ErrorMessage = "Contact person (First and Last Name) is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Contact person (First and Last Name) must be between 5 and 50 characters.")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(13, MinimumLength = 6, ErrorMessage = "Phone must be between 6 and 13 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        public DateTime LastTest { get; set; }

        [StringLength(50, ErrorMessage = "Last examiner must be up to 50 characters.")]
        public string LastExaminer { get; set; }

        public DateTime YearOfConstruction { get; set; }

        [StringLength(100, ErrorMessage = "Remark must be up to 100 characters.")]
        public string Remark { get; set; }

        public DateTime NextInspection { get; set; }

        [StringLength(100, ErrorMessage = "Reason for changed test interval must be up to 100 characters.")]
        public string ReasonForChangedTestInterval { get; set; }

        [StringLength(50, ErrorMessage = "Humidifier available must be up to 50 characters.")]
        public string HumidifierAvailable { get; set; }

        [StringLength(50, ErrorMessage = "Manufacturer must be up to 50 characters.")]
        public string Manufacturer { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid format. Use up to 2 decimal places.")]
        public float AirVolumeSupplyAir { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid format. Use up to 2 decimal places.")]
        public float AirVolumeExhaustAir { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid format. Use up to 2 decimal places.")]
        public float AirVolumeRecirculatedAir { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid format. Use up to 2 decimal places.")]
        public float AirVolumeOutsideAir { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid format. Use up to 2 decimal places.")]
        public float CaseHeight { get; set; }

        public string TypeOfRoomsServed { get; set; }

        public string TypeOfRoomsServedFreeText { get; set; }

        public string AirQualityOutsideAirAUL_ODA { get; set; }

        public string AirQualitySupplyAirZUL_SUP { get; set; }

        public string AirQualityExhaustAirABL_ETA { get; set; }

        public string AirQualityExhaustAirFOL_EHA { get; set; }

        public string AirQualityIndoorAirRAL_IDA { get; set; }
    }
}
