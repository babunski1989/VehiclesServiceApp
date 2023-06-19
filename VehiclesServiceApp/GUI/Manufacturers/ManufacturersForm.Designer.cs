namespace VehiclesServiceApp.GUI
{
    partial class ManufacturersForm
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
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.btnUpdateManufacturer = new System.Windows.Forms.Button();
            this.btnAddManufacturer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Location = new System.Drawing.Point(12, 28);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.RowHeadersWidth = 51;
            this.dgvManufacturers.RowTemplate.Height = 24;
            this.dgvManufacturers.Size = new System.Drawing.Size(414, 357);
            this.dgvManufacturers.TabIndex = 0;
            // 
            // btnUpdateManufacturer
            // 
            this.btnUpdateManufacturer.Location = new System.Drawing.Point(169, 405);
            this.btnUpdateManufacturer.Name = "btnUpdateManufacturer";
            this.btnUpdateManufacturer.Size = new System.Drawing.Size(102, 40);
            this.btnUpdateManufacturer.TabIndex = 1;
            this.btnUpdateManufacturer.Text = "Change";
            this.btnUpdateManufacturer.UseVisualStyleBackColor = true;
            this.btnUpdateManufacturer.Click += new System.EventHandler(this.btnUpdateManufacturer_Click);
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.Location = new System.Drawing.Point(324, 405);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(102, 40);
            this.btnAddManufacturer.TabIndex = 1;
            this.btnAddManufacturer.Text = "Add";
            this.btnAddManufacturer.UseVisualStyleBackColor = true;
            this.btnAddManufacturer.Click += new System.EventHandler(this.btnAddManufacturer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManufacturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 457);
            this.Controls.Add(this.btnAddManufacturer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateManufacturer);
            this.Controls.Add(this.dgvManufacturers);
            this.Name = "ManufacturersForm";
            this.Text = "Manufacturers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Button btnUpdateManufacturer;
        private System.Windows.Forms.Button btnAddManufacturer;
        private System.Windows.Forms.Button btnDelete;
    }
}