using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon.Panels
{
    public partial class CountDownPanel : BaseUserControl
    {
        Timer timer;
        DateTime today;
        string text = "{0} {1} {2} {3} и {4} {5} до старта марафона!";
        int daysTo, hoursTo, minutesTo;

        public CountDownPanel()
        {
            InitializeComponent();
        }

        public void UpdateState()
        {
            today = DateTime.Now;
            var difference = Config.EventDateTime - today;
            daysTo = difference.Days;
            hoursTo = difference.Hours;
            minutesTo = difference.Minutes;
        }

        public void StartCountDown()
        {
            UpdateState();
            UpdateVisualState();
            timer = new Timer
            {
                Interval = 60 * 1000, // every minute
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void StopCountDown()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateState();
            UpdateVisualState();
        }

        public void UpdateVisualState()
        {
            lblText.Text = string.Format(text, daysTo, Utils.GetDeclension(daysTo,"день", "дня", "дней"),
                                               hoursTo, Utils.GetDeclension(daysTo, "час", "часа", "часов"), 
                                               minutesTo, Utils.GetDeclension(daysTo, "минута", "минуты", "минут"));
        }
    }
}
