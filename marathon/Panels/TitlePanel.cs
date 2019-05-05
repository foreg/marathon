using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Marathon.Panels
{
    public partial class TitlePanel : BaseUserControl
    {
        public TitlePanel()
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            lblTitle.Text = Config.EventName.ToUpper();
            var dayOfWeekLocalized = DateTimeFormatInfo.CurrentInfo.GetDayName(Config.EventDateTime.DayOfWeek);
            var monthLocalized = DateTimeFormatInfo.CurrentInfo.GetMonthName(Config.EventDateTime.Month); // todo нормально просклонять месяц
            lblDate.Text = string.Format("{0} {1} {2} {3}", dayOfWeekLocalized, Config.EventDateTime.Day, monthLocalized, Config.EventDateTime.Year);
            lblPlace.Text = Config.EventPlace;
        }
    }
}
