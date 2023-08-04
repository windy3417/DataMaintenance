namespace DataMaintenance.UI
{
    partial class Frm_PO
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
            this.gb_singleMend = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_noEedit = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.btn_mend = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.gb_singleMend.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_singleMend
            // 
            this.gb_singleMend.Controls.Add(this.tableLayoutPanel1);
            this.gb_singleMend.Location = new System.Drawing.Point(46, 78);
            this.gb_singleMend.Name = "gb_singleMend";
            this.gb_singleMend.Size = new System.Drawing.Size(535, 162);
            this.gb_singleMend.TabIndex = 0;
            this.gb_singleMend.TabStop = false;
            this.gb_singleMend.Text = "含税单价修改";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.rb_noEedit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rb_edit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_mend, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // rb_noEedit
            // 
            this.rb_noEedit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_noEedit.AutoSize = true;
            this.rb_noEedit.ForeColor = System.Drawing.Color.Red;
            this.rb_noEedit.Location = new System.Drawing.Point(158, 17);
            this.rb_noEedit.Name = "rb_noEedit";
            this.rb_noEedit.Size = new System.Drawing.Size(107, 16);
            this.rb_noEedit.TabIndex = 4;
            this.rb_noEedit.Text = "修改为不可编辑";
            this.rb_noEedit.UseVisualStyleBackColor = true;
            // 
            // rb_edit
            // 
            this.rb_edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_edit.AutoSize = true;
            this.rb_edit.Checked = true;
            this.rb_edit.Location = new System.Drawing.Point(57, 17);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(95, 16);
            this.rb_edit.TabIndex = 4;
            this.rb_edit.TabStop = true;
            this.rb_edit.Text = "修改为可编辑";
            this.rb_edit.UseVisualStyleBackColor = true;
            // 
            // btn_mend
            // 
            this.btn_mend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_mend.Location = new System.Drawing.Point(57, 65);
            this.btn_mend.Name = "btn_mend";
            this.btn_mend.Size = new System.Drawing.Size(95, 20);
            this.btn_mend.TabIndex = 6;
            this.btn_mend.Text = "修改";
            this.btn_mend.UseVisualStyleBackColor = true;
            this.btn_mend.Click += new System.EventHandler(this.btn_mend_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_close
            // 
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_close.Image = global::DataMaintenance.Properties.Resources.exit;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(23, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // Frm_PO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb_singleMend);
            this.Name = "Frm_PO";
            this.Text = "订单价格修改授权";
            this.gb_singleMend.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_singleMend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_noEedit;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Button btn_mend;
    }
}