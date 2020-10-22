namespace DataMaintenance.UI
{
    partial class Frm_toolProperty
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
            this.txt_invCode = new System.Windows.Forms.TextBox();
            this.rb_aset = new System.Windows.Forms.RadioButton();
            this.rb_consume = new System.Windows.Forms.RadioButton();
            this.lbl_invCode = new System.Windows.Forms.Label();
            this.lbl_attention = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.btn_mend = new System.Windows.Forms.Button();
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
            this.gb_singleMend.Text = "单项修改";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txt_invCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rb_aset, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rb_consume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_mend, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_invCode, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txt_invCode
            // 
            this.txt_invCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_invCode.Location = new System.Drawing.Point(157, 64);
            this.txt_invCode.Name = "txt_invCode";
            this.txt_invCode.Size = new System.Drawing.Size(145, 21);
            this.txt_invCode.TabIndex = 3;
            // 
            // rb_aset
            // 
            this.rb_aset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_aset.AutoSize = true;
            this.rb_aset.Location = new System.Drawing.Point(157, 17);
            this.rb_aset.Name = "rb_aset";
            this.rb_aset.Size = new System.Drawing.Size(131, 16);
            this.rb_aset.TabIndex = 4;
            this.rb_aset.TabStop = true;
            this.rb_aset.Text = "修改为固定资产属性";
            this.rb_aset.UseVisualStyleBackColor = true;
            // 
            // rb_consume
            // 
            this.rb_consume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_consume.AutoSize = true;
            this.rb_consume.Location = new System.Drawing.Point(44, 17);
            this.rb_consume.Name = "rb_consume";
            this.rb_consume.Size = new System.Drawing.Size(107, 16);
            this.rb_consume.TabIndex = 4;
            this.rb_consume.TabStop = true;
            this.rb_consume.Text = "修改为消耗属性";
            this.rb_consume.UseVisualStyleBackColor = true;
            // 
            // lbl_invCode
            // 
            this.lbl_invCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_invCode.AutoSize = true;
            this.lbl_invCode.Location = new System.Drawing.Point(86, 69);
            this.lbl_invCode.Name = "lbl_invCode";
            this.lbl_invCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_invCode.TabIndex = 5;
            this.lbl_invCode.Text = "存货编码：";
            // 
            // lbl_attention
            // 
            this.lbl_attention.AutoSize = true;
            this.lbl_attention.Location = new System.Drawing.Point(44, 26);
            this.lbl_attention.Name = "lbl_attention";
            this.lbl_attention.Size = new System.Drawing.Size(353, 12);
            this.lbl_attention.TabIndex = 1;
            this.lbl_attention.Text = "修改前置条件：无在途刀具与库存方可修改刀具的资产属性！！！";
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
            // btn_mend
            // 
            this.btn_mend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_mend.Location = new System.Drawing.Point(311, 63);
            this.btn_mend.Name = "btn_mend";
            this.btn_mend.Size = new System.Drawing.Size(75, 23);
            this.btn_mend.TabIndex = 6;
            this.btn_mend.Text = "修改";
            this.btn_mend.UseVisualStyleBackColor = true;
            this.btn_mend.Click += new System.EventHandler(this.btn_mend_Click);
            // 
            // Frm_toolProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_attention);
            this.Controls.Add(this.gb_singleMend);
            this.Name = "Frm_toolProperty";
            this.Text = "属性修改";
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
        private System.Windows.Forms.TextBox txt_invCode;
        private System.Windows.Forms.RadioButton rb_aset;
        private System.Windows.Forms.RadioButton rb_consume;
        private System.Windows.Forms.Label lbl_invCode;
        private System.Windows.Forms.Label lbl_attention;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Button btn_mend;
    }
}