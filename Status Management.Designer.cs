
namespace CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2
{
    partial class Status_Management
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Readbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.txtStatusId = new System.Windows.Forms.TextBox();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.pickPickUp = new System.Windows.Forms.ComboBox();
            this.pickDelivered = new System.Windows.Forms.ComboBox();
            this.dataGridStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pick Up:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Driver Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delivered:";
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(180, 138);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(75, 23);
            this.Createbtn.TabIndex = 6;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Readbtn
            // 
            this.Readbtn.Location = new System.Drawing.Point(261, 138);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(75, 23);
            this.Readbtn.TabIndex = 7;
            this.Readbtn.Text = "Read";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(342, 138);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 8;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(423, 138);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 9;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(504, 138);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // txtStatusId
            // 
            this.txtStatusId.Location = new System.Drawing.Point(72, 42);
            this.txtStatusId.Name = "txtStatusId";
            this.txtStatusId.Size = new System.Drawing.Size(148, 20);
            this.txtStatusId.TabIndex = 11;
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(308, 42);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(148, 20);
            this.txtDriverId.TabIndex = 12;
            // 
            // pickPickUp
            // 
            this.pickPickUp.FormattingEnabled = true;
            this.pickPickUp.Location = new System.Drawing.Point(72, 71);
            this.pickPickUp.Name = "pickPickUp";
            this.pickPickUp.Size = new System.Drawing.Size(148, 21);
            this.pickPickUp.TabIndex = 13;
            // 
            // pickDelivered
            // 
            this.pickDelivered.FormattingEnabled = true;
            this.pickDelivered.Location = new System.Drawing.Point(308, 75);
            this.pickDelivered.Name = "pickDelivered";
            this.pickDelivered.Size = new System.Drawing.Size(148, 21);
            this.pickDelivered.TabIndex = 14;
            // 
            // dataGridStatus
            // 
            this.dataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus.Location = new System.Drawing.Point(12, 167);
            this.dataGridStatus.Name = "dataGridStatus";
            this.dataGridStatus.Size = new System.Drawing.Size(567, 233);
            this.dataGridStatus.TabIndex = 1;
            // 
            // Status_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 412);
            this.Controls.Add(this.pickDelivered);
            this.Controls.Add(this.pickPickUp);
            this.Controls.Add(this.txtDriverId);
            this.Controls.Add(this.txtStatusId);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Readbtn);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridStatus);
            this.Controls.Add(this.label1);
            this.Name = "Status_Management";
            this.Text = "Status_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Readbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.TextBox txtStatusId;
        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.ComboBox pickPickUp;
        private System.Windows.Forms.ComboBox pickDelivered;
        private System.Windows.Forms.DataGridView dataGridStatus;
    }
}