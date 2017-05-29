namespace CVB_Web
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCvb : DbContext
    {
        public ModelCvb()
            : base("name=ModelCvb")
        {
        }

        public virtual DbSet<app_domain> app_domain { get; set; }
        public virtual DbSet<app_vendor> app_vendor { get; set; }
        public virtual DbSet<application> applications { get; set; }
        public virtual DbSet<audit> audits { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<company_info> company_info { get; set; }
        public virtual DbSet<consultant> consultants { get; set; }
        public virtual DbSet<consultant_application> consultant_application { get; set; }
        public virtual DbSet<consultant_biography> consultant_biography { get; set; }
        public virtual DbSet<consultant_certification> consultant_certification { get; set; }
        public virtual DbSet<consultant_education> consultant_education { get; set; }
        public virtual DbSet<consultant_employment_history> consultant_employment_history { get; set; }
        public virtual DbSet<consultant_skill> consultant_skill { get; set; }
        public virtual DbSet<consultant_summary> consultant_summary { get; set; }
        public virtual DbSet<domain> domains { get; set; }
        public virtual DbSet<event_role> event_role { get; set; }
        public virtual DbSet<exp> exps { get; set; }
        public virtual DbSet<exp_detail> exp_detail { get; set; }
        public virtual DbSet<exp_layout> exp_layout { get; set; }
        public virtual DbSet<exp_layout_grp> exp_layout_grp { get; set; }
        public virtual DbSet<exp_layout_grp_dtl> exp_layout_grp_dtl { get; set; }
        public virtual DbSet<exp_sort_col> exp_sort_col { get; set; }
        public virtual DbSet<experience> experiences { get; set; }
        public virtual DbSet<experience_detail> experience_detail { get; set; }
        public virtual DbSet<holiday> holidays { get; set; }
        public virtual DbSet<noteworthy_sow> noteworthy_sow { get; set; }
        public virtual DbSet<proficiency> proficiencies { get; set; }
        public virtual DbSet<project_type> project_type { get; set; }
        public virtual DbSet<publication> publications { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<sow> sows { get; set; }
        public virtual DbSet<sow_consultant> sow_consultant { get; set; }
        public virtual DbSet<speaking_engagement> speaking_engagement { get; set; }
        public virtual DbSet<thought_leadership> thought_leadership { get; set; }
        public virtual DbSet<timeslip> timeslips { get; set; }
        public virtual DbSet<timeslip_period> timeslip_period { get; set; }
        public virtual DbSet<timeslip_phase> timeslip_phase { get; set; }
        public virtual DbSet<timeslip_role> timeslip_role { get; set; }
        public virtual DbSet<timeslip_task> timeslip_task { get; set; }
        public virtual DbSet<title> titles { get; set; }
        public virtual DbSet<white_paper> white_paper { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<consultant>()
                .Property(e => e.vacation_available)
                .HasPrecision(28, 6);

            modelBuilder.Entity<timeslip>()
                .Property(e => e.slip_time)
                .HasPrecision(28, 6);
        }
    }
}
