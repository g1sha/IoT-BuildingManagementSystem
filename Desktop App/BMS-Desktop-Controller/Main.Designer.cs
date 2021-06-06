
namespace BMS_Desktop_Controller
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanel2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressBarControl2 = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressPanel2 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.progressBarControl3 = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressPanel3 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "360d3d75-1f35-4d30-b304-c97fbeb54f05";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("24b0bd8f-98ef-4863-9a4f-7eec757e0283", null, "Pellentesque lacinia tellus eget volutpat", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("2c7b811e-2fdd-4e78-b21c-47b53da8eb27", null, "Pellentesque lacinia tellus eget volutpat", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("eab4e686-417a-4aaf-aeb7-7bb77b2fb902", null, "Pellentesque lacinia tellus eget volutpat", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01)});
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Testiraj alarm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator()});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(620, 385);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(92, 87);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Click += new System.EventHandler(this.windowsUIButtonPanel1_Click);
            // 
            // windowsUIButtonPanel2
            // 
            this.windowsUIButtonPanel2.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Zapocni nadzor", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator()});
            this.windowsUIButtonPanel2.Location = new System.Drawing.Point(620, 470);
            this.windowsUIButtonPanel2.Name = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel2.Size = new System.Drawing.Size(92, 87);
            this.windowsUIButtonPanel2.TabIndex = 1;
            this.windowsUIButtonPanel2.Text = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.Click += new System.EventHandler(this.windowsUIButtonPanel2_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.EditValue = 30;
            this.progressBarControl1.Location = new System.Drawing.Point(12, 218);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(300, 18);
            this.progressBarControl1.TabIndex = 3;
            // 
            // progressBarControl2
            // 
            this.progressBarControl2.EditValue = 45;
            this.progressBarControl2.Location = new System.Drawing.Point(12, 410);
            this.progressBarControl2.Name = "progressBarControl2";
            this.progressBarControl2.Size = new System.Drawing.Size(300, 18);
            this.progressBarControl2.TabIndex = 5;
            // 
            // progressPanel2
            // 
            this.progressPanel2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel2.Appearance.Options.UseBackColor = true;
            this.progressPanel2.Location = new System.Drawing.Point(12, 338);
            this.progressPanel2.Name = "progressPanel2";
            this.progressPanel2.Size = new System.Drawing.Size(300, 66);
            this.progressPanel2.TabIndex = 4;
            this.progressPanel2.Text = "progressPanel2";
            // 
            // progressBarControl3
            // 
            this.progressBarControl3.EditValue = 24;
            this.progressBarControl3.Location = new System.Drawing.Point(12, 314);
            this.progressBarControl3.Name = "progressBarControl3";
            this.progressBarControl3.Size = new System.Drawing.Size(300, 18);
            this.progressBarControl3.TabIndex = 7;
            // 
            // progressPanel3
            // 
            this.progressPanel3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel3.Appearance.Options.UseBackColor = true;
            this.progressPanel3.Location = new System.Drawing.Point(12, 242);
            this.progressPanel3.Name = "progressPanel3";
            this.progressPanel3.Size = new System.Drawing.Size(300, 66);
            this.progressPanel3.TabIndex = 6;
            this.progressPanel3.Text = "progressPanel3";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 569);
            this.Controls.Add(this.progressBarControl3);
            this.Controls.Add(this.progressPanel3);
            this.Controls.Add(this.progressBarControl2);
            this.Controls.Add(this.progressPanel2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.windowsUIButtonPanel2);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel2;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel2;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl3;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel3;
    }
}