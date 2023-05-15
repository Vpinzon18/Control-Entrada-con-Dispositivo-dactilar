namespace ControlDeEntradaSena2._0
{
    partial class AgregarPersonas
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
            System.Windows.Forms.Label id_PersonaLabel;
            System.Windows.Forms.Label nombre_PersonaLabel;
            System.Windows.Forms.Label apellido_PersonaLabel;
            System.Windows.Forms.Label correo_PersonaLabel;
            System.Windows.Forms.Label celular_PersonaLabel;
            System.Windows.Forms.Label funcionario_PersonaLabel;
            System.Windows.Forms.Label ficha_PersonaLabel;
            System.Windows.Forms.Label direccion_ImagenLabel;
            System.Windows.Forms.Label no_DedoLabel;
            System.Windows.Forms.Label cedula_PersonaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPersonas));
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sistemadeAsistenciaDataSet = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSet();
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASTableAdapter = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.PERSONASTableAdapter();
            this.tableAdapterManager = new ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager();
            this.photo_PersonaPictureBox = new System.Windows.Forms.PictureBox();
            this.id_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.correo_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.celular_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.funcionario_PersonaComboBox = new System.Windows.Forms.ComboBox();
            this.ficha_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.direccion_ImagenTextBox = new System.Windows.Forms.TextBox();
            this.TxtnoDedo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancelar2 = new System.Windows.Forms.Button();
            this.cedula_PersonaTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BfotoAgregar = new System.Windows.Forms.Button();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            id_PersonaLabel = new System.Windows.Forms.Label();
            nombre_PersonaLabel = new System.Windows.Forms.Label();
            apellido_PersonaLabel = new System.Windows.Forms.Label();
            correo_PersonaLabel = new System.Windows.Forms.Label();
            celular_PersonaLabel = new System.Windows.Forms.Label();
            funcionario_PersonaLabel = new System.Windows.Forms.Label();
            ficha_PersonaLabel = new System.Windows.Forms.Label();
            direccion_ImagenLabel = new System.Windows.Forms.Label();
            no_DedoLabel = new System.Windows.Forms.Label();
            cedula_PersonaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeAsistenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_PersonaPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_PersonaLabel
            // 
            id_PersonaLabel.AutoSize = true;
            id_PersonaLabel.Location = new System.Drawing.Point(-8, 42);
            id_PersonaLabel.Name = "id_PersonaLabel";
            id_PersonaLabel.Size = new System.Drawing.Size(61, 13);
            id_PersonaLabel.TabIndex = 71;
            id_PersonaLabel.Text = "Id Persona:";
            // 
            // nombre_PersonaLabel
            // 
            nombre_PersonaLabel.AutoSize = true;
            nombre_PersonaLabel.Location = new System.Drawing.Point(684, 224);
            nombre_PersonaLabel.Name = "nombre_PersonaLabel";
            nombre_PersonaLabel.Size = new System.Drawing.Size(89, 13);
            nombre_PersonaLabel.TabIndex = 75;
            nombre_PersonaLabel.Text = "Nombre Persona:";
            // 
            // apellido_PersonaLabel
            // 
            apellido_PersonaLabel.AutoSize = true;
            apellido_PersonaLabel.Location = new System.Drawing.Point(539, 281);
            apellido_PersonaLabel.Name = "apellido_PersonaLabel";
            apellido_PersonaLabel.Size = new System.Drawing.Size(89, 13);
            apellido_PersonaLabel.TabIndex = 77;
            apellido_PersonaLabel.Text = "Apellido Persona:";
            // 
            // correo_PersonaLabel
            // 
            correo_PersonaLabel.AutoSize = true;
            correo_PersonaLabel.Location = new System.Drawing.Point(690, 281);
            correo_PersonaLabel.Name = "correo_PersonaLabel";
            correo_PersonaLabel.Size = new System.Drawing.Size(83, 13);
            correo_PersonaLabel.TabIndex = 79;
            correo_PersonaLabel.Text = "Correo Persona:";
            // 
            // celular_PersonaLabel
            // 
            celular_PersonaLabel.AutoSize = true;
            celular_PersonaLabel.Location = new System.Drawing.Point(539, 334);
            celular_PersonaLabel.Name = "celular_PersonaLabel";
            celular_PersonaLabel.Size = new System.Drawing.Size(84, 13);
            celular_PersonaLabel.TabIndex = 81;
            celular_PersonaLabel.Text = "Celular Persona:";
            // 
            // funcionario_PersonaLabel
            // 
            funcionario_PersonaLabel.AutoSize = true;
            funcionario_PersonaLabel.Location = new System.Drawing.Point(539, 390);
            funcionario_PersonaLabel.Name = "funcionario_PersonaLabel";
            funcionario_PersonaLabel.Size = new System.Drawing.Size(107, 13);
            funcionario_PersonaLabel.TabIndex = 83;
            funcionario_PersonaLabel.Text = "Funcionario Persona:";
            // 
            // ficha_PersonaLabel
            // 
            ficha_PersonaLabel.AutoSize = true;
            ficha_PersonaLabel.Location = new System.Drawing.Point(695, 334);
            ficha_PersonaLabel.Name = "ficha_PersonaLabel";
            ficha_PersonaLabel.Size = new System.Drawing.Size(78, 13);
            ficha_PersonaLabel.TabIndex = 85;
            ficha_PersonaLabel.Text = "Ficha Persona:";
            // 
            // direccion_ImagenLabel
            // 
            direccion_ImagenLabel.AutoSize = true;
            direccion_ImagenLabel.Location = new System.Drawing.Point(-8, 68);
            direccion_ImagenLabel.Name = "direccion_ImagenLabel";
            direccion_ImagenLabel.Size = new System.Drawing.Size(93, 13);
            direccion_ImagenLabel.TabIndex = 87;
            direccion_ImagenLabel.Text = "Direccion Imagen:";
            // 
            // no_DedoLabel
            // 
            no_DedoLabel.AutoSize = true;
            no_DedoLabel.Location = new System.Drawing.Point(690, 391);
            no_DedoLabel.Name = "no_DedoLabel";
            no_DedoLabel.Size = new System.Drawing.Size(53, 13);
            no_DedoLabel.TabIndex = 91;
            no_DedoLabel.Text = "No Dedo:";
            // 
            // cedula_PersonaLabel
            // 
            cedula_PersonaLabel.AutoSize = true;
            cedula_PersonaLabel.Location = new System.Drawing.Point(538, 224);
            cedula_PersonaLabel.Name = "cedula_PersonaLabel";
            cedula_PersonaLabel.Size = new System.Drawing.Size(85, 13);
            cedula_PersonaLabel.TabIndex = 69;
            cedula_PersonaLabel.Text = "Cedula Persona:";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(0, 47);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 0;
            this.enrollmentControl1.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollmentControl1_OnDelete);
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 41);
            this.panel1.TabIndex = 68;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(845, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 41);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 38;
            this.label3.Text = "Agregar Persona";
            // 
            // sistemadeAsistenciaDataSet
            // 
            this.sistemadeAsistenciaDataSet.DataSetName = "SistemadeAsistenciaDataSet";
            this.sistemadeAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            this.pERSONASBindingSource.DataSource = this.sistemadeAsistenciaDataSet;
            // 
            // pERSONASTableAdapter
            // 
            this.pERSONASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASISTENCIA_HUELLATableAdapter = null;
            this.tableAdapterManager.ASISTENCIATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PERSONASTableAdapter = this.pERSONASTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControlDeEntradaSena2._0.SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // photo_PersonaPictureBox
            // 
            this.photo_PersonaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photo_PersonaPictureBox.Location = new System.Drawing.Point(541, 57);
            this.photo_PersonaPictureBox.Name = "photo_PersonaPictureBox";
            this.photo_PersonaPictureBox.Size = new System.Drawing.Size(132, 137);
            this.photo_PersonaPictureBox.TabIndex = 71;
            this.photo_PersonaPictureBox.TabStop = false;
            // 
            // id_PersonaTextBox
            // 
            this.id_PersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONASBindingSource, "Id_Persona", true));
            this.id_PersonaTextBox.Location = new System.Drawing.Point(105, 39);
            this.id_PersonaTextBox.Name = "id_PersonaTextBox";
            this.id_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_PersonaTextBox.TabIndex = 72;
            // 
            // nombre_PersonaTextBox
            // 
            this.nombre_PersonaTextBox.Location = new System.Drawing.Point(687, 240);
            this.nombre_PersonaTextBox.Name = "nombre_PersonaTextBox";
            this.nombre_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombre_PersonaTextBox.TabIndex = 76;
            // 
            // apellido_PersonaTextBox
            // 
            this.apellido_PersonaTextBox.Location = new System.Drawing.Point(541, 297);
            this.apellido_PersonaTextBox.Name = "apellido_PersonaTextBox";
            this.apellido_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellido_PersonaTextBox.TabIndex = 78;
            // 
            // correo_PersonaTextBox
            // 
            this.correo_PersonaTextBox.Location = new System.Drawing.Point(687, 297);
            this.correo_PersonaTextBox.Name = "correo_PersonaTextBox";
            this.correo_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.correo_PersonaTextBox.TabIndex = 80;
            // 
            // celular_PersonaTextBox
            // 
            this.celular_PersonaTextBox.Location = new System.Drawing.Point(542, 350);
            this.celular_PersonaTextBox.Name = "celular_PersonaTextBox";
            this.celular_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.celular_PersonaTextBox.TabIndex = 82;
            this.celular_PersonaTextBox.TextChanged += new System.EventHandler(this.celular_PersonaTextBox_TextChanged);
            // 
            // funcionario_PersonaComboBox
            // 
            this.funcionario_PersonaComboBox.FormattingEnabled = true;
            this.funcionario_PersonaComboBox.Items.AddRange(new object[] {
            "Instructor",
            "Aprendiz"});
            this.funcionario_PersonaComboBox.Location = new System.Drawing.Point(542, 406);
            this.funcionario_PersonaComboBox.Name = "funcionario_PersonaComboBox";
            this.funcionario_PersonaComboBox.Size = new System.Drawing.Size(121, 21);
            this.funcionario_PersonaComboBox.TabIndex = 84;
            this.funcionario_PersonaComboBox.SelectedIndexChanged += new System.EventHandler(this.funcionario_PersonaComboBox_SelectedIndexChanged);
            this.funcionario_PersonaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcionario_PersonaComboBox_KeyPress);
            // 
            // ficha_PersonaTextBox
            // 
            this.ficha_PersonaTextBox.Location = new System.Drawing.Point(687, 350);
            this.ficha_PersonaTextBox.Name = "ficha_PersonaTextBox";
            this.ficha_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.ficha_PersonaTextBox.TabIndex = 86;
            // 
            // direccion_ImagenTextBox
            // 
            this.direccion_ImagenTextBox.Location = new System.Drawing.Point(105, 65);
            this.direccion_ImagenTextBox.Name = "direccion_ImagenTextBox";
            this.direccion_ImagenTextBox.Size = new System.Drawing.Size(121, 20);
            this.direccion_ImagenTextBox.TabIndex = 88;
            // 
            // TxtnoDedo
            // 
            this.TxtnoDedo.Location = new System.Drawing.Point(687, 407);
            this.TxtnoDedo.Name = "TxtnoDedo";
            this.TxtnoDedo.Size = new System.Drawing.Size(121, 20);
            this.TxtnoDedo.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.id_PersonaTextBox);
            this.panel2.Controls.Add(id_PersonaLabel);
            this.panel2.Controls.Add(this.direccion_ImagenTextBox);
            this.panel2.Controls.Add(direccion_ImagenLabel);
            this.panel2.Location = new System.Drawing.Point(76, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 94;
            // 
            // btncancelar2
            // 
            this.btncancelar2.Location = new System.Drawing.Point(704, 472);
            this.btncancelar2.Name = "btncancelar2";
            this.btncancelar2.Size = new System.Drawing.Size(75, 23);
            this.btncancelar2.TabIndex = 101;
            this.btncancelar2.Text = "Cancelar";
            this.btncancelar2.UseVisualStyleBackColor = true;
            this.btncancelar2.Click += new System.EventHandler(this.btncancelar2_Click);
            // 
            // cedula_PersonaTextBox
            // 
            this.cedula_PersonaTextBox.Location = new System.Drawing.Point(541, 240);
            this.cedula_PersonaTextBox.Name = "cedula_PersonaTextBox";
            this.cedula_PersonaTextBox.Size = new System.Drawing.Size(121, 20);
            this.cedula_PersonaTextBox.TabIndex = 70;
            this.cedula_PersonaTextBox.TextChanged += new System.EventHandler(this.cedula_PersonaTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::ControlDeEntradaSena2._0.Properties.Resources.icons8_denied_30;
            this.button3.Location = new System.Drawing.Point(730, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 44);
            this.button3.TabIndex = 103;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BfotoAgregar
            // 
            this.BfotoAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BfotoAgregar.FlatAppearance.BorderSize = 0;
            this.BfotoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BfotoAgregar.Image = global::ControlDeEntradaSena2._0.Properties.Resources.icons8_add_user_male_30;
            this.BfotoAgregar.Location = new System.Drawing.Point(730, 57);
            this.BfotoAgregar.Name = "BfotoAgregar";
            this.BfotoAgregar.Size = new System.Drawing.Size(54, 49);
            this.BfotoAgregar.TabIndex = 102;
            this.BfotoAgregar.UseVisualStyleBackColor = true;
            this.BfotoAgregar.Click += new System.EventHandler(this.BfotoAgregar_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.MintCream;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Cancelar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.MintCream;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.Location = new System.Drawing.Point(685, 454);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(99, 41);
            this.bunifuThinButton22.TabIndex = 105;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.MintCream;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Guardar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.MintCream;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(576, 454);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(99, 41);
            this.bunifuThinButton21.TabIndex = 104;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // AgregarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BfotoAgregar);
            this.Controls.Add(this.btncancelar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombre_PersonaLabel);
            this.Controls.Add(this.nombre_PersonaTextBox);
            this.Controls.Add(apellido_PersonaLabel);
            this.Controls.Add(this.apellido_PersonaTextBox);
            this.Controls.Add(correo_PersonaLabel);
            this.Controls.Add(this.correo_PersonaTextBox);
            this.Controls.Add(celular_PersonaLabel);
            this.Controls.Add(this.celular_PersonaTextBox);
            this.Controls.Add(funcionario_PersonaLabel);
            this.Controls.Add(this.funcionario_PersonaComboBox);
            this.Controls.Add(ficha_PersonaLabel);
            this.Controls.Add(this.ficha_PersonaTextBox);
            this.Controls.Add(no_DedoLabel);
            this.Controls.Add(this.TxtnoDedo);
            this.Controls.Add(this.photo_PersonaPictureBox);
            this.Controls.Add(cedula_PersonaLabel);
            this.Controls.Add(this.cedula_PersonaTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enrollmentControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPersonas";
            this.Load += new System.EventHandler(this.AgregarPersonas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeAsistenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_PersonaPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private SistemadeAsistenciaDataSet sistemadeAsistenciaDataSet;
        private System.Windows.Forms.BindingSource pERSONASBindingSource;
        private SistemadeAsistenciaDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter;
        private SistemadeAsistenciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox photo_PersonaPictureBox;
        private System.Windows.Forms.TextBox id_PersonaTextBox;
        private System.Windows.Forms.TextBox nombre_PersonaTextBox;
        private System.Windows.Forms.TextBox apellido_PersonaTextBox;
        private System.Windows.Forms.TextBox correo_PersonaTextBox;
        private System.Windows.Forms.TextBox celular_PersonaTextBox;
        private System.Windows.Forms.ComboBox funcionario_PersonaComboBox;
        private System.Windows.Forms.TextBox ficha_PersonaTextBox;
        private System.Windows.Forms.TextBox direccion_ImagenTextBox;
        private System.Windows.Forms.TextBox TxtnoDedo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btncancelar2;
        private System.Windows.Forms.TextBox cedula_PersonaTextBox;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button BfotoAgregar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}