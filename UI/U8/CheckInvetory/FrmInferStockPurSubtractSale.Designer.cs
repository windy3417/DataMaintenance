
namespace DataMaintenance.UI.U8.CheckInvetory
{
    partial class FrmInferStockWithPurSubtractSale

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInfer = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.xmbtnInventoryClass = new Utility.UControl.XmTextBoxWithButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.panTitel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bomParentInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitConsumingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapSaledQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIPwithComponet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentOfSaledProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componenteSaledQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentOfFinishedProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componetOfScraptSaledQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumedQtyOfWIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inShopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panTitel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cInvCode,
            this.cInvName,
            this.cInvStd,
            this.bomParentInvCode,
            this.unitConsumingQty,
            this.startQty,
            this.purchaseQty,
            this.saledQty,
            this.finishedProductStock,
            this.scrapSaledQty,
            this.WIPwithComponet,
            this.componentOfSaledProduct,
            this.componenteSaledQty,
            this.componentOfFinishedProductStock,
            this.componetOfScraptSaledQty,
            this.currentQty,
            this.consumedQtyOfWIP,
            this.inShopQty,
            this.checkedQty});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgv.Location = new System.Drawing.Point(12, 266);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1003, 296);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // xmbtnInventoryClass
            // 
            this.xmbtnInventoryClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xmbtnInventoryClass.Location = new System.Drawing.Point(66, 64);
            this.xmbtnInventoryClass.Name = "xmbtnInventoryClass";
            this.xmbtnInventoryClass.Size = new System.Drawing.Size(105, 21);
            this.xmbtnInventoryClass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "账套";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "机加不良品仓库";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "存货分类";
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "018",
            "017"});
            this.cmbAccountNo.Location = new System.Drawing.Point(66, 15);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(105, 20);
            this.cmbAccountNo.TabIndex = 2;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(536, 15);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(157, 20);
            this.cmbWarehouse.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEnd.Location = new System.Drawing.Point(240, 64);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(134, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结束日期";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 19);
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
            this.lblTitel.Location = new System.Drawing.Point(317, 14);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(387, 24);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "车间库存推算表(采购-销售-库存)";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.xmbtnInventoryClass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbWarehouse, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAccountNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpEnd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 100);
            this.tableLayoutPanel1.TabIndex = 5;
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
            // unitConsumingQty
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.unitConsumingQty.DefaultCellStyle = dataGridViewCellStyle19;
            this.unitConsumingQty.HeaderText = "单位消耗量";
            this.unitConsumingQty.Name = "unitConsumingQty";
            // 
            // startQty
            // 
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.startQty.DefaultCellStyle = dataGridViewCellStyle20;
            this.startQty.HeaderText = "期初数量";
            this.startQty.Name = "startQty";
            // 
            // purchaseQty
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.purchaseQty.DefaultCellStyle = dataGridViewCellStyle21;
            this.purchaseQty.HeaderText = "采购入库数";
            this.purchaseQty.Name = "purchaseQty";
            // 
            // saledQty
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.saledQty.DefaultCellStyle = dataGridViewCellStyle22;
            this.saledQty.HeaderText = "成品销售数量";
            this.saledQty.Name = "saledQty";
            this.saledQty.ReadOnly = true;
            // 
            // finishedProductStock
            // 
            this.finishedProductStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.finishedProductStock.DefaultCellStyle = dataGridViewCellStyle23;
            this.finishedProductStock.HeaderText = "成品及返修品库存";
            this.finishedProductStock.Name = "finishedProductStock";
            this.finishedProductStock.ReadOnly = true;
            this.finishedProductStock.Width = 83;
            // 
            // scrapSaledQty
            // 
            this.scrapSaledQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.scrapSaledQty.DefaultCellStyle = dataGridViewCellStyle24;
            this.scrapSaledQty.HeaderText = "机加废品销售数量";
            this.scrapSaledQty.Name = "scrapSaledQty";
            this.scrapSaledQty.ReadOnly = true;
            this.scrapSaledQty.Width = 83;
            // 
            // WIPwithComponet
            // 
            this.WIPwithComponet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.WIPwithComponet.DefaultCellStyle = dataGridViewCellStyle25;
            this.WIPwithComponet.HeaderText = "含子件的在制品数";
            this.WIPwithComponet.Name = "WIPwithComponet";
            this.WIPwithComponet.Width = 83;
            // 
            // componentOfSaledProduct
            // 
            this.componentOfSaledProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.componentOfSaledProduct.DefaultCellStyle = dataGridViewCellStyle26;
            this.componentOfSaledProduct.HeaderText = "销售成品含子件数";
            this.componentOfSaledProduct.Name = "componentOfSaledProduct";
            this.componentOfSaledProduct.ReadOnly = true;
            this.componentOfSaledProduct.Width = 83;
            // 
            // componenteSaledQty
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.componenteSaledQty.DefaultCellStyle = dataGridViewCellStyle27;
            this.componenteSaledQty.HeaderText = "子件直销数";
            this.componenteSaledQty.Name = "componenteSaledQty";
            // 
            // componentOfFinishedProductStock
            // 
            this.componentOfFinishedProductStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = null;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.componentOfFinishedProductStock.DefaultCellStyle = dataGridViewCellStyle28;
            this.componentOfFinishedProductStock.HeaderText = "成品及返修品库存含子件";
            this.componentOfFinishedProductStock.Name = "componentOfFinishedProductStock";
            this.componentOfFinishedProductStock.ReadOnly = true;
            this.componentOfFinishedProductStock.Width = 105;
            // 
            // componetOfScraptSaledQty
            // 
            this.componetOfScraptSaledQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle29.Format = "N2";
            dataGridViewCellStyle29.NullValue = null;
            this.componetOfScraptSaledQty.DefaultCellStyle = dataGridViewCellStyle29;
            this.componetOfScraptSaledQty.HeaderText = "机加废品含子件数";
            this.componetOfScraptSaledQty.Name = "componetOfScraptSaledQty";
            this.componetOfScraptSaledQty.ReadOnly = true;
            this.componetOfScraptSaledQty.Width = 83;
            // 
            // currentQty
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle30.Format = "N2";
            this.currentQty.DefaultCellStyle = dataGridViewCellStyle30;
            this.currentQty.HeaderText = "子件现存量";
            this.currentQty.Name = "currentQty";
            // 
            // consumedQtyOfWIP
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle31.Format = "N2";
            dataGridViewCellStyle31.NullValue = null;
            this.consumedQtyOfWIP.DefaultCellStyle = dataGridViewCellStyle31;
            this.consumedQtyOfWIP.HeaderText = "在制品中的子件数";
            this.consumedQtyOfWIP.Name = "consumedQtyOfWIP";
            // 
            // inShopQty
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            this.inShopQty.DefaultCellStyle = dataGridViewCellStyle32;
            this.inShopQty.HeaderText = "推算车间数量";
            this.inShopQty.Name = "inShopQty";
            // 
            // checkedQty
            // 
            this.checkedQty.HeaderText = "盘点数";
            this.checkedQty.Name = "checkedQty";
            // 
            // FrmInferStockWithPurSubtractSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmInferStockWithPurSubtractSale";
            this.Text = "车间库存推算表(采购减销售)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccountNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn bomParentInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitConsumingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn startQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapSaledQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIPwithComponet;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentOfSaledProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn componenteSaledQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentOfFinishedProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn componetOfScraptSaledQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumedQtyOfWIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn inShopQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedQty;
    }
}