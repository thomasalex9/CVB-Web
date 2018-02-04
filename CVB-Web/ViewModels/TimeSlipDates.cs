using System;

namespace CVB_Web.ViewModels {
    public struct TimeSlipDates {

        // "My Timeslips"
        public DateTime last_week_start_dt { get; }
        public DateTime last_week_end_dt { get; }

        public DateTime this_week_start_dt { get; }
        public DateTime this_week_end_dt { get; }

        public DateTime mtd_start_dt { get; }
        public DateTime mtd_end_dt { get; }

        public DateTime ytd_start_dt { get; }
        public DateTime ytd_end_dt { get; }

        public DateTime last_month_start_dt { get; }
        public DateTime last_month_end_dt { get; }

        public TimeSlipDates(DateTime today) {

            // this week
            int weekday = (int) today.DayOfWeek; //0=Sun 1=Mon 5=Fri 6=Sat
            this_week_start_dt = today.AddDays(0 - ((int)today.DayOfWeek));
            this_week_end_dt = this_week_start_dt.AddDays(6);

            // last week
            last_week_start_dt = this_week_start_dt.AddDays(-7);
            last_week_end_dt = last_week_start_dt.AddDays(6);

            // month-to-date
            mtd_end_dt = today;  
            mtd_start_dt = new DateTime(today.Year, today.Month, 1);

            // year-to-date
            ytd_end_dt = today;  
            ytd_start_dt = new DateTime(today.Year, 1, 1);

            // last month
            last_month_start_dt = mtd_start_dt.AddMonths(-1);
            last_month_end_dt = mtd_start_dt.AddDays(-1);
        }
    }
}