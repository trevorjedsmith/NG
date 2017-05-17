namespace NextGen.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NextGen.Models;
    using NextGen.Domain.Abstract;

    public partial class DataContext : DbContext , IDbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public virtual DbSet<ad_ca_abs_lending_purpose_code> ad_ca_abs_lending_purpose_code { get; set; }
        public virtual DbSet<ad_ca_abs_occupation_code> ad_ca_abs_occupation_code { get; set; }
        public virtual DbSet<ad_ca_address_type> ad_ca_address_type { get; set; }
        public virtual DbSet<ad_ca_agricultural_asset_type> ad_ca_agricultural_asset_type { get; set; }
        public virtual DbSet<ad_ca_aircraft_type> ad_ca_aircraft_type { get; set; }
        public virtual DbSet<ad_ca_annotation_type> ad_ca_annotation_type { get; set; }
        public virtual DbSet<ad_ca_anzsic_industry_code> ad_ca_anzsic_industry_code { get; set; }
        public virtual DbSet<ad_ca_applicant_type> ad_ca_applicant_type { get; set; }
        public virtual DbSet<ad_ca_application_doc_type> ad_ca_application_doc_type { get; set; }
        public virtual DbSet<ad_ca_application_type> ad_ca_application_type { get; set; }
        public virtual DbSet<ad_ca_assessment_type_application_instructions_type> ad_ca_assessment_type_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_asset_transaction_type> ad_ca_asset_transaction_type { get; set; }
        public virtual DbSet<ad_ca_au_dialing_code> ad_ca_au_dialing_code { get; set; }
        public virtual DbSet<ad_ca_au_state_type> ad_ca_au_state_type { get; set; }
        public virtual DbSet<ad_ca_balloon_rv_input_pattern_type> ad_ca_balloon_rv_input_pattern_type { get; set; }
        public virtual DbSet<ad_ca_builder_type> ad_ca_builder_type { get; set; }
        public virtual DbSet<ad_ca_business_channel_type> ad_ca_business_channel_type { get; set; }
        public virtual DbSet<ad_ca_business_structure_excluding_trust_type> ad_ca_business_structure_excluding_trust_type { get; set; }
        public virtual DbSet<ad_ca_business_structure_full_type> ad_ca_business_structure_full_type { get; set; }
        public virtual DbSet<ad_ca_cleaning_equipment_type> ad_ca_cleaning_equipment_type { get; set; }
        public virtual DbSet<ad_ca_clearing_from_other_source_type> ad_ca_clearing_from_other_source_type { get; set; }
        public virtual DbSet<ad_ca_clearing_from_this_loan_type> ad_ca_clearing_from_this_loan_type { get; set; }
        public virtual DbSet<ad_ca_collateral_type> ad_ca_collateral_type { get; set; }
        public virtual DbSet<ad_ca_commercial_type> ad_ca_commercial_type { get; set; }
        public virtual DbSet<ad_ca_commission_structure_type> ad_ca_commission_structure_type { get; set; }
        public virtual DbSet<ad_ca_condition_owner_application_instructions_type> ad_ca_condition_owner_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_condition_status_application_instructions_type> ad_ca_condition_status_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_condition_type> ad_ca_condition_type { get; set; }
        public virtual DbSet<ad_ca_construction_type> ad_ca_construction_type { get; set; }
        public virtual DbSet<ad_ca_contact_email_type> ad_ca_contact_email_type { get; set; }
        public virtual DbSet<ad_ca_contribution_funds_type> ad_ca_contribution_funds_type { get; set; }
        public virtual DbSet<ad_ca_country_code> ad_ca_country_code { get; set; }
        public virtual DbSet<ad_ca_credit_card_type> ad_ca_credit_card_type { get; set; }
        public virtual DbSet<ad_ca_credit_history_issue_type> ad_ca_credit_history_issue_type { get; set; }
        public virtual DbSet<ad_ca_credit_reporting_body_type> ad_ca_credit_reporting_body_type { get; set; }
        public virtual DbSet<ad_ca_credit_status_type> ad_ca_credit_status_type { get; set; }
        public virtual DbSet<ad_ca_currency_code> ad_ca_currency_code { get; set; }
        public virtual DbSet<ad_ca_data_source_type> ad_ca_data_source_type { get; set; }
        public virtual DbSet<ad_ca_declined_reason_application_instructions_type> ad_ca_declined_reason_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_document_category_type> ad_ca_document_category_type { get; set; }
        public virtual DbSet<ad_ca_document_type> ad_ca_document_type { get; set; }
        public virtual DbSet<ad_ca_documentation_instructions_method_type> ad_ca_documentation_instructions_method_type { get; set; }
        public virtual DbSet<ad_ca_duration_units_type> ad_ca_duration_units_type { get; set; }
        public virtual DbSet<ad_ca_earth_moving_mining_and_construction_type> ad_ca_earth_moving_mining_and_construction_type { get; set; }
        public virtual DbSet<ad_ca_employer_type> ad_ca_employer_type { get; set; }
        public virtual DbSet<ad_ca_employment_status_type> ad_ca_employment_status_type { get; set; }
        public virtual DbSet<ad_ca_error_instructions_type> ad_ca_error_instructions_type { get; set; }
        public virtual DbSet<ad_ca_error_source_type> ad_ca_error_source_type { get; set; }
        public virtual DbSet<ad_ca_estimate_basis_non_real_estate_asset_type> ad_ca_estimate_basis_non_real_estate_asset_type { get; set; }
        public virtual DbSet<ad_ca_estimate_basis_real_estate_asset_type> ad_ca_estimate_basis_real_estate_asset_type { get; set; }
        public virtual DbSet<ad_ca_event_name_application_instructions_type> ad_ca_event_name_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_exempt_status_type> ad_ca_exempt_status_type { get; set; }
        public virtual DbSet<ad_ca_fee_category_type> ad_ca_fee_category_type { get; set; }
        public virtual DbSet<ad_ca_fee_type> ad_ca_fee_type { get; set; }
        public virtual DbSet<ad_ca_financial_asset_type> ad_ca_financial_asset_type { get; set; }
        public virtual DbSet<ad_ca_financial_institution_type> ad_ca_financial_institution_type { get; set; }
        public virtual DbSet<ad_ca_financial_transaction_type> ad_ca_financial_transaction_type { get; set; }
        public virtual DbSet<ad_ca_frequency_full_type> ad_ca_frequency_full_type { get; set; }
        public virtual DbSet<ad_ca_frequency_short_type> ad_ca_frequency_short_type { get; set; }
        public virtual DbSet<ad_ca_funder_type> ad_ca_funder_type { get; set; }
        public virtual DbSet<ad_ca_gender_type> ad_ca_gender_type { get; set; }
        public virtual DbSet<ad_ca_good_to_be_used_location_type> ad_ca_good_to_be_used_location_type { get; set; }
        public virtual DbSet<ad_ca_goods_delivery_type> ad_ca_goods_delivery_type { get; set; }
        public virtual DbSet<ad_ca_government_benefits_type> ad_ca_government_benefits_type { get; set; }
        public virtual DbSet<ad_ca_guarantor_access_type> ad_ca_guarantor_access_type { get; set; }
        public virtual DbSet<ad_ca_holding_type> ad_ca_holding_type { get; set; }
        public virtual DbSet<ad_ca_hospitality_and_leisure_type> ad_ca_hospitality_and_leisure_type { get; set; }
        public virtual DbSet<ad_ca_housing_status_type> ad_ca_housing_status_type { get; set; }
        public virtual DbSet<ad_ca_income_verification_type> ad_ca_income_verification_type { get; set; }
        public virtual DbSet<ad_ca_industrial_type> ad_ca_industrial_type { get; set; }
        public virtual DbSet<ad_ca_instalments_frequency_type> ad_ca_instalments_frequency_type { get; set; }
        public virtual DbSet<ad_ca_insurance_type> ad_ca_insurance_type { get; set; }
        public virtual DbSet<ad_ca_insurer_type> ad_ca_insurer_type { get; set; }
        public virtual DbSet<ad_ca_interest_type> ad_ca_interest_type { get; set; }
        public virtual DbSet<ad_ca_it_and_av_equipment_type> ad_ca_it_and_av_equipment_type { get; set; }
        public virtual DbSet<ad_ca_kin_relationship_type> ad_ca_kin_relationship_type { get; set; }
        public virtual DbSet<ad_ca_land_area_units_type> ad_ca_land_area_units_type { get; set; }
        public virtual DbSet<ad_ca_land_value_estimate_basis_type> ad_ca_land_value_estimate_basis_type { get; set; }
        public virtual DbSet<ad_ca_lending_guarantee_type> ad_ca_lending_guarantee_type { get; set; }
        public virtual DbSet<ad_ca_liability_type> ad_ca_liability_type { get; set; }
        public virtual DbSet<ad_ca_licence_type> ad_ca_licence_type { get; set; }
        public virtual DbSet<ad_ca_living_expense_category_type> ad_ca_living_expense_category_type { get; set; }
        public virtual DbSet<ad_ca_loan_term_units_type> ad_ca_loan_term_units_type { get; set; }
        public virtual DbSet<ad_ca_loan_type> ad_ca_loan_type { get; set; }
        public virtual DbSet<ad_ca_marital_status_type> ad_ca_marital_status_type { get; set; }
        public virtual DbSet<ad_ca_master_agreement_status_type> ad_ca_master_agreement_status_type { get; set; }
        public virtual DbSet<ad_ca_materials_handling_and_lifting_type> ad_ca_materials_handling_and_lifting_type { get; set; }
        public virtual DbSet<ad_ca_medical_equipment_type> ad_ca_medical_equipment_type { get; set; }
        public virtual DbSet<ad_ca_mitigant_factor_type> ad_ca_mitigant_factor_type { get; set; }
        public virtual DbSet<ad_ca_mm_month_type> ad_ca_mm_month_type { get; set; }
        public virtual DbSet<ad_ca_mobile_computing_type> ad_ca_mobile_computing_type { get; set; }
        public virtual DbSet<ad_ca_name_title_type> ad_ca_name_title_type { get; set; }
        public virtual DbSet<ad_ca_nccp_status_type> ad_ca_nccp_status_type { get; set; }
        public virtual DbSet<ad_ca_non_real_estate_asset_type> ad_ca_non_real_estate_asset_type { get; set; }
        public virtual DbSet<ad_ca_nras_consortium_type> ad_ca_nras_consortium_type { get; set; }
        public virtual DbSet<ad_ca_occupancy_type> ad_ca_occupancy_type { get; set; }
        public virtual DbSet<ad_ca_office_equipment_type> ad_ca_office_equipment_type { get; set; }
        public virtual DbSet<ad_ca_other_asset_type> ad_ca_other_asset_type { get; set; }
        public virtual DbSet<ad_ca_other_commitment_category_type> ad_ca_other_commitment_category_type { get; set; }
        public virtual DbSet<ad_ca_other_income_type> ad_ca_other_income_type { get; set; }
        public virtual DbSet<ad_ca_partner_type> ad_ca_partner_type { get; set; }
        public virtual DbSet<ad_ca_pay_fees_from_type> ad_ca_pay_fees_from_type { get; set; }
        public virtual DbSet<ad_ca_payg_basis_type> ad_ca_payg_basis_type { get; set; }
        public virtual DbSet<ad_ca_payment_timing_type> ad_ca_payment_timing_type { get; set; }
        public virtual DbSet<ad_ca_payment_type> ad_ca_payment_type { get; set; }
        public virtual DbSet<ad_ca_plan_type> ad_ca_plan_type { get; set; }
        public virtual DbSet<ad_ca_plant_equipment_and_industrial_type> ad_ca_plant_equipment_and_industrial_type { get; set; }
        public virtual DbSet<ad_ca_po_box_type> ad_ca_po_box_type { get; set; }
        public virtual DbSet<ad_ca_pool_type> ad_ca_pool_type { get; set; }
        public virtual DbSet<ad_ca_power_of_attorney_type> ad_ca_power_of_attorney_type { get; set; }
        public virtual DbSet<ad_ca_pre_condition_to_stage_application_instructions_type> ad_ca_pre_condition_to_stage_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_preferred_contact_company_type> ad_ca_preferred_contact_company_type { get; set; }
        public virtual DbSet<ad_ca_preferred_contact_person_type> ad_ca_preferred_contact_person_type { get; set; }
        public virtual DbSet<ad_ca_primary_purpose_loan_purpose_type> ad_ca_primary_purpose_loan_purpose_type { get; set; }
        public virtual DbSet<ad_ca_primary_purpose_real_estate_asset_type> ad_ca_primary_purpose_real_estate_asset_type { get; set; }
        public virtual DbSet<ad_ca_primary_usage_type> ad_ca_primary_usage_type { get; set; }
        public virtual DbSet<ad_ca_principal_refinancing_reason_type> ad_ca_principal_refinancing_reason_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_company_type> ad_ca_proof_code_company_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_not_employed_type> ad_ca_proof_code_not_employed_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_other_type> ad_ca_proof_code_other_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_payg_type> ad_ca_proof_code_payg_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_self_employed_type> ad_ca_proof_code_self_employed_type { get; set; }
        public virtual DbSet<ad_ca_proof_code_trust_type> ad_ca_proof_code_trust_type { get; set; }
        public virtual DbSet<ad_ca_proportions_type> ad_ca_proportions_type { get; set; }
        public virtual DbSet<ad_ca_proposed_repayment_method_type> ad_ca_proposed_repayment_method_type { get; set; }
        public virtual DbSet<ad_ca_real_estate_asset_status_type> ad_ca_real_estate_asset_status_type { get; set; }
        public virtual DbSet<ad_ca_registration_state_type> ad_ca_registration_state_type { get; set; }
        public virtual DbSet<ad_ca_release_security_reason_type> ad_ca_release_security_reason_type { get; set; }
        public virtual DbSet<ad_ca_repayment_frequency_type> ad_ca_repayment_frequency_type { get; set; }
        public virtual DbSet<ad_ca_residency_status_type> ad_ca_residency_status_type { get; set; }
        public virtual DbSet<ad_ca_residential_type> ad_ca_residential_type { get; set; }
        public virtual DbSet<ad_ca_rural_type> ad_ca_rural_type { get; set; }
        public virtual DbSet<ad_ca_rural_usage_type> ad_ca_rural_usage_type { get; set; }
        public virtual DbSet<ad_ca_security_priority_type> ad_ca_security_priority_type { get; set; }
        public virtual DbSet<ad_ca_self_employed_basis_type> ad_ca_self_employed_basis_type { get; set; }
        public virtual DbSet<ad_ca_send_documents_to_person_type> ad_ca_send_documents_to_person_type { get; set; }
        public virtual DbSet<ad_ca_send_documents_to_type> ad_ca_send_documents_to_type { get; set; }
        public virtual DbSet<ad_ca_share_type> ad_ca_share_type { get; set; }
        public virtual DbSet<ad_ca_significant_change_type> ad_ca_significant_change_type { get; set; }
        public virtual DbSet<ad_ca_statement_cycle_type> ad_ca_statement_cycle_type { get; set; }
        public virtual DbSet<ad_ca_status_name_application_instructions_type> ad_ca_status_name_application_instructions_type { get; set; }
        public virtual DbSet<ad_ca_street_suffix_type> ad_ca_street_suffix_type { get; set; }
        public virtual DbSet<ad_ca_street_type> ad_ca_street_type { get; set; }
        public virtual DbSet<ad_ca_supplier_type> ad_ca_supplier_type { get; set; }
        public virtual DbSet<ad_ca_surplus_funds_disbursement_method_type> ad_ca_surplus_funds_disbursement_method_type { get; set; }
        public virtual DbSet<ad_ca_tax_depreciation_method_type> ad_ca_tax_depreciation_method_type { get; set; }
        public virtual DbSet<ad_ca_tenure_type> ad_ca_tenure_type { get; set; }
        public virtual DbSet<ad_ca_title_system_type> ad_ca_title_system_type { get; set; }
        public virtual DbSet<ad_ca_tools_of_trade_type> ad_ca_tools_of_trade_type { get; set; }
        public virtual DbSet<ad_ca_total_term_type> ad_ca_total_term_type { get; set; }
        public virtual DbSet<ad_ca_trust_purpose_type> ad_ca_trust_purpose_type { get; set; }
        public virtual DbSet<ad_ca_trust_structure_type> ad_ca_trust_structure_type { get; set; }
        public virtual DbSet<ad_ca_type_of_incorporation_type> ad_ca_type_of_incorporation_type { get; set; }
        public virtual DbSet<ad_ca_valuation_program_type> ad_ca_valuation_program_type { get; set; }
        public virtual DbSet<ad_ca_variation_type> ad_ca_variation_type { get; set; }
        public virtual DbSet<ad_ca_vary_on_valuation_type> ad_ca_vary_on_valuation_type { get; set; }
        public virtual DbSet<ad_ca_vehicle_type> ad_ca_vehicle_type { get; set; }
        public virtual DbSet<ad_ca_visit_contact_type> ad_ca_visit_contact_type { get; set; }
        public virtual DbSet<ad_ca_yy_year_type> ad_ca_yy_year_type { get; set; }
        public virtual DbSet<ad_ch_submission_type> ad_ch_submission_type { get; set; }
        public virtual DbSet<ad_ed_account_type> ad_ed_account_type { get; set; }
        public virtual DbSet<ad_ed_application_accuracy_error_type> ad_ed_application_accuracy_error_type { get; set; }
        public virtual DbSet<ad_ed_application_cancel_reason_type> ad_ed_application_cancel_reason_type { get; set; }
        public virtual DbSet<ad_ed_case_status_type> ad_ed_case_status_type { get; set; }
        public virtual DbSet<ad_ed_credit_application_condition_type> ad_ed_credit_application_condition_type { get; set; }
        public virtual DbSet<ad_ed_credit_assessor_dla_type> ad_ed_credit_assessor_dla_type { get; set; }
        public virtual DbSet<ad_ed_credit_document_type> ad_ed_credit_document_type { get; set; }
        public virtual DbSet<ad_ed_discretion_reason_type> ad_ed_discretion_reason_type { get; set; }
        public virtual DbSet<ad_ed_employment_type> ad_ed_employment_type { get; set; }
        public virtual DbSet<ad_ed_institution_branch_type> ad_ed_institution_branch_type { get; set; }
        public virtual DbSet<ad_ed_institution_type> ad_ed_institution_type { get; set; }
        public virtual DbSet<ad_ed_insurance_classification_type> ad_ed_insurance_classification_type { get; set; }
        public virtual DbSet<ad_ed_insurance_cover_type> ad_ed_insurance_cover_type { get; set; }
        public virtual DbSet<ad_ed_insurance_how_paid_type> ad_ed_insurance_how_paid_type { get; set; }
        public virtual DbSet<ad_ed_lender_purpose_code> ad_ed_lender_purpose_code { get; set; }
        public virtual DbSet<ad_ed_member_class_type> ad_ed_member_class_type { get; set; }
        public virtual DbSet<ad_ed_member_type> ad_ed_member_type { get; set; }
        public virtual DbSet<ad_ed_not_employed_income_type> ad_ed_not_employed_income_type { get; set; }
        public virtual DbSet<ad_ed_override_reason_type> ad_ed_override_reason_type { get; set; }
        public virtual DbSet<ad_ed_payg_income_type> ad_ed_payg_income_type { get; set; }
        public virtual DbSet<ad_ed_property_type_name_type> ad_ed_property_type_name_type { get; set; }
        public virtual DbSet<ad_ed_registration_plate_type> ad_ed_registration_plate_type { get; set; }
        public virtual DbSet<ad_ed_self_employed_income_type> ad_ed_self_employed_income_type { get; set; }
        public virtual DbSet<ad_ed_veda_account_type> ad_ed_veda_account_type { get; set; }
        public virtual DbSet<ad_ed_veda_permission_type> ad_ed_veda_permission_type { get; set; }
        public virtual DbSet<ad_ed_veda_permission_type_scorecard> ad_ed_veda_permission_type_scorecard { get; set; }
        public virtual DbSet<ad_ed_veda_relationship_code> ad_ed_veda_relationship_code { get; set; }
        public virtual DbSet<ad_ed_vehicle_body_type> ad_ed_vehicle_body_type { get; set; }
        public virtual DbSet<ad_ed_vehicle_make_type> ad_ed_vehicle_make_type { get; set; }
        public virtual DbSet<ad_ed_workflow_interface_type> ad_ed_workflow_interface_type { get; set; }
        public virtual DbSet<ad_pd_product_type> ad_pd_product_type { get; set; }
        public virtual DbSet<ca_address> ca_address { get; set; }
        public virtual DbSet<ca_address_dx_box> ca_address_dx_box { get; set; }
        public virtual DbSet<ca_address_non_standard> ca_address_non_standard { get; set; }
        public virtual DbSet<ca_address_po_box> ca_address_po_box { get; set; }
        public virtual DbSet<ca_address_standard> ca_address_standard { get; set; }
        public virtual DbSet<ca_affordability> ca_affordability { get; set; }
        public virtual DbSet<ca_case_data> ca_case_data { get; set; }
        public virtual DbSet<ca_company_applicant> ca_company_applicant { get; set; }
        public virtual DbSet<ca_credit_application> ca_credit_application { get; set; }
        public virtual DbSet<ca_credit_application_conditions> ca_credit_application_conditions { get; set; }
        public virtual DbSet<ca_household> ca_household { get; set; }
        public virtual DbSet<ca_household_applicant> ca_household_applicant { get; set; }
        public virtual DbSet<ca_household_living_expense> ca_household_living_expense { get; set; }
        public virtual DbSet<ca_household_living_expense_percent_responsible_owner> ca_household_living_expense_percent_responsible_owner { get; set; }
        public virtual DbSet<ca_household_other_commitment> ca_household_other_commitment { get; set; }
        public virtual DbSet<ca_household_other_commitment_percent_responsible_owner> ca_household_other_commitment_percent_responsible_owner { get; set; }
        public virtual DbSet<ca_insurance> ca_insurance { get; set; }
        public virtual DbSet<ca_insurance_commission_payable> ca_insurance_commission_payable { get; set; }
        public virtual DbSet<ca_insurance_premium> ca_insurance_premium { get; set; }
        public virtual DbSet<ca_liability> ca_liability { get; set; }
        public virtual DbSet<ca_liability_account_number> ca_liability_account_number { get; set; }
        public virtual DbSet<ca_liability_account_performance> ca_liability_account_performance { get; set; }
        public virtual DbSet<ca_liability_percent_owned_owner> ca_liability_percent_owned_owner { get; set; }
        public virtual DbSet<ca_loan_details> ca_loan_details { get; set; }
        public virtual DbSet<ca_loan_details_lending_purpose> ca_loan_details_lending_purpose { get; set; }
        public virtual DbSet<ca_loan_details_loan_auto_decision> ca_loan_details_loan_auto_decision { get; set; }
        public virtual DbSet<ca_loan_details_loan_auto_decision_result> ca_loan_details_loan_auto_decision_result { get; set; }
        public virtual DbSet<ca_loan_details_loan_purpose> ca_loan_details_loan_purpose { get; set; }
        public virtual DbSet<ca_loan_details_loan_score_card> ca_loan_details_loan_score_card { get; set; }
        public virtual DbSet<ca_loan_details_loan_score_card_result> ca_loan_details_loan_score_card_result { get; set; }
        public virtual DbSet<ca_loan_details_percent_owned_owner> ca_loan_details_percent_owned_owner { get; set; }
        public virtual DbSet<ca_loan_details_proposed_repayment> ca_loan_details_proposed_repayment { get; set; }
        public virtual DbSet<ca_loan_details_term> ca_loan_details_term { get; set; }
        public virtual DbSet<ca_non_real_estate_asset> ca_non_real_estate_asset { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_estimated_value> ca_non_real_estate_asset_estimated_value { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_financial_asset> ca_non_real_estate_asset_financial_asset { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_financial_asset_account_number> ca_non_real_estate_asset_financial_asset_account_number { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_financial_asset_account_performance> ca_non_real_estate_asset_financial_asset_account_performance { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_financial_asset_shares> ca_non_real_estate_asset_financial_asset_shares { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_insurance> ca_non_real_estate_asset_insurance { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_motor_vehicle> ca_non_real_estate_asset_motor_vehicle { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_other_asset> ca_non_real_estate_asset_other_asset { get; set; }
        public virtual DbSet<ca_non_real_estate_asset_percent_owned_owner> ca_non_real_estate_asset_percent_owned_owner { get; set; }
        public virtual DbSet<ca_other_income> ca_other_income { get; set; }
        public virtual DbSet<ca_other_income_percent_owned_owner> ca_other_income_percent_owned_owner { get; set; }
        public virtual DbSet<ca_person_applicant> ca_person_applicant { get; set; }
        public virtual DbSet<ca_person_applicant_affordability> ca_person_applicant_affordability { get; set; }
        public virtual DbSet<ca_person_applicant_contact> ca_person_applicant_contact { get; set; }
        public virtual DbSet<ca_person_applicant_contact_current_address> ca_person_applicant_contact_current_address { get; set; }
        public virtual DbSet<ca_person_applicant_contact_email_address> ca_person_applicant_contact_email_address { get; set; }
        public virtual DbSet<ca_person_applicant_contact_home_phone> ca_person_applicant_contact_home_phone { get; set; }
        public virtual DbSet<ca_person_applicant_contact_mobile> ca_person_applicant_contact_mobile { get; set; }
        public virtual DbSet<ca_person_applicant_contact_previous_address> ca_person_applicant_contact_previous_address { get; set; }
        public virtual DbSet<ca_person_applicant_contact_work_phone> ca_person_applicant_contact_work_phone { get; set; }
        public virtual DbSet<ca_person_applicant_employment> ca_person_applicant_employment { get; set; }
        public virtual DbSet<ca_person_applicant_employment_not_employed> ca_person_applicant_employment_not_employed { get; set; }
        public virtual DbSet<ca_person_applicant_employment_payg> ca_person_applicant_employment_payg { get; set; }
        public virtual DbSet<ca_person_applicant_employment_self_employed> ca_person_applicant_employment_self_employed { get; set; }
        public virtual DbSet<ca_person_applicant_employment_self_employed_business> ca_person_applicant_employment_self_employed_business { get; set; }
        public virtual DbSet<ca_person_applicant_employment_self_employed_business_income_recent> ca_person_applicant_employment_self_employed_business_income_recent { get; set; }
        public virtual DbSet<ca_person_applicant_proof_of_identity> ca_person_applicant_proof_of_identity { get; set; }
        public virtual DbSet<ca_real_estate_asset> ca_real_estate_asset { get; set; }
        public virtual DbSet<ca_real_estate_asset_commercial> ca_real_estate_asset_commercial { get; set; }
        public virtual DbSet<ca_real_estate_asset_estimated_value> ca_real_estate_asset_estimated_value { get; set; }
        public virtual DbSet<ca_real_estate_asset_insurance> ca_real_estate_asset_insurance { get; set; }
        public virtual DbSet<ca_real_estate_asset_percent_owned_owner> ca_real_estate_asset_percent_owned_owner { get; set; }
        public virtual DbSet<ca_real_estate_asset_rental_income> ca_real_estate_asset_rental_income { get; set; }
        public virtual DbSet<ca_real_estate_asset_residential> ca_real_estate_asset_residential { get; set; }
        public virtual DbSet<ca_real_estate_asset_rural> ca_real_estate_asset_rural { get; set; }
        public virtual DbSet<ca_real_estate_asset_title> ca_real_estate_asset_title { get; set; }
        public virtual DbSet<ca_related_company> ca_related_company { get; set; }
        public virtual DbSet<ca_related_company_contact> ca_related_company_contact { get; set; }
        public virtual DbSet<ca_related_company_contact_contact_person> ca_related_company_contact_contact_person { get; set; }
        public virtual DbSet<ca_related_company_contact_office_fax> ca_related_company_contact_office_fax { get; set; }
        public virtual DbSet<ca_related_company_contact_office_phone> ca_related_company_contact_office_phone { get; set; }
        public virtual DbSet<ca_related_company_partner_percent_owned> ca_related_company_partner_percent_owned { get; set; }
        public virtual DbSet<ca_related_person> ca_related_person { get; set; }
        public virtual DbSet<ca_related_person_contact> ca_related_person_contact { get; set; }
        public virtual DbSet<ca_related_person_contact_home_phone> ca_related_person_contact_home_phone { get; set; }
        public virtual DbSet<ca_related_person_contact_mobile> ca_related_person_contact_mobile { get; set; }
        public virtual DbSet<ca_related_person_contact_work_phone> ca_related_person_contact_work_phone { get; set; }
        public virtual DbSet<ca_rule_execution_log> ca_rule_execution_log { get; set; }
        public virtual DbSet<ca_trust_applicant> ca_trust_applicant { get; set; }
        public virtual DbSet<ca_veda_fchk_resp> ca_veda_fchk_resp { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_bcaerror> ca_veda_fchk_resp_bcaerror { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_bcamessage> ca_veda_fchk_resp_bcamessage { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_bcaservice> ca_veda_fchk_resp_bcaservice { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_bcaservice_data> ca_veda_fchk_resp_bcaservice_data { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_bcaservices> ca_veda_fchk_resp_bcaservices { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_error> ca_veda_fchk_resp_error { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_report> ca_veda_fchk_resp_fchk_report { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_report_fchk_result> ca_veda_fchk_resp_fchk_report_fchk_result { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details> ca_veda_fchk_resp_fchk_result_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_addr> ca_veda_fchk_resp_fchk_result_details_addr { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_employer_phone_details> ca_veda_fchk_resp_fchk_result_details_employer_phone_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_employment> ca_veda_fchk_resp_fchk_result_details_employment { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details> ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_phone_details> ca_veda_fchk_resp_fchk_result_details_phone_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_referee_phone_details> ca_veda_fchk_resp_fchk_result_details_referee_phone_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_details_second_phone_details> ca_veda_fchk_resp_fchk_result_details_second_phone_details { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_fchk_result_summary> ca_veda_fchk_resp_fchk_result_summary { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_general_message> ca_veda_fchk_resp_general_message { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report> ca_veda_fchk_resp_vchk_report { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_drivers_licence_result> ca_veda_fchk_resp_vchk_report_drivers_licence_result { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_elect_roll_result> ca_veda_fchk_resp_vchk_report_elect_roll_result { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator> ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator> ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_phone_list_result> ca_veda_fchk_resp_vchk_report_phone_list_result { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator> ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator { get; set; }
        public virtual DbSet<ca_veda_fchk_resp_verification_suite_summary> ca_veda_fchk_resp_verification_suite_summary { get; set; }
        public virtual DbSet<ca_veda_vsa_resp> ca_veda_vsa_resp { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_data_block_characteristic> ca_veda_vsa_resp_data_block_characteristic { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info> ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_product_data> ca_veda_vsa_resp_product_data { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_product_data_enquiry_report> ca_veda_vsa_resp_product_data_enquiry_report { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_product_data_score_data> ca_veda_vsa_resp_product_data_score_data { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_product_data_summary_data> ca_veda_vsa_resp_product_data_summary_data { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency> ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_score_data_score> ca_veda_vsa_resp_score_data_score { get; set; }
        public virtual DbSet<ca_veda_vsa_resp_summary_data_data_block> ca_veda_vsa_resp_summary_data_data_block { get; set; }
        public virtual DbSet<ch_event> ch_event { get; set; }
        public virtual DbSet<ch_event_product> ch_event_product { get; set; }
        public virtual DbSet<ch_process> ch_process { get; set; }
        public virtual DbSet<ch_submission> ch_submission { get; set; }
        public virtual DbSet<in_global_interface_log> in_global_interface_log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ad_ca_abs_lending_purpose_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_abs_lending_purpose_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_abs_lending_purpose_code>()
                .HasMany(e => e.ca_loan_details_lending_purpose)
                .WithOptional(e => e.ad_ca_abs_lending_purpose_code)
                .HasForeignKey(e => e.abs_lending_purpose_code);

            modelBuilder.Entity<ad_ca_abs_occupation_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_abs_occupation_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_abs_occupation_code>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_abs_occupation_code>()
                .HasMany(e => e.ca_person_applicant_employment_payg)
                .WithOptional(e => e.ad_ca_abs_occupation_code)
                .HasForeignKey(e => e.abs_occupation_code);

            modelBuilder.Entity<ad_ca_abs_occupation_code>()
                .HasMany(e => e.ca_person_applicant_employment_self_employed)
                .WithOptional(e => e.ad_ca_abs_occupation_code)
                .HasForeignKey(e => e.abs_occupation_code);

            modelBuilder.Entity<ad_ca_address_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_address_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_address_type>()
                .HasMany(e => e.ca_address)
                .WithOptional(e => e.ad_ca_address_type)
                .HasForeignKey(e => e.address_type);

            modelBuilder.Entity<ad_ca_agricultural_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_agricultural_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_aircraft_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_aircraft_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_annotation_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_annotation_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_anzsic_industry_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_anzsic_industry_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_applicant_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_applicant_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_applicant_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_applicant_type>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ca_applicant_type)
                .HasForeignKey(e => e.applicant_type);

            modelBuilder.Entity<ad_ca_application_doc_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_application_doc_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_application_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_application_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_assessment_type_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_assessment_type_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_asset_transaction_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_asset_transaction_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_asset_transaction_type>()
                .HasMany(e => e.ca_non_real_estate_asset)
                .WithOptional(e => e.ad_ca_asset_transaction_type)
                .HasForeignKey(e => e.asset_transaction_type);

            modelBuilder.Entity<ad_ca_asset_transaction_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_asset_transaction_type)
                .HasForeignKey(e => e.asset_transaction_type);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_person_applicant_contact_home_phone)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_person_applicant_contact_mobile)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_person_applicant_contact_work_phone)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_related_company_contact_office_fax)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_related_company_contact_office_phone)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_related_person_contact_home_phone)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_related_person_contact_mobile)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_dialing_code>()
                .HasMany(e => e.ca_related_person_contact_work_phone)
                .WithOptional(e => e.ad_ca_au_dialing_code)
                .HasForeignKey(e => e.au_dialing_code);

            modelBuilder.Entity<ad_ca_au_state_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_state_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_state_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_state_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_au_state_type>()
                .HasMany(e => e.ca_address)
                .WithOptional(e => e.ad_ca_au_state_type)
                .HasForeignKey(e => e.au_state_type);

            modelBuilder.Entity<ad_ca_balloon_rv_input_pattern_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_balloon_rv_input_pattern_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_balloon_rv_input_pattern_type>()
                .HasMany(e => e.ca_non_real_estate_asset_estimated_value)
                .WithOptional(e => e.ad_ca_balloon_rv_input_pattern_type)
                .HasForeignKey(e => e.balloon_rv_input_pattern_type);

            modelBuilder.Entity<ad_ca_builder_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_builder_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_channel_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_channel_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_structure_excluding_trust_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_structure_excluding_trust_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_structure_full_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_structure_full_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_business_structure_full_type>()
                .HasMany(e => e.ca_related_company)
                .WithOptional(e => e.ad_ca_business_structure_full_type)
                .HasForeignKey(e => e.business_structure_full_type);

            modelBuilder.Entity<ad_ca_cleaning_equipment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_cleaning_equipment_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_clearing_from_other_source_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_clearing_from_other_source_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_clearing_from_this_loan_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_clearing_from_this_loan_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_collateral_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_collateral_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_commercial_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_commercial_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_commercial_type>()
                .HasMany(e => e.ca_real_estate_asset_commercial)
                .WithOptional(e => e.ad_ca_commercial_type)
                .HasForeignKey(e => e.commercial_type);

            modelBuilder.Entity<ad_ca_commission_structure_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_commission_structure_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_owner_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_owner_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_status_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_status_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_condition_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ca_condition_type)
                .HasForeignKey(e => e.condition_type);

            modelBuilder.Entity<ad_ca_construction_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_construction_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_contact_email_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_contact_email_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_contact_email_type>()
                .HasMany(e => e.ca_person_applicant_contact_email_address)
                .WithOptional(e => e.ad_ca_contact_email_type)
                .HasForeignKey(e => e.contact_email_type);

            modelBuilder.Entity<ad_ca_contact_email_type>()
                .HasMany(e => e.ca_related_person_contact)
                .WithOptional(e => e.ad_ca_contact_email_type)
                .HasForeignKey(e => e.contact_email_type);

            modelBuilder.Entity<ad_ca_contribution_funds_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_contribution_funds_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.veda_score_apply_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .Property(e => e.veda_fraud_check_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_country_code>()
                .HasMany(e => e.ca_address)
                .WithOptional(e => e.ad_ca_country_code)
                .HasForeignKey(e => e.country_code);

            modelBuilder.Entity<ad_ca_country_code>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_country_code)
                .HasForeignKey(e => e.country_code);

            modelBuilder.Entity<ad_ca_country_code>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ca_country_code)
                .HasForeignKey(e => e.principal_foreign_residence_type);

            modelBuilder.Entity<ad_ca_country_code>()
                .HasMany(e => e.ca_related_company)
                .WithOptional(e => e.ad_ca_country_code)
                .HasForeignKey(e => e.registered_in_country_code);

            modelBuilder.Entity<ad_ca_credit_card_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_card_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_card_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_history_issue_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_history_issue_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_reporting_body_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_reporting_body_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_credit_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_currency_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_currency_code>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_data_source_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_data_source_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_data_source_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_data_source_type)
                .HasForeignKey(e => e.data_source_type);

            modelBuilder.Entity<ad_ca_declined_reason_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_declined_reason_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_document_category_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_document_category_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_document_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_document_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_document_type>()
                .HasMany(e => e.ca_person_applicant_proof_of_identity)
                .WithOptional(e => e.ad_ca_document_type)
                .HasForeignKey(e => e.document_type);

            modelBuilder.Entity<ad_ca_documentation_instructions_method_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_documentation_instructions_method_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_duration_units_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_duration_units_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_earth_moving_mining_and_construction_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_earth_moving_mining_and_construction_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employer_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employer_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .HasMany(e => e.ca_person_applicant_employment_not_employed)
                .WithOptional(e => e.ad_ca_employment_status_type)
                .HasForeignKey(e => e.employment_status_type);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .HasMany(e => e.ca_person_applicant_employment_payg)
                .WithOptional(e => e.ad_ca_employment_status_type)
                .HasForeignKey(e => e.employment_status_type);

            modelBuilder.Entity<ad_ca_employment_status_type>()
                .HasMany(e => e.ca_person_applicant_employment_self_employed)
                .WithOptional(e => e.ad_ca_employment_status_type)
                .HasForeignKey(e => e.employment_status_type);

            modelBuilder.Entity<ad_ca_error_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_error_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_error_source_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_error_source_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_estimate_basis_non_real_estate_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_estimate_basis_non_real_estate_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_estimate_basis_non_real_estate_asset_type>()
                .HasMany(e => e.ca_non_real_estate_asset_estimated_value)
                .WithOptional(e => e.ad_ca_estimate_basis_non_real_estate_asset_type)
                .HasForeignKey(e => e.estimate_basis_non_real_estate_asset_type);

            modelBuilder.Entity<ad_ca_estimate_basis_real_estate_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_estimate_basis_real_estate_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_estimate_basis_real_estate_asset_type>()
                .HasMany(e => e.ca_real_estate_asset_estimated_value)
                .WithOptional(e => e.ad_ca_estimate_basis_real_estate_asset_type)
                .HasForeignKey(e => e.estimate_basis_real_estate_asset_type);

            modelBuilder.Entity<ad_ca_event_name_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_event_name_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_exempt_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_exempt_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_fee_category_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_fee_category_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_fee_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_fee_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_asset_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_asset_type>()
                .HasMany(e => e.ca_non_real_estate_asset_financial_asset)
                .WithOptional(e => e.ad_ca_financial_asset_type)
                .HasForeignKey(e => e.financial_asset_type);

            modelBuilder.Entity<ad_ca_financial_institution_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_institution_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_institution_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_institution_type>()
                .HasMany(e => e.ca_liability_account_number)
                .WithOptional(e => e.ad_ca_financial_institution_type)
                .HasForeignKey(e => e.financial_institution_type);

            modelBuilder.Entity<ad_ca_financial_institution_type>()
                .HasMany(e => e.ca_non_real_estate_asset_financial_asset_account_number)
                .WithOptional(e => e.ad_ca_financial_institution_type)
                .HasForeignKey(e => e.financial_institution_type);

            modelBuilder.Entity<ad_ca_financial_transaction_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_transaction_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_financial_transaction_type>()
                .HasMany(e => e.ca_non_real_estate_asset)
                .WithOptional(e => e.ad_ca_financial_transaction_type)
                .HasForeignKey(e => e.financial_transaction_type);

            modelBuilder.Entity<ad_ca_frequency_full_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_frequency_full_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_frequency_full_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_frequency_full_type>()
                .Property(e => e.monthly_conversion)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ad_ca_frequency_full_type>()
                .HasMany(e => e.ca_loan_details_proposed_repayment)
                .WithOptional(e => e.ad_ca_frequency_full_type)
                .HasForeignKey(e => e.regular_repayment_frequency_full_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .Property(e => e.monthly_conversion)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_household_living_expense)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_household_other_commitment)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_insurance_premium)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_person_applicant_employment_not_employed)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.income_other_income_frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_person_applicant_employment_not_employed1)
                .WithOptional(e => e.ad_ca_frequency_short_type1)
                .HasForeignKey(e => e.income_private_pension_frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_person_applicant_employment_not_employed2)
                .WithOptional(e => e.ad_ca_frequency_short_type2)
                .HasForeignKey(e => e.income_superannuation_frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_person_applicant_employment_payg)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.income_gross_salary_frequency_short_type);

            modelBuilder.Entity<ad_ca_frequency_short_type>()
                .HasMany(e => e.ca_real_estate_asset_rental_income)
                .WithOptional(e => e.ad_ca_frequency_short_type)
                .HasForeignKey(e => e.frequency_short_type);

            modelBuilder.Entity<ad_ca_funder_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_funder_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.veda_fraud_check_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .Property(e => e.veda_score_apply_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_gender_type>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ca_gender_type)
                .HasForeignKey(e => e.gender_type);

            modelBuilder.Entity<ad_ca_good_to_be_used_location_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_good_to_be_used_location_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_goods_delivery_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_goods_delivery_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_government_benefits_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_government_benefits_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_government_benefits_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_government_benefits_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_government_benefits_type)
                .HasForeignKey(e => e.government_benefits_type);

            modelBuilder.Entity<ad_ca_guarantor_access_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_guarantor_access_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_holding_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_holding_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_holding_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_holding_type)
                .HasForeignKey(e => e.holding_type);

            modelBuilder.Entity<ad_ca_hospitality_and_leisure_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_hospitality_and_leisure_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_housing_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_housing_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_housing_status_type>()
                .HasMany(e => e.ca_person_applicant_contact_current_address)
                .WithOptional(e => e.ad_ca_housing_status_type)
                .HasForeignKey(e => e.housing_status_type);

            modelBuilder.Entity<ad_ca_housing_status_type>()
                .HasMany(e => e.ca_person_applicant_contact_previous_address)
                .WithOptional(e => e.ad_ca_housing_status_type)
                .HasForeignKey(e => e.housing_status_type);

            modelBuilder.Entity<ad_ca_income_verification_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_income_verification_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_income_verification_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_income_verification_type)
                .HasForeignKey(e => e.income_verification_type);

            modelBuilder.Entity<ad_ca_industrial_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_industrial_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_instalments_frequency_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_instalments_frequency_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_insurance_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_insurance_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_insurance_type>()
                .HasMany(e => e.ca_insurance)
                .WithOptional(e => e.ad_ca_insurance_type)
                .HasForeignKey(e => e.insurance_type);

            modelBuilder.Entity<ad_ca_insurer_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_insurer_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_insurer_type>()
                .HasMany(e => e.ca_insurance)
                .WithOptional(e => e.ad_ca_insurer_type)
                .HasForeignKey(e => e.insurer_type);

            modelBuilder.Entity<ad_ca_interest_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_interest_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_it_and_av_equipment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_it_and_av_equipment_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_kin_relationship_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_kin_relationship_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_land_area_units_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_land_area_units_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_land_value_estimate_basis_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_land_value_estimate_basis_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_lending_guarantee_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_lending_guarantee_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.core_application_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.core_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .Property(e => e.core_overdraft_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_liability_type>()
                .HasMany(e => e.ca_liability)
                .WithOptional(e => e.ad_ca_liability_type)
                .HasForeignKey(e => e.liability_type);

            modelBuilder.Entity<ad_ca_licence_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_licence_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_living_expense_category_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_living_expense_category_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_living_expense_category_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_living_expense_category_type>()
                .HasMany(e => e.ca_household_living_expense)
                .WithOptional(e => e.ad_ca_living_expense_category_type)
                .HasForeignKey(e => e.living_expense_category_type);

            modelBuilder.Entity<ad_ca_loan_term_units_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_term_units_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_term_units_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_term_units_type>()
                .HasMany(e => e.ca_liability)
                .WithOptional(e => e.ad_ca_loan_term_units_type)
                .HasForeignKey(e => e.remaining_term_loan_term_units_type);

            modelBuilder.Entity<ad_ca_loan_term_units_type>()
                .HasMany(e => e.ca_loan_details_term)
                .WithOptional(e => e.ad_ca_loan_term_units_type)
                .HasForeignKey(e => e.total_term_loan_term_units_type);

            modelBuilder.Entity<ad_ca_loan_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_loan_type>()
                .HasMany(e => e.ca_loan_details)
                .WithOptional(e => e.ad_ca_loan_type)
                .HasForeignKey(e => e.loan_type);

            modelBuilder.Entity<ad_ca_marital_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_marital_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_marital_status_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_marital_status_type>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ca_marital_status_type)
                .HasForeignKey(e => e.marital_status_type);

            modelBuilder.Entity<ad_ca_master_agreement_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_master_agreement_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_materials_handling_and_lifting_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_materials_handling_and_lifting_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_medical_equipment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_medical_equipment_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mitigant_factor_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mitigant_factor_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mm_month_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mm_month_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mobile_computing_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_mobile_computing_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ca_name_title_type)
                .HasForeignKey(e => e.person_name_name_title_type);

            modelBuilder.Entity<ad_ca_name_title_type>()
                .HasMany(e => e.ca_related_person)
                .WithOptional(e => e.ad_ca_name_title_type)
                .HasForeignKey(e => e.person_name_name_title_type);

            modelBuilder.Entity<ad_ca_nccp_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_nccp_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_non_real_estate_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_non_real_estate_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_non_real_estate_asset_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_non_real_estate_asset_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_non_real_estate_asset_type>()
                .HasMany(e => e.ca_non_real_estate_asset)
                .WithOptional(e => e.ad_ca_non_real_estate_asset_type)
                .HasForeignKey(e => e.non_real_estate_asset_type);

            modelBuilder.Entity<ad_ca_nras_consortium_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_nras_consortium_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_nras_consortium_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_nras_consortium_type)
                .HasForeignKey(e => e.nras_consortium_type);

            modelBuilder.Entity<ad_ca_occupancy_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_occupancy_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_occupancy_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_occupancy_type)
                .HasForeignKey(e => e.occupancy_type);

            modelBuilder.Entity<ad_ca_office_equipment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_office_equipment_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_asset_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_asset_type>()
                .HasMany(e => e.ca_non_real_estate_asset_other_asset)
                .WithOptional(e => e.ad_ca_other_asset_type)
                .HasForeignKey(e => e.other_asset_type);

            modelBuilder.Entity<ad_ca_other_commitment_category_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_commitment_category_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_commitment_category_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_other_commitment_category_type>()
                .HasMany(e => e.ca_household_other_commitment)
                .WithOptional(e => e.ad_ca_other_commitment_category_type)
                .HasForeignKey(e => e.other_commitment_category_type);

            modelBuilder.Entity<ad_ca_other_income_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_income_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_income_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_other_income_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_other_income_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_other_income_type)
                .HasForeignKey(e => e.other_income_type);

            modelBuilder.Entity<ad_ca_partner_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_partner_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_partner_type>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithOptional(e => e.ad_ca_partner_type)
                .HasForeignKey(e => e.partner_type);

            modelBuilder.Entity<ad_ca_pay_fees_from_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_pay_fees_from_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payg_basis_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payg_basis_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payg_basis_type>()
                .HasMany(e => e.ca_person_applicant_employment_payg)
                .WithOptional(e => e.ad_ca_payg_basis_type)
                .HasForeignKey(e => e.payg_basis_type);

            modelBuilder.Entity<ad_ca_payment_timing_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payment_timing_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payment_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_payment_type>()
                .HasMany(e => e.ca_liability)
                .WithOptional(e => e.ad_ca_payment_type)
                .HasForeignKey(e => e.repayment_payment_type);

            modelBuilder.Entity<ad_ca_plan_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_plan_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_plan_type>()
                .HasMany(e => e.ca_real_estate_asset_title)
                .WithOptional(e => e.ad_ca_plan_type)
                .HasForeignKey(e => e.plan_type);

            modelBuilder.Entity<ad_ca_plant_equipment_and_industrial_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_plant_equipment_and_industrial_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_po_box_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_po_box_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_po_box_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_po_box_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_po_box_type>()
                .HasMany(e => e.ca_address_po_box)
                .WithOptional(e => e.ad_ca_po_box_type)
                .HasForeignKey(e => e.po_box_type);

            modelBuilder.Entity<ad_ca_pool_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_pool_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_power_of_attorney_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_power_of_attorney_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_pre_condition_to_stage_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_pre_condition_to_stage_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_preferred_contact_company_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_preferred_contact_company_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_preferred_contact_person_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_preferred_contact_person_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_preferred_contact_person_type>()
                .HasMany(e => e.ca_person_applicant_contact)
                .WithOptional(e => e.ad_ca_preferred_contact_person_type)
                .HasForeignKey(e => e.preferred_contact_person_type);

            modelBuilder.Entity<ad_ca_preferred_contact_person_type>()
                .HasMany(e => e.ca_related_person_contact)
                .WithOptional(e => e.ad_ca_preferred_contact_person_type)
                .HasForeignKey(e => e.preferred_contact_person_type);

            modelBuilder.Entity<ad_ca_primary_purpose_loan_purpose_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_purpose_loan_purpose_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_purpose_loan_purpose_type>()
                .HasMany(e => e.ca_loan_details_loan_purpose)
                .WithOptional(e => e.ad_ca_primary_purpose_loan_purpose_type)
                .HasForeignKey(e => e.primary_purpose_loan_purpose_type);

            modelBuilder.Entity<ad_ca_primary_purpose_real_estate_asset_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_purpose_real_estate_asset_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_purpose_real_estate_asset_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_primary_purpose_real_estate_asset_type)
                .HasForeignKey(e => e.primary_purpose_real_estate_asset_type);

            modelBuilder.Entity<ad_ca_primary_usage_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_usage_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_primary_usage_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_primary_usage_type>()
                .Property(e => e.rental_income_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ca_primary_usage_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_primary_usage_type)
                .HasForeignKey(e => e.primary_usage_type);

            modelBuilder.Entity<ad_ca_principal_refinancing_reason_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_principal_refinancing_reason_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_company_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_company_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_not_employed_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_not_employed_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_other_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_other_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_other_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_proof_code_other_type)
                .HasForeignKey(e => e.proof_code_other_type);

            modelBuilder.Entity<ad_ca_proof_code_payg_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_payg_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_self_employed_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_self_employed_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_trust_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proof_code_trust_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_household_living_expense)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_responsible_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_household_other_commitment)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_responsible_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_liability)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_owned_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_loan_details)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_owned_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_non_real_estate_asset)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_owned_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_other_income)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_owned_proportions_type);

            modelBuilder.Entity<ad_ca_proportions_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_proportions_type)
                .HasForeignKey(e => e.percent_owned_proportions_type);

            modelBuilder.Entity<ad_ca_proposed_repayment_method_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_proposed_repayment_method_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_real_estate_asset_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_real_estate_asset_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_real_estate_asset_status_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_real_estate_asset_status_type)
                .HasForeignKey(e => e.real_estate_asset_status_type);

            modelBuilder.Entity<ad_ca_registration_state_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_registration_state_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_registration_state_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ca_registration_state_type)
                .HasForeignKey(e => e.registration_state_type);

            modelBuilder.Entity<ad_ca_release_security_reason_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_release_security_reason_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .Property(e => e.monthly_conversion)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .HasMany(e => e.ca_liability)
                .WithOptional(e => e.ad_ca_repayment_frequency_type)
                .HasForeignKey(e => e.repayment_frequency_type);

            modelBuilder.Entity<ad_ca_repayment_frequency_type>()
                .HasMany(e => e.ca_liability1)
                .WithOptional(e => e.ad_ca_repayment_frequency_type1)
                .HasForeignKey(e => e.ed_interest_only_repayment_frequency_type);

            modelBuilder.Entity<ad_ca_residency_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_residency_status_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_residential_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_residential_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_residential_type>()
                .HasMany(e => e.ca_real_estate_asset_residential)
                .WithOptional(e => e.ad_ca_residential_type)
                .HasForeignKey(e => e.residential_type);

            modelBuilder.Entity<ad_ca_rural_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_rural_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_rural_type>()
                .HasMany(e => e.ca_real_estate_asset_rural)
                .WithOptional(e => e.ad_ca_rural_type)
                .HasForeignKey(e => e.rural_type);

            modelBuilder.Entity<ad_ca_rural_usage_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_rural_usage_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_rural_usage_type>()
                .HasMany(e => e.ca_real_estate_asset_rural)
                .WithOptional(e => e.ad_ca_rural_usage_type)
                .HasForeignKey(e => e.rural_usage_type);

            modelBuilder.Entity<ad_ca_security_priority_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_security_priority_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_self_employed_basis_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_self_employed_basis_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_self_employed_basis_type>()
                .HasMany(e => e.ca_person_applicant_employment_self_employed)
                .WithOptional(e => e.ad_ca_self_employed_basis_type)
                .HasForeignKey(e => e.self_employed_basis_type);

            modelBuilder.Entity<ad_ca_send_documents_to_person_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_send_documents_to_person_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_send_documents_to_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_send_documents_to_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_share_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_share_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_share_type>()
                .HasMany(e => e.ca_non_real_estate_asset_financial_asset_shares)
                .WithOptional(e => e.ad_ca_share_type)
                .HasForeignKey(e => e.share_type);

            modelBuilder.Entity<ad_ca_significant_change_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_significant_change_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_statement_cycle_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_statement_cycle_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_status_name_application_instructions_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_status_name_application_instructions_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_status_name_application_instructions_type>()
                .HasMany(e => e.ca_loan_details)
                .WithOptional(e => e.ad_ca_status_name_application_instructions_type)
                .HasForeignKey(e => e.ed_auto_decision_status);

            modelBuilder.Entity<ad_ca_status_name_application_instructions_type>()
                .HasMany(e => e.ca_loan_details_loan_auto_decision_result)
                .WithOptional(e => e.ad_ca_status_name_application_instructions_type)
                .HasForeignKey(e => e.ed_auto_decision_status);

            modelBuilder.Entity<ad_ca_street_suffix_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_suffix_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_suffix_type>()
                .HasMany(e => e.ca_address_standard)
                .WithOptional(e => e.ad_ca_street_suffix_type)
                .HasForeignKey(e => e.street_suffix_type);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.veda_score_apply_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .Property(e => e.veda_fraud_check_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_street_type>()
                .HasMany(e => e.ca_address_standard)
                .WithOptional(e => e.ad_ca_street_type)
                .HasForeignKey(e => e.street_type);

            modelBuilder.Entity<ad_ca_supplier_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_supplier_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_surplus_funds_disbursement_method_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_surplus_funds_disbursement_method_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tax_depreciation_method_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tax_depreciation_method_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tax_depreciation_method_type>()
                .HasMany(e => e.ca_non_real_estate_asset_estimated_value)
                .WithOptional(e => e.ad_ca_tax_depreciation_method_type)
                .HasForeignKey(e => e.tax_depreciation_method_type);

            modelBuilder.Entity<ad_ca_tenure_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tenure_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tenure_type>()
                .HasMany(e => e.ca_real_estate_asset_title)
                .WithOptional(e => e.ad_ca_tenure_type)
                .HasForeignKey(e => e.tenure_type);

            modelBuilder.Entity<ad_ca_title_system_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_title_system_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_title_system_type>()
                .HasMany(e => e.ca_real_estate_asset_title)
                .WithOptional(e => e.ad_ca_title_system_type)
                .HasForeignKey(e => e.title_system_type);

            modelBuilder.Entity<ad_ca_tools_of_trade_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_tools_of_trade_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_total_term_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_total_term_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_trust_purpose_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_trust_purpose_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_trust_structure_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_trust_structure_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_type_of_incorporation_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_type_of_incorporation_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_valuation_program_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_valuation_program_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_valuation_program_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ca_valuation_program_type)
                .HasForeignKey(e => e.valuation_program_type);

            modelBuilder.Entity<ad_ca_variation_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_variation_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_vary_on_valuation_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_vary_on_valuation_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_vehicle_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_vehicle_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_vehicle_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ca_vehicle_type)
                .HasForeignKey(e => e.vehicle_type);

            modelBuilder.Entity<ad_ca_visit_contact_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_visit_contact_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_yy_year_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ca_yy_year_type>()
                .Property(e => e.lixi_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.product_id)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.system)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.received_schema_format)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.target_schema_format)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.target_endpoint_url)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ch_submission_type>()
                .Property(e => e.target_endpoint_operation)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_account_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_account_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_account_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_account_type>()
                .Property(e => e.core_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_account_type>()
                .HasMany(e => e.ca_non_real_estate_asset_financial_asset_account_number)
                .WithOptional(e => e.ad_ed_account_type)
                .HasForeignKey(e => e.ed_account_type);

            modelBuilder.Entity<ad_ed_application_accuracy_error_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_application_cancel_reason_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_case_status_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_case_status_type>()
                .Property(e => e.lending_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_case_status_type>()
                .HasMany(e => e.ca_case_data)
                .WithOptional(e => e.ad_ed_case_status_type)
                .HasForeignKey(e => e.ed_case_status_type);

            modelBuilder.Entity<ad_ed_credit_application_condition_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_credit_application_condition_type>()
                .HasMany(e => e.ca_credit_application_conditions)
                .WithOptional(e => e.ad_ed_credit_application_condition_type)
                .HasForeignKey(e => e.ed_credit_application_condition_type);

            modelBuilder.Entity<ad_ed_credit_assessor_dla_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_credit_document_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_credit_document_type>()
                .Property(e => e.lending_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_credit_document_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_credit_document_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_discretion_reason_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_employment_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_employment_type>()
                .HasMany(e => e.ca_person_applicant_employment)
                .WithOptional(e => e.ad_ed_employment_type)
                .HasForeignKey(e => e.ed_employment_type);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.bsb)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.care_of_details)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.box_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.box_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.building_name)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.street_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.street_name)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.street_suffix_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.street_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.suburb)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.post_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_branch_type>()
                .Property(e => e.fax_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.case_prefix)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.care_of_details)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.box_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.box_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.building_name)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.street_number)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.street_name)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.street_suffix_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.street_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.suburb)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.post_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_institution_type>()
                .HasMany(e => e.ca_case_data)
                .WithOptional(e => e.ad_ed_institution_type)
                .HasForeignKey(e => e.ed_institution_type);

            modelBuilder.Entity<ad_ed_insurance_classification_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_insurance_cover_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_insurance_how_paid_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_insurance_how_paid_type>()
                .HasMany(e => e.ca_insurance)
                .WithOptional(e => e.ad_ed_insurance_how_paid_type)
                .HasForeignKey(e => e.insurance_how_paid_type);

            modelBuilder.Entity<ad_ed_lender_purpose_code>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_lender_purpose_code>()
                .HasMany(e => e.ca_loan_details_lending_purpose)
                .WithOptional(e => e.ad_ed_lender_purpose_code)
                .HasForeignKey(e => e.lender_code);

            modelBuilder.Entity<ad_ed_member_class_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_member_class_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_member_class_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_member_class_type>()
                .HasMany(e => e.ca_person_applicant)
                .WithOptional(e => e.ad_ed_member_class_type)
                .HasForeignKey(e => e.ed_existing_customer_member_class_type);

            modelBuilder.Entity<ad_ed_member_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_not_employed_income_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_not_employed_income_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ed_override_reason_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_payg_income_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_payg_income_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ed_property_type_name_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_property_type_name_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_property_type_name_type>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ad_ed_property_type_name_type)
                .HasForeignKey(e => e.property_type_name_type);

            modelBuilder.Entity<ad_ed_registration_plate_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_registration_plate_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ed_registration_plate_type)
                .HasForeignKey(e => e.ed_registration_plate_type);

            modelBuilder.Entity<ad_ed_self_employed_income_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_self_employed_income_type>()
                .Property(e => e.percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_ed_veda_account_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_account_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type>()
                .Property(e => e.data_level)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type_scorecard>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type_scorecard>()
                .Property(e => e.data_level)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_permission_type_scorecard>()
                .Property(e => e.scorecard_id)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_relationship_code>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_veda_relationship_code>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_body_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_body_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ed_vehicle_body_type)
                .HasForeignKey(e => e.vehicle_body_type);

            modelBuilder.Entity<ad_ed_vehicle_make_type>()
                .Property(e => e.core_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_make_type>()
                .Property(e => e.core_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_make_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_make_type>()
                .Property(e => e.symtrix_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_ed_vehicle_make_type>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ad_ed_vehicle_make_type)
                .HasForeignKey(e => e.vehicle_make_type);

            modelBuilder.Entity<ad_ed_workflow_interface_type>()
                .Property(e => e.lending_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.product_description)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.annual_interest_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_deposit_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_deposit_class_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_loan_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_loan_class_code)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_capitalized_period)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_insurance_company)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_insurance_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.min_loan_details_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.max_loan_details_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.cash_advance_interest_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_advance)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_loan_period)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_late_assess_method)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .Property(e => e.core_payment_type)
                .IsUnicode(false);

            modelBuilder.Entity<ad_pd_product_type>()
                .HasMany(e => e.ca_loan_details)
                .WithOptional(e => e.ad_pd_product_type)
                .HasForeignKey(e => e.ed_product_type);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.ed_care_of_details)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.au_post_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.gnaf_id)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.latitude)
                .HasPrecision(9, 6);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.lga_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.longitude)
                .HasPrecision(9, 6);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.overseas_post_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.overseas_state)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.suburb)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.ed_formatted_address_line_1)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.ed_formatted_address_line_2)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .Property(e => e.ed_formatted_address_line_3)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address>()
                .HasOptional(e => e.ca_address_dx_box)
                .WithRequired(e => e.ca_address)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_address>()
                .HasOptional(e => e.ca_address_non_standard)
                .WithRequired(e => e.ca_address)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_address>()
                .HasOptional(e => e.ca_address_po_box)
                .WithRequired(e => e.ca_address)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_address>()
                .HasOptional(e => e.ca_address_standard)
                .WithRequired(e => e.ca_address)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.good_to_be_used_address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_person_applicant_contact_current_address)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.mailing_address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_person_applicant_contact_current_address1)
                .WithOptional(e => e.ca_address1)
                .HasForeignKey(e => e.residential_address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_person_applicant_contact_previous_address)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.residential_address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_real_estate_asset)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_related_company_contact)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.address_ca_address_id);

            modelBuilder.Entity<ca_address>()
                .HasMany(e => e.ca_related_person_contact)
                .WithOptional(e => e.ca_address)
                .HasForeignKey(e => e.address_ca_address_id);

            modelBuilder.Entity<ca_address_dx_box>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_dx_box>()
                .Property(e => e.exchange)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_dx_box>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_dx_box>()
                .Property(e => e.provider)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_non_standard>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_non_standard>()
                .Property(e => e.line_1)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_non_standard>()
                .Property(e => e.line_2)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_po_box>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_po_box>()
                .Property(e => e.exchange)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_po_box>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.building_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.street_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.street_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_address_standard>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_liabilities)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_max_borrowing_capacity)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_max_bundled_credit_card_limit)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_net_asset_position)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_liabilities_ara_adjustment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_liabilities_ara_repayment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_liabilities_assessment)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_household_living_expenses)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_household_other_commitments)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_household_standardised_living_expenses)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_assets)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_debt)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_total_net_incomes)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_remaining_disposable_net_income)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_net_income_to_expense_ratio)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_affordability>()
                .Property(e => e.ed_debt_to_gross_income_ratio)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_case_data>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_case_data>()
                .Property(e => e.ed_case_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_case_data>()
                .Property(e => e.ed_case_creator_coreid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_case_data>()
                .Property(e => e.ed_external_creator_coreid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_company_applicant>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_company_applicant>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithOptional(e => e.ca_company_applicant)
                .HasForeignKey(e => e.partner_ca_company_applicant_id);

            modelBuilder.Entity<ca_credit_application>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_credit_application>()
                .HasOptional(e => e.ca_affordability)
                .WithRequired(e => e.ca_credit_application)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_credit_application>()
                .HasOptional(e => e.ca_case_data)
                .WithRequired(e => e.ca_credit_application)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_credit_application_conditions>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_credit_application_conditions>()
                .Property(e => e.ed_condition_text)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household>()
                .Property(e => e.ed_standardised_living_expense_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_household_applicant>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_applicant>()
                .Property(e => e.ed_household_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_applicant>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense>()
                .Property(e => e.amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_household_living_expense>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense>()
                .Property(e => e.ed_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_household_living_expense>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_household_living_expense_percent_responsible_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense_percent_responsible_owner>()
                .Property(e => e.ed_household_living_expense_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense_percent_responsible_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_living_expense_percent_responsible_owner>()
                .Property(e => e.percent_responsible)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_household_other_commitment>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_other_commitment>()
                .Property(e => e.amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_household_other_commitment>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_other_commitment>()
                .Property(e => e.ed_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_household_other_commitment>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_household_other_commitment_percent_responsible_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_other_commitment_percent_responsible_owner>()
                .Property(e => e.ed_household_other_commitment_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_other_commitment_percent_responsible_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_household_other_commitment_percent_responsible_owner>()
                .Property(e => e.percent_responsible)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_insurance>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance>()
                .Property(e => e.insured_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_insurance>()
                .Property(e => e.other_insurer_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance>()
                .HasOptional(e => e.ca_insurance_commission_payable)
                .WithRequired(e => e.ca_insurance)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_insurance>()
                .HasOptional(e => e.ca_insurance_premium)
                .WithRequired(e => e.ca_insurance)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_insurance>()
                .HasMany(e => e.ca_non_real_estate_asset_insurance)
                .WithRequired(e => e.ca_insurance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_insurance>()
                .HasMany(e => e.ca_real_estate_asset_insurance)
                .WithRequired(e => e.ca_insurance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_insurance_commission_payable>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance_commission_payable>()
                .Property(e => e.amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_insurance_commission_payable>()
                .Property(e => e.percentage)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_insurance_premium>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_insurance_premium>()
                .Property(e => e.amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.credit_limit)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.outstanding_balance)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.repayment_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_repayment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_repayment_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_ara_adjustment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_ara_repayment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.arrears_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.in_advance_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.undisbursed_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.annual_interest_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_liability>()
                .Property(e => e.ed_core_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_liability>()
                .HasOptional(e => e.ca_liability_account_number)
                .WithRequired(e => e.ca_liability)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_liability>()
                .HasOptional(e => e.ca_liability_account_performance)
                .WithRequired(e => e.ca_liability)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_liability_account_number>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_account_number>()
                .Property(e => e.account_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_account_number>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_account_number>()
                .Property(e => e.bsb)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_account_number>()
                .Property(e => e.other_fi_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_account_performance>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_percent_owned_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_percent_owned_owner>()
                .Property(e => e.ed_liability_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_percent_owned_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_liability_percent_owned_owner>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.amount_requested)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.proposed_annual_interest_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.ed_total_security_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.ed_loan_to_value_ratio)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details>()
                .HasOptional(e => e.ca_loan_details_loan_purpose)
                .WithRequired(e => e.ca_loan_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_loan_details>()
                .HasOptional(e => e.ca_loan_details_proposed_repayment)
                .WithRequired(e => e.ca_loan_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_loan_details>()
                .HasOptional(e => e.ca_loan_details_term)
                .WithRequired(e => e.ca_loan_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_loan_details_lending_purpose>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_auto_decision>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_auto_decision_result>()
                .Property(e => e.ed_description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_auto_decision_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_purpose>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_score_card>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_score_card_result>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_loan_score_card_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_percent_owned_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_percent_owned_owner>()
                .Property(e => e.ed_loan_details_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_percent_owned_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_percent_owned_owner>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_loan_details_proposed_repayment>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_loan_details_proposed_repayment>()
                .Property(e => e.regular_repayment_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_loan_details_term>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_estimated_value)
                .WithRequired(e => e.ca_non_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_financial_asset)
                .WithRequired(e => e.ca_non_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_motor_vehicle)
                .WithRequired(e => e.ca_non_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_other_asset)
                .WithRequired(e => e.ca_non_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.balloon_rv_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.balloon_rv_percent)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.estimated_cgt_liability)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.minimum_residual_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.tax_depreciation_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.estimated_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_non_real_estate_asset_estimated_value>()
                .Property(e => e.ed_core_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_financial_asset_account_number)
                .WithRequired(e => e.ca_non_real_estate_asset_financial_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_financial_asset_account_performance)
                .WithRequired(e => e.ca_non_real_estate_asset_financial_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset>()
                .HasOptional(e => e.ca_non_real_estate_asset_financial_asset_shares)
                .WithRequired(e => e.ca_non_real_estate_asset_financial_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.account_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.bsb)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.other_fi_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_number>()
                .Property(e => e.ed_core_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_account_performance>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_financial_asset_shares>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_insurance>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_insurance>()
                .Property(e => e.ed_non_real_estate_asset_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_insurance>()
                .Property(e => e.ed_insurance_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.additional_id_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.additional_id_value)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.badge)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.colour)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.condition_description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.effective_life)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.engine_capacity)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.engineid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.fuel_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.ed_good_to_be_used_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.options)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.other_information)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.registration_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.series)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.transmission)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_motor_vehicle>()
                .Property(e => e.variant)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_other_asset>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_other_asset>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_non_real_estate_asset_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_non_real_estate_asset_percent_owned_owner>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.benefits_description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_net_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_monthly_net_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_gross_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_other_income>()
                .Property(e => e.ed_monthly_gross_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_other_income_percent_owned_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income_percent_owned_owner>()
                .Property(e => e.ed_other_income_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income_percent_owned_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_other_income_percent_owned_owner>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.person_name_first_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.person_name_surname)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.existing_customer_customer_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.ed_existing_customer_years_as_member)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.person_name_middle_names)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .Property(e => e.person_name_known_as)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_household_applicant)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_household_living_expense_percent_responsible_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_household_other_commitment_percent_responsible_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_liability_percent_owned_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_loan_details_percent_owned_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_non_real_estate_asset_percent_owned_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_other_income_percent_owned_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasOptional(e => e.ca_person_applicant_affordability)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant>()
                .HasOptional(e => e.ca_person_applicant_contact)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_real_estate_asset_percent_owned_owner)
                .WithRequired(e => e.ca_person_applicant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ca_person_applicant>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithOptional(e => e.ca_person_applicant)
                .HasForeignKey(e => e.partner_ca_person_applicant_id);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_liabilities)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_max_borrowing_capacity)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_max_bundled_credit_card_limit)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_net_asset_position)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_liabilities_ara_adjustment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_liabilities_ara_repayment_monthly_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_liabilities_assessment)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_household_living_expenses)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_household_other_commitments)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_household_standardised_living_expenses)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_assets)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_debt)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_total_net_incomes)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_remaining_disposable_net_income)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_net_income_to_expense_ratio)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_affordability>()
                .Property(e => e.ed_debt_to_gross_income_ratio)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_contact>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact>()
                .HasOptional(e => e.ca_person_applicant_contact_current_address)
                .WithRequired(e => e.ca_person_applicant_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_contact>()
                .HasOptional(e => e.ca_person_applicant_contact_home_phone)
                .WithRequired(e => e.ca_person_applicant_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_contact>()
                .HasOptional(e => e.ca_person_applicant_contact_mobile)
                .WithRequired(e => e.ca_person_applicant_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_contact>()
                .HasOptional(e => e.ca_person_applicant_contact_previous_address)
                .WithRequired(e => e.ca_person_applicant_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_contact>()
                .HasOptional(e => e.ca_person_applicant_contact_work_phone)
                .WithRequired(e => e.ca_person_applicant_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_contact_current_address>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_current_address>()
                .Property(e => e.ed_residential_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_current_address>()
                .Property(e => e.ed_mailing_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_email_address>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_email_address>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_home_phone>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_home_phone>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_home_phone>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_home_phone>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_mobile>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_mobile>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_mobile>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_mobile>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_previous_address>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_previous_address>()
                .Property(e => e.ed_residential_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_work_phone>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_work_phone>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_work_phone>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_work_phone>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_contact_work_phone>()
                .Property(e => e.ed_extension)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment>()
                .HasOptional(e => e.ca_person_applicant_employment_not_employed)
                .WithRequired(e => e.ca_person_applicant_employment)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_employment>()
                .HasOptional(e => e.ca_person_applicant_employment_payg)
                .WithRequired(e => e.ca_person_applicant_employment)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_employment>()
                .HasOptional(e => e.ca_person_applicant_employment_self_employed)
                .WithRequired(e => e.ca_person_applicant_employment)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_net_superannuation_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_net_superannuation_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_superannuation_amount_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_net_private_pension_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_net_private_pension_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_private_pension_amount_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_net_other_income_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_net_other_income_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_other_income_amount_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_gross_superannuation_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_gross_superannuation_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_gross_private_pension_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_gross_private_pension_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_gross_other_income_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_not_employed>()
                .Property(e => e.ed_income_monthly_gross_other_income_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.income_gross_salary_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_income_monthly_gross_salary_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_income_net_salary_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_income_monthly_net_salary_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_income_gross_salary_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.occupation)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_payg>()
                .Property(e => e.ed_employer_ca_related_company_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed>()
                .Property(e => e.occupation)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed>()
                .Property(e => e.ed_employer_ca_related_company_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed>()
                .HasOptional(e => e.ca_person_applicant_employment_self_employed_business)
                .WithRequired(e => e.ca_person_applicant_employment_self_employed)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_employment_self_employed>()
                .HasOptional(e => e.ca_person_applicant_employment_self_employed_business_income_recent)
                .WithRequired(e => e.ca_person_applicant_employment_self_employed)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business>()
                .Property(e => e.main_business_activity)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business_income_recent>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business_income_recent>()
                .Property(e => e.profit_before_tax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business_income_recent>()
                .Property(e => e.ed_profit_after_tax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_person_applicant_employment_self_employed_business_income_recent>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_person_applicant_proof_of_identity>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_person_applicant_proof_of_identity>()
                .Property(e => e.document_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset>()
                .Property(e => e.ed_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset>()
                .Property(e => e.primary_land_use)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset>()
                .Property(e => e.propertyid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset>()
                .HasOptional(e => e.ca_real_estate_asset_commercial)
                .WithRequired(e => e.ca_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_real_estate_asset>()
                .HasOptional(e => e.ca_real_estate_asset_estimated_value)
                .WithRequired(e => e.ca_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_real_estate_asset>()
                .HasOptional(e => e.ca_real_estate_asset_rental_income)
                .WithRequired(e => e.ca_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_real_estate_asset>()
                .HasOptional(e => e.ca_real_estate_asset_residential)
                .WithRequired(e => e.ca_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_real_estate_asset>()
                .HasOptional(e => e.ca_real_estate_asset_rural)
                .WithRequired(e => e.ca_real_estate_asset)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_real_estate_asset_commercial>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_estimated_value>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_estimated_value>()
                .Property(e => e.estimated_cgt_liability)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_estimated_value>()
                .Property(e => e.estimated_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_estimated_value>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_real_estate_asset_estimated_value>()
                .Property(e => e.ed_core_value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_insurance>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_insurance>()
                .Property(e => e.ed_real_estate_asset_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_insurance>()
                .Property(e => e.ed_insurance_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_real_estate_asset_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_percent_owned_owner>()
                .Property(e => e.ed_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_percent_owned_owner>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_net_rental_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_monthly_net_rental_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_percent_for_affordability)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_gross_rental_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_rental_income>()
                .Property(e => e.ed_monthly_gross_rental_amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ca_real_estate_asset_residential>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_rural>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.lot)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.lot_plan)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.other_details)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.parish)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.plan)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.real_property_descriptor)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.title_reference)
                .IsUnicode(false);

            modelBuilder.Entity<ca_real_estate_asset_title>()
                .Property(e => e.volume)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .Property(e => e.abn)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .Property(e => e.acn)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company>()
                .HasMany(e => e.ca_person_applicant_employment_payg)
                .WithOptional(e => e.ca_related_company)
                .HasForeignKey(e => e.employer_ca_related_company_id);

            modelBuilder.Entity<ca_related_company>()
                .HasMany(e => e.ca_person_applicant_employment_self_employed)
                .WithOptional(e => e.ca_related_company)
                .HasForeignKey(e => e.employer_ca_related_company_id);

            modelBuilder.Entity<ca_related_company>()
                .HasOptional(e => e.ca_related_company_contact)
                .WithRequired(e => e.ca_related_company)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_company>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithRequired(e => e.ca_related_company)
                .HasForeignKey(e => e.ca_related_company_id);

            modelBuilder.Entity<ca_related_company>()
                .HasMany(e => e.ca_related_company_partner_percent_owned1)
                .WithOptional(e => e.ca_related_company1)
                .HasForeignKey(e => e.partner_ca_related_company_id);

            modelBuilder.Entity<ca_related_company_contact>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact>()
                .Property(e => e.web_address)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact>()
                .Property(e => e.ed_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact>()
                .HasOptional(e => e.ca_related_company_contact_contact_person)
                .WithRequired(e => e.ca_related_company_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_company_contact>()
                .HasOptional(e => e.ca_related_company_contact_office_fax)
                .WithRequired(e => e.ca_related_company_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_company_contact>()
                .HasOptional(e => e.ca_related_company_contact_office_phone)
                .WithRequired(e => e.ca_related_company_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_company_contact_contact_person>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_contact_person>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_contact_person>()
                .Property(e => e.ed_contact_person_ca_related_person_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_fax>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_fax>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_fax>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_fax>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_phone>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_phone>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_phone>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_contact_office_phone>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.percent_owned)
                .HasPrecision(10, 5);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_partner_ca_person_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_partner_ca_company_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_partner_ca_trust_applicant_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_partner_ca_related_person_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_company_partner_percent_owned>()
                .Property(e => e.ed_partner_ca_related_company_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person>()
                .Property(e => e.person_name_first_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person>()
                .Property(e => e.person_name_surname)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person>()
                .HasMany(e => e.ca_related_company_contact_contact_person)
                .WithOptional(e => e.ca_related_person)
                .HasForeignKey(e => e.contact_person_ca_related_person_id);

            modelBuilder.Entity<ca_related_person>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithOptional(e => e.ca_related_person)
                .HasForeignKey(e => e.partner_ca_related_person_id);

            modelBuilder.Entity<ca_related_person>()
                .HasOptional(e => e.ca_related_person_contact)
                .WithRequired(e => e.ca_related_person)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_person_contact>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact>()
                .Property(e => e.ed_address_ca_address_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact>()
                .HasOptional(e => e.ca_related_person_contact_home_phone)
                .WithRequired(e => e.ca_related_person_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_person_contact>()
                .HasOptional(e => e.ca_related_person_contact_mobile)
                .WithRequired(e => e.ca_related_person_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_person_contact>()
                .HasOptional(e => e.ca_related_person_contact_work_phone)
                .WithRequired(e => e.ca_related_person_contact)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_related_person_contact_home_phone>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_home_phone>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_home_phone>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_home_phone>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_mobile>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_mobile>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_mobile>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_mobile>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_work_phone>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_work_phone>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_work_phone>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_work_phone>()
                .Property(e => e.overseas_dialing_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_related_person_contact_work_phone>()
                .Property(e => e.ed_extension)
                .IsUnicode(false);

            modelBuilder.Entity<ca_rule_execution_log>()
                .Property(e => e.ed_session_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_rule_execution_log>()
                .Property(e => e.ed_request_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_rule_execution_log>()
                .Property(e => e.ed_rule_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_rule_execution_log>()
                .Property(e => e.ed_html_log)
                .IsUnicode(false);

            modelBuilder.Entity<ca_rule_execution_log>()
                .Property(e => e.ed_xml_deserialized_log)
                .IsUnicode(false);

            modelBuilder.Entity<ca_trust_applicant>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_trust_applicant>()
                .HasMany(e => e.ca_related_company_partner_percent_owned)
                .WithOptional(e => e.ca_trust_applicant)
                .HasForeignKey(e => e.partner_ca_trust_applicant_id);

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .HasOptional(e => e.ca_veda_fchk_resp_error)
                .WithRequired(e => e.ca_veda_fchk_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_report)
                .WithRequired(e => e.ca_veda_fchk_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .HasOptional(e => e.ca_veda_fchk_resp_general_message)
                .WithRequired(e => e.ca_veda_fchk_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .HasOptional(e => e.ca_veda_fchk_resp_vchk_report)
                .WithRequired(e => e.ca_veda_fchk_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp>()
                .HasOptional(e => e.ca_veda_fchk_resp_verification_suite_summary)
                .WithRequired(e => e.ca_veda_fchk_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_bcaerror>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaerror>()
                .Property(e => e.bcaerror_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaerror>()
                .Property(e => e.bcaerror_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaerror>()
                .Property(e => e.bcaerror_description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcamessage>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcamessage>()
                .Property(e => e.service_request_id)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcamessage>()
                .Property(e => e.message_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcamessage>()
                .Property(e => e.ed_fraudcheck_result)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcamessage>()
                .HasOptional(e => e.ca_veda_fchk_resp_bcaservices)
                .WithRequired(e => e.ca_veda_fchk_resp_bcamessage)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice>()
                .Property(e => e.bcaservice_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice>()
                .Property(e => e.bcaservice_code_version)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice>()
                .Property(e => e.bcaservice_client_ref)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice>()
                .HasOptional(e => e.ca_veda_fchk_resp_bcaservice_data)
                .WithRequired(e => e.ca_veda_fchk_resp_bcaservice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice_data>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice_data>()
                .HasOptional(e => e.ca_veda_fchk_resp)
                .WithRequired(e => e.ca_veda_fchk_resp_bcaservice_data)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservice_data>()
                .HasOptional(e => e.ca_veda_fchk_resp_bcaerror)
                .WithRequired(e => e.ca_veda_fchk_resp_bcaservice_data)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservices>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_bcaservices>()
                .HasOptional(e => e.ca_veda_fchk_resp_bcaservice)
                .WithRequired(e => e.ca_veda_fchk_resp_bcaservices)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.error_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.error_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.input_container)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.error_description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_error>()
                .Property(e => e.error_description_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report>()
                .HasMany(e => e.ca_veda_fchk_resp_fchk_report_fchk_result)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_report)
                .HasForeignKey(e => e.ca_veda_fchk_resp_fchk_report_id);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report_fchk_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report_fchk_result>()
                .Property(e => e.fraud_file_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report_fchk_result>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_report_fchk_result)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_report_fchk_result>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_summary)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_report_fchk_result)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.date_fraud_occurred)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.reporting_subscriber)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.fraud_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.employment_status)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.fraud_subject_role)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.drivers_licence_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.drivers_licence_country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .Property(e => e.passport_country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasMany(e => e.ca_veda_fchk_resp_fchk_result_details_addr)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .HasForeignKey(e => e.ca_veda_fchk_resp_fchk_result_details_id);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_employer_phone_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_employment)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_phone_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_referee_phone_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details>()
                .HasOptional(e => e.ca_veda_fchk_resp_fchk_result_details_second_phone_details)
                .WithRequired(e => e.ca_veda_fchk_resp_fchk_result_details)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.unit_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.street_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.street_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.street_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.suburb)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.postcode)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_addr>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employer_phone_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employer_phone_details>()
                .Property(e => e.isd)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employer_phone_details>()
                .Property(e => e.phone_area_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employer_phone_details>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employment>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employment>()
                .Property(e => e.country_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employment>()
                .Property(e => e.employer)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_employment>()
                .Property(e => e.occupation)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details>()
                .Property(e => e.isd)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details>()
                .Property(e => e.phone_area_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_phone_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_phone_details>()
                .Property(e => e.isd)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_phone_details>()
                .Property(e => e.phone_area_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_phone_details>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_referee_phone_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_referee_phone_details>()
                .Property(e => e.isd)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_referee_phone_details>()
                .Property(e => e.phone_area_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_referee_phone_details>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_second_phone_details>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_second_phone_details>()
                .Property(e => e.isd)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_second_phone_details>()
                .Property(e => e.phone_area_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_details_second_phone_details>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_phone_indicator_match_with)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_employer_phone_indicator_match_with)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_guarantor_phone_indicator_match_with)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_referee_phone_indicator_match_with)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_address_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_employer_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_drivers_licence_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_passport_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_fchk_result_summary>()
                .Property(e => e.fraudcheck_second_phone_indicator_match_with)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_general_message>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_general_message>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .Property(e => e.report_summary_code)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .Property(e => e.report_summary)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .HasOptional(e => e.ca_veda_fchk_resp_vchk_report_drivers_licence_result)
                .WithRequired(e => e.ca_veda_fchk_resp_vchk_report)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .HasMany(e => e.ca_veda_fchk_resp_vchk_report_elect_roll_result)
                .WithRequired(e => e.ca_veda_fchk_resp_vchk_report)
                .HasForeignKey(e => e.ca_veda_fchk_resp_vchk_report_id);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report>()
                .HasMany(e => e.ca_veda_fchk_resp_vchk_report_phone_list_result)
                .WithRequired(e => e.ca_veda_fchk_resp_vchk_report)
                .HasForeignKey(e => e.ca_veda_fchk_resp_vchk_report_id);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_drivers_licence_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_drivers_licence_result>()
                .Property(e => e.match_summary)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_drivers_licence_result>()
                .Property(e => e.number_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_drivers_licence_result>()
                .Property(e => e.name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result>()
                .Property(e => e.match_summary)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result>()
                .Property(e => e.electoral_roll_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result>()
                .HasOptional(e => e.ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator)
                .WithRequired(e => e.ca_veda_fchk_resp_vchk_report_elect_roll_result)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.address_indicator_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.address_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.unit_number_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.street_number_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.property_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.street_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.street_type_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.suburb_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.state_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_addr_indicator>()
                .Property(e => e.postcode_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.individual_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.first_given_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.first_given_name_indicator_match_initial)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.other_given_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.other_given_name_indicator_match_initial)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator>()
                .Property(e => e.family_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.match_summary)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.phone_listing_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.phone_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.family_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result>()
                .Property(e => e.initials_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.address_indicator_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.address_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.unit_number_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.street_number_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.property_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.street_name_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.street_type_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.suburb_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.state_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>()
                .Property(e => e.postcode_indicator_match)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_verification_suite_summary>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_verification_suite_summary>()
                .Property(e => e.vericheck_indicator_result)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_fchk_resp_verification_suite_summary>()
                .Property(e => e.fraudcheck_indicator_result)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp>()
                .HasOptional(e => e.ca_veda_vsa_resp_product_data)
                .WithRequired(e => e.ca_veda_vsa_resp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.key_characteristic)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.variable_name)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.characteristic_value)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.data_level)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_data_block_characteristic>()
                .Property(e => e.code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info>()
                .HasMany(e => e.ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency)
                .WithRequired(e => e.ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info)
                .HasForeignKey(e => e.ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info_id);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data>()
                .HasOptional(e => e.ca_veda_vsa_resp_product_data_enquiry_report)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_vsa_resp_product_data>()
                .HasOptional(e => e.ca_veda_vsa_resp_product_data_score_data)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_vsa_resp_product_data>()
                .HasOptional(e => e.ca_veda_vsa_resp_product_data_summary_data)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_enquiry_report>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_enquiry_report>()
                .HasOptional(e => e.ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data_enquiry_report)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_score_data>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_score_data>()
                .HasMany(e => e.ca_veda_vsa_resp_score_data_score)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data_score_data)
                .HasForeignKey(e => e.ca_veda_vsa_resp_product_data_score_data_id);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_summary_data>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_product_data_summary_data>()
                .HasMany(e => e.ca_veda_vsa_resp_summary_data_data_block)
                .WithRequired(e => e.ca_veda_vsa_resp_product_data_summary_data)
                .HasForeignKey(e => e.ca_veda_vsa_resp_product_data_summary_data_id);

            modelBuilder.Entity<ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency>()
                .Property(e => e.status_date)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_score_data_score>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_summary_data_data_block>()
                .Property(e => e.ed_external_guid)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_summary_data_data_block>()
                .Property(e => e.block_type)
                .IsUnicode(false);

            modelBuilder.Entity<ca_veda_vsa_resp_summary_data_data_block>()
                .Property(e => e.block_name)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.target_schema_format)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.translated_xml)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.target_endpoint)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.response_xml)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.target_system_id)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event>()
                .Property(e => e.status_description)
                .IsUnicode(false);

            modelBuilder.Entity<ch_event_product>()
                .Property(e => e.product_id)
                .IsUnicode(false);

            modelBuilder.Entity<ch_process>()
                .Property(e => e.play_type)
                .IsUnicode(false);

            modelBuilder.Entity<ch_process>()
                .Property(e => e.play_userid)
                .IsUnicode(false);

            modelBuilder.Entity<ch_process>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<ch_process>()
                .Property(e => e.status_description)
                .IsUnicode(false);

            modelBuilder.Entity<ch_process>()
                .HasMany(e => e.ch_event)
                .WithRequired(e => e.ch_process)
                .HasForeignKey(e => new { e.ch_submission_id, e.ch_play_id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ch_submission>()
                .Property(e => e.application_reference)
                .IsUnicode(false);

            modelBuilder.Entity<ch_submission>()
                .Property(e => e.received_schema_format)
                .IsUnicode(false);

            modelBuilder.Entity<ch_submission>()
                .Property(e => e.received_xml)
                .IsUnicode(false);

            modelBuilder.Entity<ch_submission>()
                .Property(e => e.system)
                .IsUnicode(false);

            modelBuilder.Entity<ch_submission>()
                .Property(e => e.ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<ch_submission>()
                .HasMany(e => e.ch_process)
                .WithRequired(e => e.ch_submission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.server)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.client)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.interface_name)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.request_guid)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.reference_guid)
                .IsUnicode(false);

            modelBuilder.Entity<in_global_interface_log>()
                .Property(e => e.log)
                .IsUnicode(false);
        }
    }
}
