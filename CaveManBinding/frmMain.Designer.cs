
namespace CaveManBinding
{
    partial class frmMain
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
            this.cbbKojCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRyaku = new System.Windows.Forms.TextBox();
            this.dgvKojData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKojData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKojCode
            // 
            this.cbbKojCode.DropDownHeight = 200;
            this.cbbKojCode.FormattingEnabled = true;
            this.cbbKojCode.IntegralHeight = false;
            this.cbbKojCode.Location = new System.Drawing.Point(51, 23);
            this.cbbKojCode.Name = "cbbKojCode";
            this.cbbKojCode.Size = new System.Drawing.Size(98, 21);
            this.cbbKojCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ryaku";
            // 
            // txtRyaku
            // 
            this.txtRyaku.Location = new System.Drawing.Point(237, 24);
            this.txtRyaku.Name = "txtRyaku";
            this.txtRyaku.Size = new System.Drawing.Size(136, 20);
            this.txtRyaku.TabIndex = 6;
            // 
            // dgvKojData
            // 
            this.dgvKojData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKojData.Location = new System.Drawing.Point(12, 78);
            this.dgvKojData.Name = "dgvKojData";
            this.dgvKojData.Size = new System.Drawing.Size(915, 360);
            this.dgvKojData.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.dgvKojData);
            this.Controls.Add(this.txtRyaku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKojCode);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKojData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKojCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRyaku;
        private System.Windows.Forms.DataGridView dgvKojData;
    }
}

