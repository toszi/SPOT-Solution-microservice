using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Material
    {        
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Owner Owner { get; set; }
        public string Name { get; set; }
        public string[] AlternativeNames { get; set; }
        public string Description { get; set; }
        public string DeclaredUnit { get; set; }
        public string MassPerDeclaredUnit { get; set; }
        //Global warming potetial
        public string Gwp { get; set; }
        //Z stands for standard deviation
        public double GwpZ { get; set; }
        public string GwpPerCategoryDeclaredUnit { get; set; }
        public string Pct80GwpPerCategoryDeclaredUnit { get; set; }
        public string GwpPerKg { get; set; }
        public string DatasheetLink { get; set; }
        public string ConservativeEstimate { get; set; }
        public string BestPractice { get; set; }
        public string ConcreteCompressiveStrength28D { get; set; }
        public string ConcreteCompressiveStrengthOther { get; set; }
        //public int? ConcreteCompressiveStrengthOtherD { get; set; }
        public int? ConcreteCompressiveStrengthOtherD { get; set; }
        public string ConcreteFlexionStrength { get; set; }
        public string ConcreteSlump { get; set; }
        public string ConcreteMinSlump { get; set; }
        public string ConcreteMaxSlump { get; set; }
        public string ConcreteAggregateSizeMax { get; set; }
        public string ConcreteMinPipelineSize { get; set; }
        public double ConcreteWCRatio { get; set; }
        public double ConcreteScmMin { get; set; }
        public double ConcreteScmMax { get; set; }
        public ConcreteScmDetails ConcreteScmDetails { get; set; }
        public bool ConcreteAirEntrain { get; set; }
        public bool ConcreteCo2Entrain { get; set; }
        public bool WhiteCement { get; set; }
        public bool LightWeight { get; set; }
        public string Density { get; set; }
        public string SteelUltimTensileStrMin { get; set; }
        public string SteelYieldTensileStrMin { get; set; }
        public double SteelBarElongationMin { get; set; }
        public double SteelRecycledContent { get; set; }
        public double SteelPostConsumerRecycledContent { get; set; }
        public string SteelAstmMarking { get; set; }
        public string SteelEuroMarking { get; set; }
        public string SteelRebarDiameterMin { get; set; }
        public double SteelRebarBendingPinMax { get; set; }
        public double SteelRebarTsYsRatioMax { get; set; } = 1;
        public string SteelModulusOfElasticity { get; set; }
        public string SteelThermalExpansion { get; set; }
        public string SteelThermalConductivity { get; set; }
        public bool ColdFinished { get; set; }
        public bool? Galvanized { get; set; }
        public string GypsumFireRating { get; set; }
        public string GypsumThickness { get; set; }
        public string GypsumSpecificDensity { get; set; }
        public string GypsumRFactor { get; set; }
        public int? GypsumFlameSpreadAstmE84 { get; set; }
        //public object GypsumFlameSpreadAstmE84 { get; set; }
        public int? GypsumSmokeProductionAstmE84 { get; set; }
        //public object GypsumSmokeProductionAstmE84 { get; set; }
        public int? GypsumSurfaceAbrasionD4977 { get; set; }
        //public object GypsumSurfaceAbrasionD4977 { get; set; }
        public int? GypsumIndentationD5420 { get; set; }
        //public object GypsumIndentationD5420 { get; set; }
        public int? GypsumSoftBodyImpactE695 { get; set; }
        //public object GypsumSoftBodyImpactE695 { get; set; }
        public int? GypsumHardBodyImpactC1929 { get; set; }
        //public object GypsumHardBodyImpactC1929 { get; set; }
        public string BiogenicEmbodiedCarbon { get; set; }
        //Z stands for standard deviation
        public double BiogenicEmbodiedCarbonZ { get; set; }
        public string TimberStoredCarbon { get; }
        public double? TimberStoredCarbonZ { get; set; }
        public double? MaxSize { get; set; }
        public double? SpecificGravity { get; set; }
        public string RecommendedApplication { get; set; }
        public string ImageLink { get; set; }
        public string ReferenceServiceLife { get; set; }
        public string IntendedApplication { get; set; }
        public string InsulationIntendedApplication { get; set; }
        public string ManufacturerType { get; set; }
        public string FormFactor { get; set; }
        public string YarnWeight { get; set; }
        public string YarnType { get; set; }
        public bool? Cushioned { get; set; }
        public bool? Bleachable { get; set; }
        public string FireRadiantPanelRatingAstme648 { get; set; }
        public string FireSmokeDensityRatingAstme648 { get; set; }
        public string VocEmissions { get; set; }
        public string Thickness { get; set; }
        public string SurfaceArea { get; set; }
        public string StaticLoad { get; set; }
        public double? AcousticsNrc { get; set; }
        public double? RecycledContent { get; set; }
        public string InsulatingMaterial { get; set; }
        public string FoamType { get; set; }
        public string ThicknessPerDeclaredUnit { get; set; }
        public string CeilingPanelCoreMaterial { get; set; }
        public double? CeilingPanelNrc { get; set; }
        public double? CeilingPanelCac { get; set; }
        public string Features { get; set; }
        public bool WeatherExposed { get; set; }
        public string Fabrication { get; set; }
        public string TimberSpecies { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Plant Plant { get; set; }
        public string EpdId { get; set; }
    }
}
