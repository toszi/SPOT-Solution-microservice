﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Manufacturer
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public object Owner { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location Location { get; set; }
        public string AddressLine { get; set; }
        public string AdminDistrict { get; set; }
        public string AdminDistrict2 { get; set; }
        public string Locality { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string LegalName { get; set; }
        public List<string> AltNames { get; set; }
        public object Jurisdiction { get; set; }
        public bool PrimaryActivityOwner { get; set; }
        public bool PrimaryActivityBuilder { get; set; }
        public bool PrimaryActivityDesign { get; set; }
        public bool PrimaryActivityManufacturer { get; set; }
        public bool PrimaryActivityOperator { get; set; }
        public bool PrimaryActivityVerifier { get; set; }
        public bool PrimaryActivityIndustryAssociation { get; set; }
        public bool PrimaryActivityOther { get; set; }
        public bool PrimaryActivityForestPracticesCertification { get; set; }
        public bool PrimaryActivityDigitizationQa { get; set; }
        public bool PrimaryActivitySustainabilityConsulting { get; set; }
        public object TaxId { get; set; }
        public string Website { get; set; }
        public string TransparencyCatalogLink { get; set; }
        public object Email { get; set; }
        public string OrgType { get; set; }
        public object Currency { get; set; }
        public bool Enterprise { get; set; }
        public object Parent { get; set; }
        public object GwpContact { get; set; }
        public object UserGroupEmployees { get; set; }
        public object PrimarySustainabilityContact { get; set; }
    }
}
