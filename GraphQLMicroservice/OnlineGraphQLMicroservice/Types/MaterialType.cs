﻿using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class MaterialType : ObjectGraphType<Material>
    {
        public MaterialType()
        {
            Field(x => x.Id);
            Field(x => x.Created_on);
            Field(x => x.Created_by);
            Field(x => x.Updated_on);
            Field(x => x.Updated_by);
            Field<OwnerType>("owner");
            Field(x => x.Name);
            Field(x => x.Alt_names, nullable: true);
            Field(x => x.Description);
            Field(x => x.Declared_unit);
            Field(x => x.Mass_per_declared_unit);
            Field(x => x.Datasheet_link);
            Field(x => x.Gwp);
            Field(x => x.Gwp_per_category_declared_unit);
            Field(x => x.Gwp_per_kg);
            Field(x => x.Gwp_z);
            Field(x => x.Pct80_gwp_per_category_declared_unit, nullable: false);
            Field(x => x.Conservative_estimate);
            Field(x => x.Best_practice);
            Field(x => x.Concrete_compressive_strength_28d);
            Field(x => x.Concrete_compressive_strength_other);
            Field(x => x.Concrete_compressive_strength_other_d, nullable: true);
            Field(x => x.Concrete_flexion_strength);
            Field(x => x.Concrete_slump);
            Field(x => x.Concrete_min_slump);
            Field(x => x.Concrete_max_slump);
            Field(x => x.Concrete_aggregate_size_max);
            Field(x => x.Concrete_min_pipeline_size);
            Field(x => x.Concrete_w_c_ratio, nullable: true);
            Field(x => x.Concrete_scm_min);
            Field(x => x.Concrete_scm_max, nullable: true);
            Field<ConcreteScmDetailsType>("concrete_scm_details");
            Field(x => x.Concrete_air_entrain);
            Field(x => x.Concrete_co2_entrain);
            Field(x => x.White_cement);
            Field(x => x.Light_weight);
            Field(x => x.Density);
            Field(x => x.Steel_ultim_tensile_str_min);
            Field(x => x.Steel_yield_tensile_str_min);
            Field(x => x.Steel_bar_elongation_min, nullable: true);
            Field(x => x.Steel_recycled_content, nullable: true);
            Field(x => x.Steel_post_consumer_recycled_content, nullable: true);
            Field(x => x.Steel_astm_marking);
            Field(x => x.Steel_euro_marking);
            Field(x => x.Steel_rebar_diameter_min);
            Field(x => x.Steel_rebar_bending_pin_max, nullable: true);
            Field(x => x.Steel_rebar_ts_ys_ratio_max, nullable: true);
            Field(x => x.Steel_modulus_of_elasticity);
            Field(x => x.Steel_thermal_expansion);
            Field(x => x.Steel_thermal_conductivity);
            Field(x => x.Cold_finished, nullable: true);
            Field(x => x.Galvanized, nullable: true);
            Field(x => x.Gypsum_fire_rating);
            Field(x => x.Gypsum_thickness);
            Field(x => x.Gypsum_specific_density);
            Field(x => x.Gypsum_r_factor);
            Field(x => x.Gypsum_flame_spread_astm_e84, nullable: true);
            Field(x => x.Gypsum_smoke_production_astm_e84, nullable: true);
            Field(x => x.Gypsum_surface_abrasion_d4977, nullable: true);
            Field(x => x.Gypsum_indentation_d5420, nullable: true);
            Field(x => x.Gypsum_soft_body_impact_e695, nullable: true);
            Field(x => x.Gypsum_hard_body_impact_c1929, nullable: true);
            Field(x => x.Biogenic_embodied_carbon);
            Field(x => x.Biogenic_embodied_carbon_z);
            Field(x => x.Timber_stored_carbon);
            Field(x => x.Timber_stored_carbon_z, nullable: true);
            Field(x => x.Max_size, nullable: true);
            Field(x => x.Specific_gravity, nullable: true);
            Field(x => x.Recommended_application);
            Field(x => x.Image_link);
            Field(x => x.Reference_service_life);
            Field(x => x.Intended_application);
            Field(x => x.Insulation_intended_application);
            Field(x => x.Manufacturer_type);
            Field(x => x.Form_factor);
            Field(x => x.Yarn_weight);
            Field(x => x.Yarn_type);
            Field(x => x.Cushioned, nullable: true);
            Field(x => x.Bleachable, nullable: true);
            Field(x => x.Fire_radiant_panel_rating_astme648);
            Field(x => x.Fire_smoke_density_rating_astme648);
            Field(x => x.Voc_emissions);
            Field(x => x.Thickness);
            Field(x => x.Surface_area);
            Field(x => x.Static_load);
            Field(x => x.Acoustics_nrc, nullable: true);
            Field(x => x.Recycled_content, nullable: true);
            Field(x => x.Insulating_material);
            Field(x => x.Foam_type);
            Field(x => x.Thickness_per_declared_unit);
            Field(x => x.Ceiling_panel_core_material);
            Field(x => x.Ceiling_panel__nrc, nullable: true);
            Field(x => x.Ceiling_panel_cac, nullable: true);
            Field(x => x.Features);
            Field(x => x.Weather_exposed, nullable: true);
            Field(x => x.Fabrication);
            Field(x => x.Timber_species);
            Field<ManufacturerType>("manufacturer");
            Field<PlantType>("plant");
            Field(x => x.Epd_id);
        }
    }
}
