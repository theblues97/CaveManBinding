
namespace CaveManBinding
{
    partial class frmTree
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
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.txtBmnCode = new System.Windows.Forms.TextBox();
            this.txtBmnRyaku = new System.Windows.Forms.TextBox();
            this.dgvKoj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoj)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwMenu
            // 
            this.tvwMenu.Location = new System.Drawing.Point(12, 12);
            this.tvwMenu.Name = "tvwMenu";
            this.tvwMenu.Size = new System.Drawing.Size(285, 413);
            this.tvwMenu.TabIndex = 0;
            this.tvwMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwMenu_AfterSelect);
            // 
            // txtBmnCode
            // 
            this.txtBmnCode.Location = new System.Drawing.Point(333, 24);
            this.txtBmnCode.Name = "txtBmnCode";
            this.txtBmnCode.Size = new System.Drawing.Size(100, 20);
            this.txtBmnCode.TabIndex = 1;
            // 
            // txtBmnRyaku
            // 
            this.txtBmnRyaku.Location = new System.Drawing.Point(333, 65);
            this.txtBmnRyaku.Name = "txtBmnRyaku";
            this.txtBmnRyaku.Size = new System.Drawing.Size(157, 20);
            this.txtBmnRyaku.TabIndex = 2;
            // 
            // dgvKoj
            // 
            this.dgvKoj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoj.Location = new System.Drawing.Point(303, 160);
            this.dgvKoj.Name = "dgvKoj";
            this.dgvKoj.Size = new System.Drawing.Size(651, 265);
            this.dgvKoj.TabIndex = 4;
            // 
            // frmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 437);
            this.Controls.Add(this.dgvKoj);
            this.Controls.Add(this.txtBmnRyaku);
            this.Controls.Add(this.txtBmnCode);
            this.Controls.Add(this.tvwMenu);
            this.Name = "frmTree";
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwMenu;
        private System.Windows.Forms.TextBox txtBmnCode;
        private System.Windows.Forms.TextBox txtBmnRyaku;
        private System.Windows.Forms.DataGridView dgvKoj;
    }
}