//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sessionone
{
    using System;
    using System.Collections.Generic;

    public partial class TrafficViewer
    {
        public System.DateTime EnterTime { get; set; }
        public Nullable<System.DateTime> ExitTime { get; set; }
        public string ExitCause { get; set; }
        public int ID { get; set; }
        public Nullable<int> CauseID { get; set; }
        public int UserID { get; set; }

        public virtual ExitCauses ExitCauses { get; set; }
        public virtual Users Users { get; set; }

        public String enterFormatedTime { get => EnterTime.TimeOfDay.ToString().Substring(0, 5); }
        public String exitFormatedTime { get => ExitTime?.TimeOfDay.ToString().Substring(0, 5); }
        public String dateFormated { get => EnterTime.Date.ToString("d"); }

        public String timeSpend
        {
            get
            {
                if (timeSpendDuration.TotalSeconds == 0)
                {
                    return "";
                }
                else
                {
                    return timeSpendDuration.ToString().Substring(3, 5);
                }
            }
        }

        public TimeSpan timeSpendDuration
        {
            get
            {
                var duration = TimeSpan.FromTicks(ExitTime?.Subtract(EnterTime).Ticks ?? 0).Duration();

                return duration;

            }
        }



        public String code { get => ExitCauses == null ? "White" : "Red"; }

    }
}