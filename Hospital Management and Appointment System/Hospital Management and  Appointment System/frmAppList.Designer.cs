namespace Hospital_Management_and__Appointment_System
{
    partial class frmAppList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppList));
            this.asd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.asd)).BeginInit();
            this.SuspendLayout();
            // 
            // asd
            // 
            this.asd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.asd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asd.Location = new System.Drawing.Point(0, 0);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(949, 505);
            this.asd.TabIndex = 0;
            this.asd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asd_CellDoubleClick);
            // 
            // frmAppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(949, 505);
            this.Controls.Add(this.asd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAppList";
            this.Text = "App List";
            this.Load += new System.EventHandler(this.frmAppList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView asd;
    }
}