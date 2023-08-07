﻿
namespace Aiub_Blood_Bank
{
    partial class StaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffList));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.makeAdminLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.patientListButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.staffListButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(407, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(177, 43);
            this.aiubLabel.TabIndex = 27;
            this.aiubLabel.Text = "Staff List";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.LightGray;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(275, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.BackColor = System.Drawing.Color.LightGray;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.ForeColor = System.Drawing.Color.White;
            this.mobileLabel.Location = new System.Drawing.Point(412, 134);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(55, 16);
            this.mobileLabel.TabIndex = 29;
            this.mobileLabel.Text = "Mobile";
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.BackColor = System.Drawing.Color.LightGray;
            this.verifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyLabel.ForeColor = System.Drawing.Color.White;
            this.verifyLabel.Location = new System.Drawing.Point(565, 134);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(48, 16);
            this.verifyLabel.TabIndex = 30;
            this.verifyLabel.Text = "Verify";
            // 
            // makeAdminLabel
            // 
            this.makeAdminLabel.AutoSize = true;
            this.makeAdminLabel.BackColor = System.Drawing.Color.LightGray;
            this.makeAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAdminLabel.ForeColor = System.Drawing.Color.White;
            this.makeAdminLabel.Location = new System.Drawing.Point(698, 134);
            this.makeAdminLabel.Name = "makeAdminLabel";
            this.makeAdminLabel.Size = new System.Drawing.Size(93, 16);
            this.makeAdminLabel.TabIndex = 31;
            this.makeAdminLabel.Text = "Make Admin";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.LightGray;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.ForeColor = System.Drawing.Color.White;
            this.deleteLabel.Location = new System.Drawing.Point(834, 134);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(54, 16);
            this.deleteLabel.TabIndex = 32;
            this.deleteLabel.Text = "Delete";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.White;
            this.profileLabel.Location = new System.Drawing.Point(27, 50);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(117, 20);
            this.profileLabel.TabIndex = 33;
            this.profileLabel.Text = "Admin(Name)";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.patientListButton);
            this.panel.Controls.Add(this.homeButton);
            this.panel.Controls.Add(this.bloodStockButton);
            this.panel.Controls.Add(this.donorListButton);
            this.panel.Controls.Add(this.staffListButton);
            this.panel.Location = new System.Drawing.Point(12, 123);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(177, 235);
            this.panel.TabIndex = 51;
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.LightGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(4, 141);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(168, 40);
            this.patientListButton.TabIndex = 51;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.LightGray;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(4, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(168, 40);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // bloodStockButton
            // 
            this.bloodStockButton.BackColor = System.Drawing.Color.LightGray;
            this.bloodStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockButton.ForeColor = System.Drawing.Color.White;
            this.bloodStockButton.Location = new System.Drawing.Point(4, 187);
            this.bloodStockButton.Name = "bloodStockButton";
            this.bloodStockButton.Size = new System.Drawing.Size(168, 40);
            this.bloodStockButton.TabIndex = 2;
            this.bloodStockButton.Text = "Blood Stock";
            this.bloodStockButton.UseVisualStyleBackColor = false;
            // 
            // donorListButton
            // 
            this.donorListButton.BackColor = System.Drawing.Color.LightGray;
            this.donorListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donorListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorListButton.ForeColor = System.Drawing.Color.White;
            this.donorListButton.Location = new System.Drawing.Point(4, 95);
            this.donorListButton.Name = "donorListButton";
            this.donorListButton.Size = new System.Drawing.Size(168, 40);
            this.donorListButton.TabIndex = 1;
            this.donorListButton.Text = "Donor List";
            this.donorListButton.UseVisualStyleBackColor = false;
            // 
            // staffListButton
            // 
            this.staffListButton.BackColor = System.Drawing.Color.LightGray;
            this.staffListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffListButton.ForeColor = System.Drawing.Color.White;
            this.staffListButton.Location = new System.Drawing.Point(4, 49);
            this.staffListButton.Name = "staffListButton";
            this.staffListButton.Size = new System.Drawing.Size(168, 40);
            this.staffListButton.TabIndex = 0;
            this.staffListButton.Text = "Staff List";
            this.staffListButton.UseVisualStyleBackColor = false;
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.makeAdminLabel);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffList";
            this.Text = "Aiub Blood Bank";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.Label makeAdminLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button bloodStockButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button staffListButton;
    }
}