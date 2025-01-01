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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInfer = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bomParentInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedGoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitConsumingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualConsumedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inShopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(1027, 25);
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
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cInvCode,
            this.cInvName,
            this.cInvStd,
            this.bomParentInvCode,
            this.startQty,
            this.purchaseQty,
            this.currentQty,
            this.requestQty,
            this.finishedGoodQty,
            this.unitConsumingQty,
            this.actualConsumedQty,
            this.inShopQty,
            this.checkedQty});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgv.Location = new System.Drawing.Point(12, 168);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1003, 394);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
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
            // bomParentInvCode
            // 
            this.bomParentInvCode.HeaderText = "对应成品编码";
            this.bomParentInvCode.Name = "bomParentInvCode";
            // 
            // startQty
            // 
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.startQty.DefaultCellStyle = dataGridViewCellStyle24;
            this.startQty.HeaderText = "期初数量";
            this.startQty.Name = "startQty";
            // 
            // purchaseQty
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.purchaseQty.DefaultCellStyle = dataGridViewCellStyle25;
            this.purchaseQty.HeaderText = "采购入库数";
            this.purchaseQty.Name = "purchaseQty";
            // 
            // currentQty
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle26.Format = "N2";
            this.currentQty.DefaultCellStyle = dataGridViewCellStyle26;
            this.currentQty.HeaderText = "现存量";
            this.currentQty.Name = "currentQty";
            // 
            // requestQty
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.requestQty.DefaultCellStyle = dataGridViewCellStyle27;
            this.requestQty.HeaderText = "材料领用数";
            this.requestQty.Name = "requestQty";
            // 
            // finishedGoodQty
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = null;
            this.finishedGoodQty.DefaultCellStyle = dataGridViewCellStyle28;
            this.finishedGoodQty.HeaderText = "成品入库数";
            this.finishedGoodQty.Name = "finishedGoodQty";
            // 
            // unitConsumingQty
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle29.Format = "N2";
            dataGridViewCellStyle29.NullValue = null;
            this.unitConsumingQty.DefaultCellStyle = dataGridViewCellStyle29;
            this.unitConsumingQty.HeaderText = "单位消耗量";
            this.unitConsumingQty.Name = "unitConsumingQty";
            // 
            // actualConsumedQty
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle30.Format = "N2";
            dataGridViewCellStyle30.NullValue = null;
            this.actualConsumedQty.DefaultCellStyle = dataGridViewCellStyle30;
            this.actualConsumedQty.HeaderText = "实际消耗数";
            this.actualConsumedQty.Name = "actualConsumedQty";
            // 
            // inShopQty
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle31.Format = "N2";
            dataGridViewCellStyle31.NullValue = null;
            this.inShopQty.DefaultCellStyle = dataGridViewCellStyle31;
            this.inShopQty.HeaderText = "车间数量";
            this.inShopQty.Name = "inShopQty";
            // 
            // checkedQty
            // 
            this.checkedQty.HeaderText = "盘点数";
            this.checkedQty.Name = "checkedQty";
            // 
            // gpConditions
            // 
            this.gpConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConditions.Controls.Add(this.xmbtnInventoryClass);
            this.gpConditions.Controls.Add(this.label5);
            this.gpConditions.Controls.Add(this.label4);
            this.gpConditions.Controls.Add(this.label3);
            this.gpConditions.Controls.Add(this.cmbAccountNo);
            this.gpConditions.Controls.Add(this.cmbWarehouse);
            this.gpConditions.Controls.Add(this.comboBox1);
            this.gpConditions.Controls.Add(this.dtpEnd);
            this.gpConditions.Controls.Add(this.label1);
            this.gpConditions.Controls.Add(this.label2);
            this.gpConditions.Location = new System.Drawing.Point(12, 90);
            this.gpConditions.Name = "gpConditions";
            this.gpConditions.Size = new System.Drawing.Size(1003, 72);
            this.gpConditions.TabIndex = 2;
            this.gpConditions.TabStop = false;
            this.gpConditions.Text = "条件";
            // 
            // xmbtnInventoryClass
            // 
            this.xmbtnInventoryClass.Location = new System.Drawing.Point(841, 29);
            this.xmbtnInventoryClass.Name = "xmbtnInventoryClass";
            this.xmbtnInventoryClass.Size = new System.Drawing.Size(88, 21);
            this.xmbtnInventoryClass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "仓库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "存货分类";
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(628, 29);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(109, 20);
            this.cmbWarehouse.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(441, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(134, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结束日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 33);
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
            this.lblTitel.Location = new System.Drawing.Point(415, 14);
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
            this.panTitel.Size = new System.Drawing.Size(1003, 55);
            this.panTitel.TabIndex = 4;
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "018",
            "017"});
            this.cmbAccountNo.Location = new System.Drawing.Point(55, 29);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(109, 20);
            this.cmbAccountNo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "账套";
            // 
            // FrmInference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 565);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn bomParentInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn startQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedGoodQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitConsumingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualConsumedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn inShopQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccountNo;
    }
}