namespace VehiclesServiceApp.GUI
{
    partial class AddManufacturerForm
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
            this.tbAddManufacurer = new System.Windows.Forms.TextBox();
            this.btnSaveManufacurer = new System.Windows.Forms.Button();
            this.btnCancelManName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbAddManufacurer
            // 
            this.tbAddManufacurer.Location = new System.Drawing.Point(34, 103);
            this.tbAddManufacurer.Name = "tbAddManufacurer";
            this.tbAddManufacurer.Size = new System.Drawing.Size(244, 22);
            this.tbAddManufacurer.TabIndex = 1;
            // 
            // btnSaveManufacurer
            // 
            this.btnSaveManufacurer.Location = new System.Drawing.Point(182, 156);
            this.btnSaveManufacurer.Name = "btnSaveManufacurer";
            this.btnSaveManufacurer.Size = new System.Drawing.Size(96, 35);
            this.btnSaveManufacurer.TabIndex = 2;
            this.btnSaveManufacurer.Text = "Save";
            this.btnSaveManufacurer.UseVisualStyleBackColor = true;
            this.btnSaveManufacurer.Click += new System.EventHandler(this.btnSaveManufacurer_Click);
            // 
            // btnCancelManName
            // 
            this.btnCancelManName.Location = new System.Drawing.Point(34, 156);
            this.btnCancelManName.Name = "btnCancelManName";
            this.btnCancelManName.Size = new System.Drawing.Size(96, 35);
            this.btnCancelManName.TabIndex = 2;
            this.btnCancelManName.Text = "Cancel";
            this.btnCancelManName.UseVisualStyleBackColor = true;
            this.btnCancelManName.Click += new System.EventHandler(this.btnCancelManName_Click);
            // 
            // AddManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 244);
            this.Controls.Add(this.btnCancelManName);
            this.Controls.Add(this.btnSaveManufacurer);
            this.Controls.Add(this.tbAddManufacurer);
            this.Controls.Add(this.label1);
            this.Name = "AddManufacturerForm";
            this.Text = "AddManufacturerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddManufacurer;
        private System.Windows.Forms.Button btnSaveManufacurer;
        private System.Windows.Forms.Button btnCancelManName;
    }
}