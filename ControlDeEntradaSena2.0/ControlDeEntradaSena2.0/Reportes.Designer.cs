namespace ControlDeEntradaSena2._0
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.txtDocumento = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Btnmodificarb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.sistemadeAsistenciaDataSet = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSet();
            this.aSISTENCIAHUELLABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSISTENCIA_HUELLATableAdapter = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.ASISTENCIA_HUELLATableAdapter();
            this.aSISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSISTENCIATableAdapter = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.ASISTENCIATableAdapter();
            this.tableAdapterManager = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager();
            this.DGVreportes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeAsistenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIAHUELLABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVreportes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 61);
            this.panel2.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Personas del Sistema";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(752, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 61);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtNombre.Location = new System.Drawing.Point(53, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 72;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(49, 74);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(124, 19);
            this.LblNombre.TabIndex = 74;
            this.LblNombre.Text = "Nombre de Admin";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtDocumento.Location = new System.Drawing.Point(247, 100);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(157, 20);
            this.txtDocumento.TabIndex = 75;
            // 
            // Btnmodificarb
            // 
            this.Btnmodificarb.ActiveBorderThickness = 1;
            this.Btnmodificarb.ActiveCornerRadius = 20;
            this.Btnmodificarb.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.Btnmodificarb.ActiveForecolor = System.Drawing.Color.MintCream;
            this.Btnmodificarb.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.Btnmodificarb.BackColor = System.Drawing.SystemColors.Control;
            this.Btnmodificarb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnmodificarb.BackgroundImage")));
            this.Btnmodificarb.ButtonText = "Imprimir";
            this.Btnmodificarb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnmodificarb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmodificarb.ForeColor = System.Drawing.Color.White;
            this.Btnmodificarb.IdleBorderThickness = 1;
            this.Btnmodificarb.IdleCornerRadius = 20;
            this.Btnmodificarb.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.Btnmodificarb.IdleForecolor = System.Drawing.Color.MintCream;
            this.Btnmodificarb.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.Btnmodificarb.Location = new System.Drawing.Point(357, 395);
            this.Btnmodificarb.Margin = new System.Windows.Forms.Padding(5);
            this.Btnmodificarb.Name = "Btnmodificarb";
            this.Btnmodificarb.Size = new System.Drawing.Size(99, 41);
            this.Btnmodificarb.TabIndex = 77;
            this.Btnmodificarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btnmodificarb.Click += new System.EventHandler(this.Btnmodificarb_Click);
            // 
            // sistemadeAsistenciaDataSet
            // 
            this.sistemadeAsistenciaDataSet.DataSetName = "SistemadeAsistenciaDataSet";
            this.sistemadeAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSISTENCIAHUELLABindingSource
            // 
            this.aSISTENCIAHUELLABindingSource.DataMember = "ASISTENCIA_HUELLA";
            this.aSISTENCIAHUELLABindingSource.DataSource = this.sistemadeAsistenciaDataSet;
            // 
            // aSISTENCIA_HUELLATableAdapter
            // 
            this.aSISTENCIA_HUELLATableAdapter.ClearBeforeFill = true;
            // 
            // aSISTENCIABindingSource
            // 
            this.aSISTENCIABindingSource.DataMember = "ASISTENCIA";
            this.aSISTENCIABindingSource.DataSource = this.sistemadeAsistenciaDataSet;
            // 
            // aSISTENCIATableAdapter
            // 
            this.aSISTENCIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASISTENCIA_HUELLATableAdapter = this.aSISTENCIA_HUELLATableAdapter;
            this.tableAdapterManager.ASISTENCIATableAdapter = this.aSISTENCIATableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PERSONASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // DGVreportes
            // 
            this.DGVreportes.AllowUserToAddRows = false;
            this.DGVreportes.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGVreportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVreportes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVreportes.Location = new System.Drawing.Point(125, 148);
            this.DGVreportes.Name = "DGVreportes";
            this.DGVreportes.Size = new System.Drawing.Size(562, 239);
            this.DGVreportes.TabIndex = 78;
            this.DGVreportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVreportes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Cedula de Admin";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVreportes);
            this.Controls.Add(this.Btnmodificarb);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeAsistenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIAHUELLABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVreportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LblNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 Btnmodificarb;
        private SistemadeAsistenciaDataSet sistemadeAsistenciaDataSet;
        private System.Windows.Forms.BindingSource aSISTENCIAHUELLABindingSource;
        private SistemadeAsistenciaDataSetTableAdapters.ASISTENCIA_HUELLATableAdapter aSISTENCIA_HUELLATableAdapter;
        private System.Windows.Forms.BindingSource aSISTENCIABindingSource;
        private SistemadeAsistenciaDataSetTableAdapters.ASISTENCIATableAdapter aSISTENCIATableAdapter;
        private SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtDocumento;
        public System.Windows.Forms.DataGridView DGVreportes;
        private System.Windows.Forms.Label label2;
    }
}