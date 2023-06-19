namespace VehiclesServiceApp.GUI
{
    partial class ServiceBookForm
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
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnFinishService = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.cbServiceFinished = new System.Windows.Forms.ComboBox();
            this.cbxFinished = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(5, 82);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(1159, 284);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(1027, 372);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(137, 42);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule service";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnFinishService
            // 
            this.btnFinishService.Location = new System.Drawing.Point(843, 372);
            this.btnFinishService.Name = "btnFinishService";
            this.btnFinishService.Size = new System.Drawing.Size(137, 42);
            this.btnFinishService.TabIndex = 1;
            this.btnFinishService.Text = "Finish service";
            this.btnFinishService.UseVisualStyleBackColor = true;
            this.btnFinishService.Click += new System.EventHandler(this.btnFinishService_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(5, 27);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(242, 35);
            this.tbKeyword.TabIndex = 2;
            this.tbKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // cbServiceFinished
            // 
            this.cbServiceFinished.FormattingEnabled = true;
            this.cbServiceFinished.Location = new System.Drawing.Point(715, 27);
            this.cbServiceFinished.Name = "cbServiceFinished";
            this.cbServiceFinished.Size = new System.Drawing.Size(182, 24);
            this.cbServiceFinished.TabIndex = 3;
            this.cbServiceFinished.SelectedIndexChanged += new System.EventHandler(this.cbServiceFinished_SelectedIndexChanged);
            // 
            // cbxFinished
            // 
            this.cbxFinished.AutoSize = true;
            this.cbxFinished.Location = new System.Drawing.Point(285, 42);
            this.cbxFinished.Name = "cbxFinished";
            this.cbxFinished.Size = new System.Drawing.Size(127, 20);
            this.cbxFinished.TabIndex = 4;
            this.cbxFinished.Text = "Finished service";
            this.cbxFinished.UseVisualStyleBackColor = true;
            this.cbxFinished.CheckedChanged += new System.EventHandler(this.cbxFinished_CheckedChanged);
            // 
            // ServiceBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 426);
            this.Controls.Add(this.cbxFinished);
            this.Controls.Add(this.cbServiceFinished);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.btnFinishService);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dgvServices);
            this.Name = "ServiceBookForm";
            this.Text = "Service book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnFinishService;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.ComboBox cbServiceFinished;
        private System.Windows.Forms.CheckBox cbxFinished;
    }
}