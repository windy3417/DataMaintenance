﻿
namespace DataMaintenance.UI.U8.CheckInvetory
{
    partial class FrmInference
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInfer = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gpConditions = new System.Windows.Forms.GroupBox();
            this.xmbtnInventoryClass = new Utility.UControl.XmTextBoxWithButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.panTitel = new System.Windows.Forms.Panel();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedGoodsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualConsumedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inShopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gpConditions.SuspendLayout();
            this.panTitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInfer,
            this.tsbSave,
            this.tsbExport,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInfer
            // 
            this.tsbInfer.Image = global::DataMaintenance.Properties.Resources.calculate_banlance;
            this.tsbInfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfer.Name = "tsbInfer";
            this.tsbInfer.Size = new System.Drawing.Size(53, 22);
            this.tsbInfer.Text = "推算";
            this.tsbInfer.Click += new System.EventHandler(this.tsbInfer_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::DataMaintenance.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(53, 22);
            this.tsbSave.Text = "保存";
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::DataMaintenance.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(53, 22);
            this.tsbExport.Text = "导出";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::DataMaintenance.Properties.Resources.打印;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(53, 22);
            this.tsbPrint.Text = "打印";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cInvCode,
            this.cInvName,
            this.cInvStd,
            this.startQty,
            this.purchaseQty,
            this.currentQty,
            this.requestQty,
            this.finishedGoodsQty,
            this.actualConsumedQty,
            this.inShopQty,
            this.checkedQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Location = new System.Drawing.Point(12, 168);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(776, 279);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // gpConditions
            // 
            this.gpConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConditions.Controls.Add(this.xmbtnInventoryClass);
            this.gpConditions.Controls.Add(this.label4);
            this.gpConditions.Controls.Add(this.label3);
            this.gpConditions.Controls.Add(this.cmbWarehouse);
            this.gpConditions.Controls.Add(this.comboBox1);
            this.gpConditions.Controls.Add(this.dtpEnd);
            this.gpConditions.Controls.Add(this.label1);
            this.gpConditions.Controls.Add(this.label2);
            this.gpConditions.Location = new System.Drawing.Point(12, 90);
            this.gpConditions.Name = "gpConditions";
            this.gpConditions.Size = new System.Drawing.Size(776, 72);
            this.gpConditions.TabIndex = 2;
            this.gpConditions.TabStop = false;
            this.gpConditions.Text = "条件";
            // 
            // xmbtnInventoryClass
            // 
            this.xmbtnInventoryClass.Location = new System.Drawing.Point(667, 29);
            this.xmbtnInventoryClass.Name = "xmbtnInventoryClass";
            this.xmbtnInventoryClass.Size = new System.Drawing.Size(88, 21);
            this.xmbtnInventoryClass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "仓库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "存货分类";
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(454, 29);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(109, 20);
            this.cmbWarehouse.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(267, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(134, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结束日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始日期";
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitel.Location = new System.Drawing.Point(302, 14);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(185, 24);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "车间库存推算表";
            // 
            // panTitel
            // 
            this.panTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitel.Controls.Add(this.lblTitel);
            this.panTitel.Location = new System.Drawing.Point(12, 29);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(776, 55);
            this.panTitel.TabIndex = 4;
            // 
            // cInvCode
            // 
            this.cInvCode.HeaderText = "存货编码";
            this.cInvCode.Name = "cInvCode";
            // 
            // cInvName
            // 
            this.cInvName.HeaderText = "存货名称";
            this.cInvName.Name = "cInvName";
            // 
            // cInvStd
            // 
            this.cInvStd.HeaderText = "规格型号";
            this.cInvStd.Name = "cInvStd";
            // 
            // startQty
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.startQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.startQty.HeaderText = "期初数量";
            this.startQty.Name = "startQty";
            // 
            // purchaseQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.purchaseQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseQty.HeaderText = "采购入库数";
            this.purchaseQty.Name = "purchaseQty";
            // 
            // currentQty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle4.Format = "N2";
            this.currentQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.currentQty.HeaderText = "现存量";
            this.currentQty.Name = "currentQty";
            // 
            // requestQty
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.requestQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.requestQty.HeaderText = "材料领用数";
            this.requestQty.Name = "requestQty";
            // 
            // finishedGoodsQty
            // 
            this.finishedGoodsQty.HeaderText = "成品入库数";
            this.finishedGoodsQty.Name = "finishedGoodsQty";
            // 
            // actualConsumedQty
            // 
            this.actualConsumedQty.HeaderText = "实际消耗数";
            this.actualConsumedQty.Name = "actualConsumedQty";
            // 
            // inShopQty
            // 
            this.inShopQty.HeaderText = "车间数量";
            this.inShopQty.Name = "inShopQty";
            // 
            // checkedQty
            // 
            this.checkedQty.HeaderText = "盘点数";
            this.checkedQty.Name = "checkedQty";
            // 
            // FrmInference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.gpConditions);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmInference";
            this.Text = "车间库存推算表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gpConditions.ResumeLayout(false);
            this.gpConditions.PerformLayout();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInfer;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gpConditions;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Utility.UControl.XmTextBoxWithButton xmbtnInventoryClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn startQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedGoodsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualConsumedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn inShopQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedQty;
    }
}