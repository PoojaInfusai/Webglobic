﻿namespace Webglobic.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; } 
        public bool IsDefault { get; set; }
    }
}
