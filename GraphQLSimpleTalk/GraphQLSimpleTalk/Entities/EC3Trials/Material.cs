using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Entities.EC3Trials
{
    public class Material
    {
        public int Id { get; set; }
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
        public string ConcreteCompressiveStrength28d { get; set; }
        public string ConcreteCompressiveStrengthOther { get; set; }
        public int? ConcreteCompressiveStrengthOtherD { get; set; }
        public string ConcreteFlexionStrenth { get; set; }
        public string ConcreteSlump { get; set; }
        public string ConcreteMinSlump { get; set; }
        public string ConcreteMaxSlump { get; set; }
        public string ConcreteAggregateSizeMax { get; set; }
        public string ConcreteMinPipelineSize { get; set; }
        public double ConcreteWCRatio { get; set; }
        public double ConcreteScmMin { get; set; }
        public double ConcreteScmMax { get; set; }
        public ScmDetails ConcreteScmDetails { get; set; }
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
        public bool Galvanized { get; set; }
        public string GypsumFireRating { get; set; }
        public string GypsumThickness { get; set; }
        public string GypsumSpecificDensity { get; set; }
        public string GypsumRFactor { get; set; }
        public int? GypsumFlameSpreadAstmE84 { get; set; }
        public int? GypsumSmokeProductionAstmE84 { get; set; }
        public int? GypsumSurfaceAbrasionD4977 { get; set; }
        public int? GypsumIndentationD5420 { get; set; }
        public int? GypsumSoftBodyImpactE695 { get; set; }
        public int? GypsumHardBodyImpactC1929 { get; set; }
        //Z stands for standard deviation
        public double BiogenicEmbodiedCarbonZ { get; set; }
    }
}
