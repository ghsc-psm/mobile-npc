﻿namespace MobileNPC.Core.Models
{
    using System.Collections.Generic;
    public class ProductConfiguration
    {
        public string DefaultLocale { get; set; } = "en_US";
        public string ImageAttribute { get; set; }
        public string CountryAttribute { get; set; }
        public string GTINAttribute { get; set; }
        public List<AttributeConfiguration> AttributeConfigurations { get; set; } = new List<AttributeConfiguration>();

        public static ProductConfiguration Default => Malawi;

        public static ProductConfiguration Malawi => new ProductConfiguration
        {
            ImageAttribute = "GS1_PRODUCT_IMAGE",
            CountryAttribute = "GS1_PLACEOFPRODUCTACTIVITYCOUNTRYOFORIGINCOUNTRYCODE",
            DefaultLocale = "en_US",
            GTINAttribute = "GTIN",
            AttributeConfigurations = new List<AttributeConfiguration>
            {
                new AttributeConfiguration {Code = "GS1_PLACEOFPRODUCTACTIVITYCOUNTRYOFORIGINCOUNTRYCODE", Label = "Country Of Origin"},
                new AttributeConfiguration {Code = "GS1_BRANDNAME", Label = "Brand Name"},
                new AttributeConfiguration {Code = "GS1_FUNCTIONALNAME", Label = "Functional Name"},
                new AttributeConfiguration {Code = "MANUFACTURER_NAME", Label = "Manufacturer Name"}
            }
        };

        public static ProductConfiguration Rwanda => new ProductConfiguration
        {
            ImageAttribute = "GS1_PRODUCT_IMAGE",
            CountryAttribute = "COUNTRY_OF_ORIGIN",
            DefaultLocale = "en_US",
            GTINAttribute = "GS1_GTIN_FOR_A_GS1_STANDARD_ITEM",
            AttributeConfigurations = new List<AttributeConfiguration>
            {
                new AttributeConfiguration {Code = "RW_PRODUCT_DESCRIPTION", Label = "Description"},
                new AttributeConfiguration {Code = "COUNTRY_OF_ORIGIN", Label = "Country Of Origin"},
                new AttributeConfiguration {Code = "GS1_BRANDNAME", Label = "Brand Name"},
                new AttributeConfiguration {Code = "MANUFACTURER_NAME", Label = "Manufacturer Name"}
            }
        };
    }

    public class AttributeConfiguration
    {
        public string Code { get; set; }
        public string Label { get; set; }
    }
}
