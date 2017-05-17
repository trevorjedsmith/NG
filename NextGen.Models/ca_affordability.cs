namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_affordability
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public decimal? ed_total_liabilities { get; set; }

        public decimal? ed_max_borrowing_capacity { get; set; }

        public decimal? ed_max_bundled_credit_card_limit { get; set; }

        public decimal? ed_net_asset_position { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? ed_total_liabilities_ara_adjustment_monthly_amount { get; set; }

        public decimal? ed_total_liabilities_ara_repayment_monthly_amount { get; set; }

        public decimal? ed_total_liabilities_assessment { get; set; }

        public decimal? ed_total_household_living_expenses { get; set; }

        public decimal? ed_total_household_other_commitments { get; set; }

        public decimal? ed_total_household_standardised_living_expenses { get; set; }

        public decimal? ed_total_assets { get; set; }

        public decimal? ed_total_debt { get; set; }

        public decimal? ed_total_net_incomes { get; set; }

        public decimal? ed_remaining_disposable_net_income { get; set; }

        public decimal? ed_net_income_to_expense_ratio { get; set; }

        public decimal? ed_debt_to_gross_income_ratio { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }
    }
}
