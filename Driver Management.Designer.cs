
namespace CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2
{
    partial class Driver_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDriver = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yesbtn = new System.Windows.Forms.RadioButton();
            this.Nobtn = new System.Windows.Forms.RadioButton();
            this.pickDriverLicense = new System.Windows.Forms.ComboBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Readbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address Information:";
            // 
            // dataGridDriver
            // 
            this.dataGridDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDriver.Location = new System.Drawing.Point(12, 184);
            this.dataGridDriver.Name = "dataGridDriver";
            this.dataGridDriver.Size = new System.Drawing.Size(539, 196);
            this.dataGridDriver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "License Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Owner:";
            // 
            // Yesbtn
            // 
            this.Yesbtn.AutoSize = true;
            this.Yesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesbtn.Location = new System.Drawing.Point(89, 107);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(43, 17);
            this.Yesbtn.TabIndex = 5;
            this.Yesbtn.TabStop = true;
            this.Yesbtn.Text = "Yes";
            this.Yesbtn.UseVisualStyleBackColor = true;
            // 
            // Nobtn
            // 
            this.Nobtn.AutoSize = true;
            this.Nobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobtn.Location = new System.Drawing.Point(138, 107);
            this.Nobtn.Name = "Nobtn";
            this.Nobtn.Size = new System.Drawing.Size(39, 17);
            this.Nobtn.TabIndex = 6;
            this.Nobtn.TabStop = true;
            this.Nobtn.Text = "No";
            this.Nobtn.UseVisualStyleBackColor = true;
            // 
            // pickDriverLicense
            // 
            this.pickDriverLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDriverLicense.FormattingEnabled = true;
            this.pickDriverLicense.Items.AddRange(new object[] {
            "Code8",
            "Code10",
            "Code12",
            "Code14"});
            this.pickDriverLicense.Location = new System.Drawing.Point(89, 72);
            this.pickDriverLicense.Name = "pickDriverLicense";
            this.pickDriverLicense.Size = new System.Drawing.Size(138, 21);
            this.pickDriverLicense.TabIndex = 7;
            this.pickDriverLicense.SelectedIndexChanged += new System.EventHandler(this.pickDriverLicense_SelectedIndexChanged);
            // 
            // txtDriverName
            // 
            this.txtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(89, 42);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(138, 20);
            this.txtDriverName.TabIndex = 8;
            // 
            // Createbtn
            // 
            this.Createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.Location = new System.Drawing.Point(152, 155);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(75, 23);
            this.Createbtn.TabIndex = 9;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Readbtn
            // 
            this.Readbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readbtn.Location = new System.Drawing.Point(233, 155);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(75, 23);
            this.Readbtn.TabIndex = 10;
            this.Readbtn.Text = "Read";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(314, 155);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 11;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(395, 155);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(476, 155);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 13;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Driver_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 392);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Readbtn);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.pickDriverLicense);
            this.Controls.Add(this.Nobtn);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridDriver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Driver_Management";
            this.Text = "Driver_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Yesbtn;
        private System.Windows.Forms.RadioButton Nobtn;
        private System.Windows.Forms.ComboBox pickDriverLicense;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Readbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}