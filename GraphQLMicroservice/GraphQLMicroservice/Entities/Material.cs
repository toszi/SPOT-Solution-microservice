using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Material
    {        
        public string Id { get; set; }
        public string Created_on { get; set; }
        public string Created_by { get; set; }
        public string Updated_on { get; set; }
        public string Updated_by { get; set; }
        public Owner Owner { get; set; }
        public string Name { get; set; }
        public string[] Alt_names { get; set; }
        public string Description { get; set; }
        public string Declared_unit { get; set; }
        public string Mass_per_declared_unit { get; set; }
        //Global warming potetial
        public string Gwp { get; set; }
        //Z stands for standard deviation
        public float Gwp_z { get; set; }
        public string Gwp_per_category_declared_unit { get; set; }
        public string Pct80_gwp_per_category_declared_unit { get; set; }
        public string Gwp_per_kg { get; set; }
        public string Datasheet_link { get; set; }
        public string Conservative_estimate { get; set; }
        public string Best_practice { get; set; }
        public string Concrete_compressive_strength_28d { get; set; }
        public string Concrete_compressive_strength_other { get; set; }
        public int? Concrete_compressive_strength_other_d { get; set; }
        public string Concrete_flexion_strength { get; set; }
        public string Concrete_slump { get; set; }
        public string Concrete_min_slump { get; set; }
        public string Concrete_max_slump { get; set; }
        public string Concrete_aggregate_size_max { get; set; }
        public string Concrete_min_pipeline_size { get; set; }
        public float? Concrete_w_c_ratio { get; set; }
        public float Concrete_scm_min { get; set; }
        public float? Concrete_scm_max { get; set; }
        public ConcreteScmDetails Concrete_scm_details { get; set; }
        public bool Concrete_air_entrain { get; set; }
        public bool Concrete_co2_entrain { get; set; }
        public bool White_cement { get; set; }
        public bool Light_weight { get; set; }
        public string Density { get; set; }
        public string Steel_ultim_tensile_str_min { get; set; }
        public string Steel_yield_tensile_str_min { get; set; }
        public float? Steel_bar_elongation_min { get; set; }
        public float? Steel_recycled_content { get; set; }
        public float? Steel_post_consumer_recycled_content { get; set; }
        public string Steel_astm_marking { get; set; }
        public string Steel_euro_marking { get; set; }
        public string Steel_rebar_diameter_min { get; set; }
        public float? Steel_rebar_bending_pin_max { get; set; }
        public float? Steel_rebar_ts_ys_ratio_max { get; set; }
        public string Steel_modulus_of_elasticity { get; set; }
        public string Steel_thermal_expansion { get; set; }
        public string Steel_thermal_conductivity { get; set; }
        public bool? Cold_finished { get; set; }
        public bool? Galvanized { get; set; }
        public string Gypsum_fire_rating { get; set; }
        public string Gypsum_thickness { get; set; }
        public string Gypsum_specific_density { get; set; }
        public string Gypsum_r_factor { get; set; }
        public int? Gypsum_flame_spread_astm_e84 { get; set; }
        //public object GypsumFlameSpreadAstmE84 { get; set; }
        public int? Gypsum_smoke_production_astm_e84 { get; set; }
        //public object GypsumSmokeProductionAstmE84 { get; set; }
        public int? Gypsum_surface_abrasion_d4977 { get; set; }
        //public object GypsumSurfaceAbrasionD4977 { get; set; }
        public int? Gypsum_indentation_d5420 { get; set; }
        //public object GypsumIndentationD5420 { get; set; }
        public int? Gypsum_soft_body_impact_e695 { get; set; }
        //public object GypsumSoftBodyImpactE695 { get; set; }
        public int? Gypsum_hard_body_impact_c1929 { get; set; }
        //public object GypsumHardBodyImpactC1929 { get; set; }
        public string Biogenic_embodied_carbon { get; set; }
        //Z stands for standard deviation
        public float Biogenic_embodied_carbon_z { get; set; }
        public string Timber_stored_carbon { get; }
        public float? Timber_stored_carbon_z { get; set; }
        public float? Max_size { get; set; }
        public float? Specific_gravity { get; set; }
        public string Recommended_application { get; set; }
        public string Image_link { get; set; }
        public string Reference_service_life { get; set; }
        public string Intended_application { get; set; }
        public string Insulation_intended_application { get; set; }
        public string Manufacturer_type { get; set; }
        public string Form_factor { get; set; }
        public string Yarn_weight { get; set; }
        public string Yarn_type { get; set; }
        public bool? Cushioned { get; set; }
        public bool? Bleachable { get; set; }
        public string Fire_radiant_panel_rating_astme648 { get; set; }
        public string Fire_smoke_density_rating_astme648 { get; set; }
        public string Voc_emissions { get; set; }
        public string Thickness { get; set; }
        public string Surface_area { get; set; }
        public string Static_load { get; set; }
        public float? Acoustics_nrc { get; set; }
        public float? Recycled_content { get; set; }
        public string Insulating_material { get; set; }
        public string Foam_type { get; set; }
        public string Thickness_per_declared_unit { get; set; }
        public string Ceiling_panel_core_material { get; set; }
        public float? Ceiling_panel__nrc { get; set; }
        public float? Ceiling_panel_cac { get; set; }
        public string Features { get; set; }
        public bool? Weather_exposed { get; set; }
        public string Fabrication { get; set; }
        public string Timber_species { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Plant Plant { get; set; }
        public string Epd_id { get; set; }
    }
}
