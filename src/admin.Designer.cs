namespace LoginRegistrationForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelPharmacistsCount = new System.Windows.Forms.Label();
            this.buttonAddPharmacist = new System.Windows.Forms.Button();
            this.buttonAddSalesManager = new System.Windows.Forms.Button();
            this.textBoxPharmacistName = new System.Windows.Forms.TextBox();
            this.textBoxSalesManagerName = new System.Windows.Forms.TextBox();
            this.labelPharmacist = new System.Windows.Forms.Label();
            this.labelSalesManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSalesManagersCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPharmacistsCount
            // 
            this.labelPharmacistsCount.AutoSize = true;
            this.labelPharmacistsCount.Location = new System.Drawing.Point(150, 20);
            this.labelPharmacistsCount.Name = "labelPharmacistsCount";
            this.labelPharmacistsCount.Size = new System.Drawing.Size(14, 16);
            this.labelPharmacistsCount.TabIndex = 0;
            this.labelPharmacistsCount.Text = "0";
            // 
            // buttonAddPharmacist
            // 
            this.buttonAddPharmacist.Location = new System.Drawing.Point(150, 150);
            this.buttonAddPharmacist.Name = "buttonAddPharmacist";
            this.buttonAddPharmacist.Size = new System.Drawing.Size(100, 23);
            this.buttonAddPharmacist.TabIndex = 2;
            this.buttonAddPharmacist.Text = "Add Pharmacist";
            this.buttonAddPharmacist.UseVisualStyleBackColor = true;
            this.buttonAddPharmacist.Click += new System.EventHandler(this.buttonAddPharmacist_Click);
            // 
            // buttonAddSalesManager
            // 
            this.buttonAddSalesManager.Location = new System.Drawing.Point(150, 220);
            this.buttonAddSalesManager.Name = "buttonAddSalesManager";
            this.buttonAddSalesManager.Size = new System.Drawing.Size(100, 23);
            this.buttonAddSalesManager.TabIndex = 3;
            this.buttonAddSalesManager.Text = "Add Sales Manager";
            this.buttonAddSalesManager.UseVisualStyleBackColor = true;
            this.buttonAddSalesManager.Click += new System.EventHandler(this.buttonAddSalesManager_Click);
            // 
            // textBoxPharmacistName
            // 
            this.textBoxPharmacistName.Location = new System.Drawing.Point(150, 120);
            this.textBoxPharmacistName.Name = "textBoxPharmacistName";
            this.textBoxPharmacistName.Size = new System.Drawing.Size(200, 22);
            this.textBoxPharmacistName.TabIndex = 4;
            // 
            // textBoxSalesManagerName
            // 
            this.textBoxSalesManagerName.Location = new System.Drawing.Point(150, 190);
            this.textBoxSalesManagerName.Name = "textBoxSalesManagerName";
            this.textBoxSalesManagerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxSalesManagerName.TabIndex = 5;
            // 
            // labelPharmacist
            // 
            this.labelPharmacist.AutoSize = true;
            this.labelPharmacist.Location = new System.Drawing.Point(50, 120);
            this.labelPharmacist.Name = "labelPharmacist";
            this.labelPharmacist.Size = new System.Drawing.Size(77, 16);
            this.labelPharmacist.TabIndex = 6;
            this.labelPharmacist.Text = "Pharmacist:";
            // 
            // labelSalesManager
            // 
            this.labelSalesManager.AutoSize = true;
            this.labelSalesManager.Location = new System.Drawing.Point(50, 190);
            this.labelSalesManager.Name = "labelSalesManager";
            this.labelSalesManager.Size = new System.Drawing.Size(102, 16);
            this.labelSalesManager.TabIndex = 7;
            this.labelSalesManager.Text = "Sales Manager:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "No of Managers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "No of Pharmacist:";
            // 
            // labelSalesManagersCount
            // 
            this.labelSalesManagersCount.AutoSize = true;
            this.labelSalesManagersCount.Location = new System.Drawing.Point(150, 60);
            this.labelSalesManagersCount.Name = "labelSalesManagersCount";
            this.labelSalesManagersCount.Size = new System.Drawing.Size(14, 16);
            this.labelSalesManagersCount.TabIndex = 1;
            this.labelSalesManagersCount.Text = "0";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSalesManager);
            this.Controls.Add(this.labelPharmacist);
            this.Controls.Add(this.textBoxSalesManagerName);
            this.Controls.Add(this.textBoxPharmacistName);
            this.Controls.Add(this.buttonAddSalesManager);
            this.Controls.Add(this.buttonAddPharmacist);
            this.Controls.Add(this.labelSalesManagersCount);
            this.Controls.Add(this.labelPharmacistsCount);
            this.Name = "MainForm";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelPharmacistsCount;
        private System.Windows.Forms.Button buttonAddPharmacist;
        private System.Windows.Forms.Button buttonAddSalesManager;
        private System.Windows.Forms.TextBox textBoxPharmacistName;
        private System.Windows.Forms.TextBox textBoxSalesManagerName;
        private System.Windows.Forms.Label labelPharmacist;
        private System.Windows.Forms.Label labelSalesManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSalesManagersCount;
    }
}
