using CVB_Web.Models;
using CVB_Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CVB_Web.ViewModels {
    public class ConsultantDashboard {

        // "My Timeslips"
        public decimal vacation_days_available { get; }
        public decimal vacation_days_remaining { get; }
        public decimal hours_this_week { get; }
        public decimal hours_last_week { get; }
        public decimal hours_mtd { get; }
        public decimal hours_last_month { get; }

        //public TimeSlipDates dates = new TimeSlipDates(System.DateTime.Today);
        public TimeSlipDates dates;

        // "My CV Profile and Experience"
        public System.DateTime? profile_last_edit_dt { get; }
        public int application_count { get; }
        public int experience_details { get; }

        // Constructors
        public ConsultantDashboard(int consultant_id) {
            meradia_db db = new meradia_db();
            this.dates = new TimeSlipDates(System.DateTime.Parse("5/14/2017"));
            this.vacation_days_available = (db.consultants.Find(7).vacation_available) ?? 0;
            this.vacation_days_remaining = CalcVacationDaysRemaining(consultant_id, db);
            this.hours_this_week = SumHours(db, consultant_id, dates.this_week_start_dt, dates.this_week_end_dt);
            this.hours_last_week = SumHours(db, consultant_id, dates.last_week_start_dt, dates.last_week_end_dt);
            this.hours_mtd = SumHours(db, consultant_id, dates.mtd_start_dt, dates.mtd_end_dt);
            this.hours_last_month = SumHours(db, consultant_id, dates.last_month_start_dt, dates.last_month_end_dt);
        }

        public ConsultantDashboard()
        {
            this.dates = new TimeSlipDates(System.DateTime.Parse("5/14/2017"));
            this.vacation_days_available = 15;
            this.vacation_days_remaining = 13;
            this.hours_this_week = 38;
            this.hours_last_week = 41;
            this.hours_mtd = 63;
            this.hours_last_month = 161;
        }
        private decimal CalcVacationDaysRemaining(int consultant_id, meradia_db db) {

            // timeslips for vacation days are entered under a generic 
            // "meradia" SOW for phase "Vacation".  so we need the Meradia
            // SOW, and the ID for the Vacation phase.  

            // first, get the company_id for Meradia Group
            int meradia = db.companies.
                Where(c => c.company_nm.Contains("meradia group")).
                Select(c => c.ID).First();

            // next, get the SOW for Meradia timeslips
            int meradia_sow = db.sows.
                Where(s => s.company_id == meradia && s.description.Contains("for meradia internal time slips")).
                Select(s => s.ID).First();

            // next, get the id for the "Vacation" phase of the Meradia SOW
            int vacation_phase = db.timeslip_phase.
                Where(t => t.sow_id == meradia_sow && t.slip_phase_name == "Vacation").
                Select(p => p.ID).First();

            // sum vacation hours YTD from consultant timeslips
            decimal vac_hours = db.timeslips.
                Where(t => t.consultant_id == consultant_id &&
                           t.sow_id == meradia_sow &&
                           t.slip_phase_nm == vacation_phase && 
                           t.slip_start_dt >= dates.ytd_start_dt &&
                           t.slip_end_dt <= dates.ytd_end_dt).
                Sum(t => t.slip_time);

            // subtract vacation hours from vacation days available. then convert 
            // the results to 8-hour days.  round to one decimal place because the 
            // minimum vacation hours are 4 (i.e. half day).
            return decimal.Round(((this.vacation_days_available * 8.0M) - vac_hours) / 8.0M, 1); 
        }

        private decimal SumHours(meradia_db db, int consultant_id,  System.DateTime start_dt, System.DateTime end_dt) {
            decimal? hours = db.timeslips.
                Where(t => t.consultant_id == consultant_id &&
                           t.slip_start_dt >= start_dt && 
                           t.slip_end_dt <= end_dt).
                Sum(t => (decimal?)t.slip_time);

            // round to 2 decimals, because hours can only be entered 
            // in quarter-hour increments (i.e. 0, .25, .5, .75)
            return decimal.Round((hours ?? 0),2);
        }
    }
}