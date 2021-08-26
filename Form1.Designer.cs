
namespace CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitbtn = new System.Windows.Forms.Button();
            this.mngstatusbtn = new System.Windows.Forms.Button();
            this.mngdriversbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mngadressbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Image = global::CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2.Properties.Resources.blue_cross_icon;
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitbtn.Location = new System.Drawing.Point(406, 170);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(190, 152);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // mngstatusbtn
            // 
            this.mngstatusbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngstatusbtn.Image = global::CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2.Properties.Resources.Status_user_away_icon;
            this.mngstatusbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mngstatusbtn.Location = new System.Drawing.Point(209, 170);
            this.mngstatusbtn.Name = "mngstatusbtn";
            this.mngstatusbtn.Size = new System.Drawing.Size(190, 152);
            this.mngstatusbtn.TabIndex = 4;
            this.mngstatusbtn.Text = "Manage Status";
            this.mngstatusbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mngstatusbtn.UseVisualStyleBackColor = true;
            this.mngstatusbtn.Click += new System.EventHandler(this.LinkToStatus_Click);
            // 
            // mngdriversbtn
            // 
            this.mngdriversbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngdriversbtn.Image = global::CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2.Properties.Resources.steering_wheel_icon;
            this.mngdriversbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mngdriversbtn.Location = new System.Drawing.Point(12, 169);
            this.mngdriversbtn.Name = "mngdriversbtn";
            this.mngdriversbtn.Size = new System.Drawing.Size(190, 152);
            this.mngdriversbtn.TabIndex = 3;
            this.mngdriversbtn.Text = "Manage Drivers";
            this.mngdriversbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mngdriversbtn.UseVisualStyleBackColor = true;
            this.mngdriversbtn.Click += new System.EventHandler(this.LinkToDrivers_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2.Properties.Resources.van_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(404, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 152);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Freight";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LinkToFreight_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(208, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 152);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage Customers";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LinkToCustomers_Click);
            // 
            // mngadressbtn
            // 
            this.mngadressbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngadressbtn.Image = global::CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2.Properties.Resources.blue_home_icon;
            this.mngadressbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mngadressbtn.Location = new System.Drawing.Point(12, 11);
            this.mngadressbtn.Name = "mngadressbtn";
            this.mngadressbtn.Size = new System.Drawing.Size(190, 152);
            this.mngadressbtn.TabIndex = 0;
            this.mngadressbtn.Text = "Manage Addresses";
            this.mngadressbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mngadressbtn.UseVisualStyleBackColor = true;
            this.mngadressbtn.Click += new System.EventHandler(this.LinkToAddresses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 333);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.mngstatusbtn);
            this.Controls.Add(this.mngdriversbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mngadressbtn);
            this.Name = "Form1";
            this.Text = "CTU Logistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mngadressbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mngdriversbtn;
        private System.Windows.Forms.Button mngstatusbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

