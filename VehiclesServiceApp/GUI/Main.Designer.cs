namespace VehiclesServiceApp
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
            this.btnManufacturers = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManufacturers
            // 
            this.btnManufacturers.Location = new System.Drawing.Point(54, 75);
            this.btnManufacturers.Name = "btnManufacturers";
            this.btnManufacturers.Size = new System.Drawing.Size(114, 50);
            this.btnManufacturers.TabIndex = 0;
            this.btnManufacturers.Text = "Manufacturers";
            this.btnManufacturers.UseVisualStyleBackColor = true;
            this.btnManufacturers.Click += new System.EventHandler(this.btnManufacturers_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(224, 75);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(114, 50);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "Service book";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(400, 75);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(114, 50);
            this.btnVehicles.TabIndex = 0;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 183);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnManufacturers);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManufacturers;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnVehicles;
    }
}

