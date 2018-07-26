using System;
using System.Windows.Forms;

namespace WorkTracker
{
    public partial class frmMain : Form
    {
        private bool _isCollapsed;
        private bool _going;
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _elapsed;


        public frmMain()
        {
            LoadFile();

            _isCollapsed = false;

            InitializeComponent();
        }

        private void LoadFile()
        {
            //Put in code to save on close and load history on open.
        }

        private void chkTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTop.Checked)
                TopMost = true;
            else
                TopMost = false;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (_isCollapsed)
            {
                Height = 585;
                btnCollapse.Text = "˄     ˄     ˄     ˄     ˄     ˄     ˄     ˄     ˄";
                _isCollapsed = false;
            }
            else
            {
                Height = 213;
                btnCollapse.Text = "˅     ˅     ˅     ˅     ˅     ˅     ˅     ˅     ˅";
                _isCollapsed = true;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            string _start;
            string _end;
            string _total;

            _elapsed = _startTime - DateTime.Now;
            TimeSpan elapsed = TimeSpan.FromTicks(Math.Abs(_elapsed.Ticks));

            if (_going)
            {

                _start = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    _startTime.TimeOfDay.Hours,
                    _startTime.TimeOfDay.Minutes,
                    _startTime.TimeOfDay.Seconds,
                    _startTime.TimeOfDay.Milliseconds / 10);

                _end = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    DateTime.Now.TimeOfDay.Hours,
                    DateTime.Now.TimeOfDay.Minutes,
                    DateTime.Now.TimeOfDay.Seconds,
                    DateTime.Now.TimeOfDay.Milliseconds / 10);
                _total = string.Format("{0:00}:{1:00}:{2:00}",
                    elapsed.Hours,
                    elapsed.Minutes,
                    elapsed.Seconds);
            }
            else
            {
                _start = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    DateTime.Now.TimeOfDay.Hours,
                    DateTime.Now.TimeOfDay.Minutes,
                    DateTime.Now.TimeOfDay.Seconds,
                    DateTime.Now.TimeOfDay.Milliseconds / 10);

                _end = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    _endTime.TimeOfDay.Hours,
                    _endTime.TimeOfDay.Minutes,
                    _endTime.TimeOfDay.Seconds,
                    _endTime.TimeOfDay.Milliseconds / 10);


                _total = "00:00:00";

            }

            lblTime.Text = _start + " - " + _end + " : " + _total;
        }



        private void btnTrigger_Click(object sender, EventArgs e)
        {
            if (_going)
            {
                btnTrigger.Text = "Go";

                _endTime = DateTime.Now;

                lstEntries.Items.Add(lblTime.Text + " - " + rtbNotes.Text);
                rtbNotes.Clear();
                _going = false;
            }
            else
            {
                btnTrigger.Text = "Stop";
                _startTime = DateTime.Now;
                _going = true;
            }
        }
    }
}
