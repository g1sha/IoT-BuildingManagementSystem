using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_Desktop_Controller
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        Series series1 = new Series("Series 1", ViewType.Line);
        int brojac = -1;

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        //toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications.IndexOf(1));
    }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm upaljen");
        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nadzor zapocet");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}