namespace FormGanado
{
    partial class FormGestionGanado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionGanado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistroRancho = new System.Windows.Forms.Label();
            this.lblRegistroPropietario = new System.Windows.Forms.Label();
            this.cbxRegistroRancho = new System.Windows.Forms.ComboBox();
            this.cbxRegistroPropietario = new System.Windows.Forms.ComboBox();
            this.tlpRegistroRancho = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistroTipoGanado = new System.Windows.Forms.Label();
            this.lblRegistroRaza = new System.Windows.Forms.Label();
            this.lblRegistroMarquilla = new System.Windows.Forms.Label();
            this.lblRegistroDescripcion = new System.Windows.Forms.Label();
            this.lblRegistroFechaNacimiento = new System.Windows.Forms.Label();
            this.lblRegistroPeso = new System.Windows.Forms.Label();
            this.cbxRegistroTipoGanado = new System.Windows.Forms.ComboBox();
            this.cbxRegistroRaza = new System.Windows.Forms.ComboBox();
            this.txtRegistroMarquilla = new System.Windows.Forms.TextBox();
            this.rtbRegistroDescipcion = new System.Windows.Forms.RichTextBox();
            this.dtpRegistroFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRegistroPeso = new System.Windows.Forms.TextBox();
            this.tlpRegistroGanado = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistroValorVentaKgP = new System.Windows.Forms.Label();
            this.txtRegistroValorVentaKgP = new System.Windows.Forms.TextBox();
            this.tcRegistro = new System.Windows.Forms.TabControl();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.pRegistroContenedor = new System.Windows.Forms.Panel();
            this.pRegistroContenedorS7 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pRegistroContenedorS6 = new System.Windows.Forms.Panel();
            this.pRegistroContenedorS5 = new System.Windows.Forms.Panel();
            this.tlpRegistroValor = new System.Windows.Forms.TableLayoutPanel();
            this.pRegistroContenedorS4 = new System.Windows.Forms.Panel();
            this.pRegistroContenedorS3 = new System.Windows.Forms.Panel();
            this.pRegistroContenedorS2 = new System.Windows.Forms.Panel();
            this.pRegistroContenedorS1 = new System.Windows.Forms.Panel();
            this.pFooter = new System.Windows.Forms.Panel();
            this.lblFooterNombre = new System.Windows.Forms.Label();
            this.tpRegistros = new System.Windows.Forms.TabPage();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.tlpRegistroRancho.SuspendLayout();
            this.tlpRegistroGanado.SuspendLayout();
            this.tcRegistro.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.pRegistroContenedor.SuspendLayout();
            this.pRegistroContenedorS7.SuspendLayout();
            this.pRegistroContenedorS5.SuspendLayout();
            this.tlpRegistroValor.SuspendLayout();
            this.pRegistroContenedorS3.SuspendLayout();
            this.pRegistroContenedorS1.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.tpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroRancho
            // 
            this.lblRegistroRancho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroRancho.AutoSize = true;
            this.lblRegistroRancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroRancho.ForeColor = System.Drawing.Color.White;
            this.lblRegistroRancho.Location = new System.Drawing.Point(139, 8);
            this.lblRegistroRancho.Name = "lblRegistroRancho";
            this.lblRegistroRancho.Size = new System.Drawing.Size(76, 24);
            this.lblRegistroRancho.TabIndex = 0;
            this.lblRegistroRancho.Text = "Rancho";
            // 
            // lblRegistroPropietario
            // 
            this.lblRegistroPropietario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroPropietario.AutoSize = true;
            this.lblRegistroPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroPropietario.ForeColor = System.Drawing.Color.White;
            this.lblRegistroPropietario.Location = new System.Drawing.Point(115, 48);
            this.lblRegistroPropietario.Name = "lblRegistroPropietario";
            this.lblRegistroPropietario.Size = new System.Drawing.Size(100, 24);
            this.lblRegistroPropietario.TabIndex = 1;
            this.lblRegistroPropietario.Text = "Propietario";
            // 
            // cbxRegistroRancho
            // 
            this.cbxRegistroRancho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRegistroRancho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRegistroRancho.FormattingEnabled = true;
            this.cbxRegistroRancho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxRegistroRancho.Location = new System.Drawing.Point(221, 9);
            this.cbxRegistroRancho.Name = "cbxRegistroRancho";
            this.cbxRegistroRancho.Size = new System.Drawing.Size(321, 21);
            this.cbxRegistroRancho.TabIndex = 2;
            this.cbxRegistroRancho.SelectedIndexChanged += new System.EventHandler(this.cbxRegistroRancho_SelectedIndexChanged);
            // 
            // cbxRegistroPropietario
            // 
            this.cbxRegistroPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRegistroPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRegistroPropietario.FormattingEnabled = true;
            this.cbxRegistroPropietario.Location = new System.Drawing.Point(221, 49);
            this.cbxRegistroPropietario.Name = "cbxRegistroPropietario";
            this.cbxRegistroPropietario.Size = new System.Drawing.Size(321, 21);
            this.cbxRegistroPropietario.TabIndex = 3;
            // 
            // tlpRegistroRancho
            // 
            this.tlpRegistroRancho.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegistroRancho.ColumnCount = 2;
            this.tlpRegistroRancho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRegistroRancho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpRegistroRancho.Controls.Add(this.cbxRegistroPropietario, 1, 1);
            this.tlpRegistroRancho.Controls.Add(this.cbxRegistroRancho, 1, 0);
            this.tlpRegistroRancho.Controls.Add(this.lblRegistroRancho, 0, 0);
            this.tlpRegistroRancho.Controls.Add(this.lblRegistroPropietario, 0, 1);
            this.tlpRegistroRancho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistroRancho.Location = new System.Drawing.Point(0, 0);
            this.tlpRegistroRancho.Name = "tlpRegistroRancho";
            this.tlpRegistroRancho.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlpRegistroRancho.RowCount = 2;
            this.tlpRegistroRancho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegistroRancho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegistroRancho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRegistroRancho.Size = new System.Drawing.Size(555, 80);
            this.tlpRegistroRancho.TabIndex = 6;
            // 
            // lblRegistroTipoGanado
            // 
            this.lblRegistroTipoGanado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroTipoGanado.AutoSize = true;
            this.lblRegistroTipoGanado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroTipoGanado.ForeColor = System.Drawing.Color.White;
            this.lblRegistroTipoGanado.Location = new System.Drawing.Point(71, 8);
            this.lblRegistroTipoGanado.Name = "lblRegistroTipoGanado";
            this.lblRegistroTipoGanado.Size = new System.Drawing.Size(144, 24);
            this.lblRegistroTipoGanado.TabIndex = 7;
            this.lblRegistroTipoGanado.Text = "Tipo de ganado";
            // 
            // lblRegistroRaza
            // 
            this.lblRegistroRaza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroRaza.AutoSize = true;
            this.lblRegistroRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroRaza.ForeColor = System.Drawing.Color.White;
            this.lblRegistroRaza.Location = new System.Drawing.Point(163, 48);
            this.lblRegistroRaza.Name = "lblRegistroRaza";
            this.lblRegistroRaza.Size = new System.Drawing.Size(52, 24);
            this.lblRegistroRaza.TabIndex = 8;
            this.lblRegistroRaza.Text = "Raza";
            // 
            // lblRegistroMarquilla
            // 
            this.lblRegistroMarquilla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroMarquilla.AutoSize = true;
            this.lblRegistroMarquilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroMarquilla.ForeColor = System.Drawing.Color.White;
            this.lblRegistroMarquilla.Location = new System.Drawing.Point(129, 88);
            this.lblRegistroMarquilla.Name = "lblRegistroMarquilla";
            this.lblRegistroMarquilla.Size = new System.Drawing.Size(86, 24);
            this.lblRegistroMarquilla.TabIndex = 9;
            this.lblRegistroMarquilla.Text = "Marquilla";
            // 
            // lblRegistroDescripcion
            // 
            this.lblRegistroDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroDescripcion.AutoSize = true;
            this.lblRegistroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblRegistroDescripcion.Location = new System.Drawing.Point(105, 128);
            this.lblRegistroDescripcion.Name = "lblRegistroDescripcion";
            this.lblRegistroDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblRegistroDescripcion.TabIndex = 10;
            this.lblRegistroDescripcion.Text = "Descripción";
            // 
            // lblRegistroFechaNacimiento
            // 
            this.lblRegistroFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroFechaNacimiento.AutoSize = true;
            this.lblRegistroFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblRegistroFechaNacimiento.Location = new System.Drawing.Point(27, 168);
            this.lblRegistroFechaNacimiento.Name = "lblRegistroFechaNacimiento";
            this.lblRegistroFechaNacimiento.Size = new System.Drawing.Size(188, 24);
            this.lblRegistroFechaNacimiento.TabIndex = 11;
            this.lblRegistroFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblRegistroPeso
            // 
            this.lblRegistroPeso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroPeso.AutoSize = true;
            this.lblRegistroPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroPeso.ForeColor = System.Drawing.Color.White;
            this.lblRegistroPeso.Location = new System.Drawing.Point(134, 208);
            this.lblRegistroPeso.Name = "lblRegistroPeso";
            this.lblRegistroPeso.Size = new System.Drawing.Size(81, 24);
            this.lblRegistroPeso.TabIndex = 12;
            this.lblRegistroPeso.Text = "Peso Kg";
            // 
            // cbxRegistroTipoGanado
            // 
            this.cbxRegistroTipoGanado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRegistroTipoGanado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRegistroTipoGanado.FormattingEnabled = true;
            this.cbxRegistroTipoGanado.Location = new System.Drawing.Point(221, 9);
            this.cbxRegistroTipoGanado.Name = "cbxRegistroTipoGanado";
            this.cbxRegistroTipoGanado.Size = new System.Drawing.Size(321, 21);
            this.cbxRegistroTipoGanado.TabIndex = 13;
            this.cbxRegistroTipoGanado.SelectedIndexChanged += new System.EventHandler(this.cbxRegistroTipoGanado_SelectedIndexChanged);
            // 
            // cbxRegistroRaza
            // 
            this.cbxRegistroRaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRegistroRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRegistroRaza.FormattingEnabled = true;
            this.cbxRegistroRaza.Location = new System.Drawing.Point(221, 49);
            this.cbxRegistroRaza.Name = "cbxRegistroRaza";
            this.cbxRegistroRaza.Size = new System.Drawing.Size(321, 21);
            this.cbxRegistroRaza.TabIndex = 14;
            // 
            // txtRegistroMarquilla
            // 
            this.txtRegistroMarquilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistroMarquilla.Location = new System.Drawing.Point(221, 90);
            this.txtRegistroMarquilla.Name = "txtRegistroMarquilla";
            this.txtRegistroMarquilla.Size = new System.Drawing.Size(321, 20);
            this.txtRegistroMarquilla.TabIndex = 15;
            // 
            // rtbRegistroDescipcion
            // 
            this.rtbRegistroDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRegistroDescipcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRegistroDescipcion.Location = new System.Drawing.Point(221, 123);
            this.rtbRegistroDescipcion.Name = "rtbRegistroDescipcion";
            this.rtbRegistroDescipcion.Size = new System.Drawing.Size(321, 34);
            this.rtbRegistroDescipcion.TabIndex = 17;
            this.rtbRegistroDescipcion.Text = "";
            // 
            // dtpRegistroFechaNacimiento
            // 
            this.dtpRegistroFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegistroFechaNacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpRegistroFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpRegistroFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistroFechaNacimiento.Location = new System.Drawing.Point(221, 170);
            this.dtpRegistroFechaNacimiento.Name = "dtpRegistroFechaNacimiento";
            this.dtpRegistroFechaNacimiento.Size = new System.Drawing.Size(321, 20);
            this.dtpRegistroFechaNacimiento.TabIndex = 18;
            // 
            // txtRegistroPeso
            // 
            this.txtRegistroPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistroPeso.Location = new System.Drawing.Point(221, 210);
            this.txtRegistroPeso.Name = "txtRegistroPeso";
            this.txtRegistroPeso.Size = new System.Drawing.Size(321, 20);
            this.txtRegistroPeso.TabIndex = 19;
            // 
            // tlpRegistroGanado
            // 
            this.tlpRegistroGanado.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegistroGanado.ColumnCount = 2;
            this.tlpRegistroGanado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRegistroGanado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroTipoGanado, 0, 0);
            this.tlpRegistroGanado.Controls.Add(this.txtRegistroPeso, 1, 5);
            this.tlpRegistroGanado.Controls.Add(this.cbxRegistroTipoGanado, 1, 0);
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroPeso, 0, 5);
            this.tlpRegistroGanado.Controls.Add(this.dtpRegistroFechaNacimiento, 1, 4);
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroRaza, 0, 1);
            this.tlpRegistroGanado.Controls.Add(this.rtbRegistroDescipcion, 1, 3);
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroFechaNacimiento, 0, 4);
            this.tlpRegistroGanado.Controls.Add(this.cbxRegistroRaza, 1, 1);
            this.tlpRegistroGanado.Controls.Add(this.txtRegistroMarquilla, 1, 2);
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroMarquilla, 0, 2);
            this.tlpRegistroGanado.Controls.Add(this.lblRegistroDescripcion, 0, 3);
            this.tlpRegistroGanado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistroGanado.Location = new System.Drawing.Point(0, 0);
            this.tlpRegistroGanado.Name = "tlpRegistroGanado";
            this.tlpRegistroGanado.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlpRegistroGanado.RowCount = 6;
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistroGanado.Size = new System.Drawing.Size(555, 240);
            this.tlpRegistroGanado.TabIndex = 20;
            // 
            // lblRegistroValorVentaKgP
            // 
            this.lblRegistroValorVentaKgP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegistroValorVentaKgP.AutoSize = true;
            this.lblRegistroValorVentaKgP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistroValorVentaKgP.ForeColor = System.Drawing.Color.White;
            this.lblRegistroValorVentaKgP.Location = new System.Drawing.Point(8, 8);
            this.lblRegistroValorVentaKgP.Name = "lblRegistroValorVentaKgP";
            this.lblRegistroValorVentaKgP.Size = new System.Drawing.Size(207, 24);
            this.lblRegistroValorVentaKgP.TabIndex = 22;
            this.lblRegistroValorVentaKgP.Text = "Valor de venta por Kg%";
            // 
            // txtRegistroValorVentaKgP
            // 
            this.txtRegistroValorVentaKgP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistroValorVentaKgP.Location = new System.Drawing.Point(221, 10);
            this.txtRegistroValorVentaKgP.Name = "txtRegistroValorVentaKgP";
            this.txtRegistroValorVentaKgP.Size = new System.Drawing.Size(321, 20);
            this.txtRegistroValorVentaKgP.TabIndex = 24;
            // 
            // tcRegistro
            // 
            this.tcRegistro.Controls.Add(this.tpRegistro);
            this.tcRegistro.Controls.Add(this.tpRegistros);
            this.tcRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRegistro.Location = new System.Drawing.Point(0, 0);
            this.tcRegistro.Name = "tcRegistro";
            this.tcRegistro.SelectedIndex = 0;
            this.tcRegistro.Size = new System.Drawing.Size(1264, 681);
            this.tcRegistro.TabIndex = 26;
            // 
            // tpRegistro
            // 
            this.tpRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpRegistro.BackgroundImage")));
            this.tpRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpRegistro.Controls.Add(this.pRegistroContenedor);
            this.tpRegistro.Controls.Add(this.pFooter);
            this.tpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(1256, 655);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "Registro";
            this.tpRegistro.UseVisualStyleBackColor = true;
            // 
            // pRegistroContenedor
            // 
            this.pRegistroContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS7);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS6);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS5);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS4);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS3);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS2);
            this.pRegistroContenedor.Controls.Add(this.pRegistroContenedorS1);
            this.pRegistroContenedor.Location = new System.Drawing.Point(355, 58);
            this.pRegistroContenedor.Name = "pRegistroContenedor";
            this.pRegistroContenedor.Size = new System.Drawing.Size(555, 500);
            this.pRegistroContenedor.TabIndex = 30;
            // 
            // pRegistroContenedorS7
            // 
            this.pRegistroContenedorS7.BackColor = System.Drawing.Color.Transparent;
            this.pRegistroContenedorS7.Controls.Add(this.btnRegistro);
            this.pRegistroContenedorS7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS7.Location = new System.Drawing.Point(0, 420);
            this.pRegistroContenedorS7.Name = "pRegistroContenedorS7";
            this.pRegistroContenedorS7.Size = new System.Drawing.Size(555, 68);
            this.pRegistroContenedorS7.TabIndex = 32;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(217, 14);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(120, 42);
            this.btnRegistro.TabIndex = 28;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // pRegistroContenedorS6
            // 
            this.pRegistroContenedorS6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS6.Location = new System.Drawing.Point(0, 400);
            this.pRegistroContenedorS6.Name = "pRegistroContenedorS6";
            this.pRegistroContenedorS6.Size = new System.Drawing.Size(555, 20);
            this.pRegistroContenedorS6.TabIndex = 32;
            // 
            // pRegistroContenedorS5
            // 
            this.pRegistroContenedorS5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(252)))));
            this.pRegistroContenedorS5.Controls.Add(this.tlpRegistroValor);
            this.pRegistroContenedorS5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS5.Location = new System.Drawing.Point(0, 360);
            this.pRegistroContenedorS5.Name = "pRegistroContenedorS5";
            this.pRegistroContenedorS5.Size = new System.Drawing.Size(555, 40);
            this.pRegistroContenedorS5.TabIndex = 32;
            // 
            // tlpRegistroValor
            // 
            this.tlpRegistroValor.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegistroValor.ColumnCount = 2;
            this.tlpRegistroValor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRegistroValor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpRegistroValor.Controls.Add(this.lblRegistroValorVentaKgP, 0, 0);
            this.tlpRegistroValor.Controls.Add(this.txtRegistroValorVentaKgP, 1, 0);
            this.tlpRegistroValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistroValor.Location = new System.Drawing.Point(0, 0);
            this.tlpRegistroValor.Name = "tlpRegistroValor";
            this.tlpRegistroValor.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlpRegistroValor.RowCount = 1;
            this.tlpRegistroValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRegistroValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRegistroValor.Size = new System.Drawing.Size(555, 40);
            this.tlpRegistroValor.TabIndex = 29;
            // 
            // pRegistroContenedorS4
            // 
            this.pRegistroContenedorS4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS4.Location = new System.Drawing.Point(0, 340);
            this.pRegistroContenedorS4.Name = "pRegistroContenedorS4";
            this.pRegistroContenedorS4.Size = new System.Drawing.Size(555, 20);
            this.pRegistroContenedorS4.TabIndex = 32;
            // 
            // pRegistroContenedorS3
            // 
            this.pRegistroContenedorS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(248)))), ((int)(((byte)(178)))), ((int)(((byte)(142)))));
            this.pRegistroContenedorS3.Controls.Add(this.tlpRegistroGanado);
            this.pRegistroContenedorS3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS3.Location = new System.Drawing.Point(0, 100);
            this.pRegistroContenedorS3.Name = "pRegistroContenedorS3";
            this.pRegistroContenedorS3.Size = new System.Drawing.Size(555, 240);
            this.pRegistroContenedorS3.TabIndex = 32;
            // 
            // pRegistroContenedorS2
            // 
            this.pRegistroContenedorS2.BackColor = System.Drawing.Color.Transparent;
            this.pRegistroContenedorS2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS2.Location = new System.Drawing.Point(0, 80);
            this.pRegistroContenedorS2.Name = "pRegistroContenedorS2";
            this.pRegistroContenedorS2.Size = new System.Drawing.Size(555, 20);
            this.pRegistroContenedorS2.TabIndex = 31;
            // 
            // pRegistroContenedorS1
            // 
            this.pRegistroContenedorS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(28)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.pRegistroContenedorS1.Controls.Add(this.tlpRegistroRancho);
            this.pRegistroContenedorS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroContenedorS1.Location = new System.Drawing.Point(0, 0);
            this.pRegistroContenedorS1.Name = "pRegistroContenedorS1";
            this.pRegistroContenedorS1.Size = new System.Drawing.Size(555, 80);
            this.pRegistroContenedorS1.TabIndex = 31;
            // 
            // pFooter
            // 
            this.pFooter.Controls.Add(this.lblFooterNombre);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(3, 617);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1250, 35);
            this.pFooter.TabIndex = 26;
            // 
            // lblFooterNombre
            // 
            this.lblFooterNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterNombre.AutoSize = true;
            this.lblFooterNombre.ForeColor = System.Drawing.Color.White;
            this.lblFooterNombre.Location = new System.Drawing.Point(551, 11);
            this.lblFooterNombre.Name = "lblFooterNombre";
            this.lblFooterNombre.Size = new System.Drawing.Size(155, 13);
            this.lblFooterNombre.TabIndex = 27;
            this.lblFooterNombre.Text = "©Andres Fabian Baron Morales";
            // 
            // tpRegistros
            // 
            this.tpRegistros.Controls.Add(this.dgvRegistros);
            this.tpRegistros.Location = new System.Drawing.Point(4, 22);
            this.tpRegistros.Name = "tpRegistros";
            this.tpRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistros.Size = new System.Drawing.Size(1256, 655);
            this.tpRegistros.TabIndex = 1;
            this.tpRegistros.Text = "Registros";
            this.tpRegistros.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(206)))));
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(178)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(206)))));
            this.dgvRegistros.Location = new System.Drawing.Point(3, 3);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowTemplate.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(1250, 649);
            this.dgvRegistros.TabIndex = 0;
            // 
            // FormGestionGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tcRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionGanado";
            this.Text = "Gestión de ganado";
            this.tlpRegistroRancho.ResumeLayout(false);
            this.tlpRegistroRancho.PerformLayout();
            this.tlpRegistroGanado.ResumeLayout(false);
            this.tlpRegistroGanado.PerformLayout();
            this.tcRegistro.ResumeLayout(false);
            this.tpRegistro.ResumeLayout(false);
            this.pRegistroContenedor.ResumeLayout(false);
            this.pRegistroContenedorS7.ResumeLayout(false);
            this.pRegistroContenedorS5.ResumeLayout(false);
            this.tlpRegistroValor.ResumeLayout(false);
            this.tlpRegistroValor.PerformLayout();
            this.pRegistroContenedorS3.ResumeLayout(false);
            this.pRegistroContenedorS1.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.tpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroRancho;
        private System.Windows.Forms.Label lblRegistroPropietario;
        private System.Windows.Forms.ComboBox cbxRegistroRancho;
        private System.Windows.Forms.ComboBox cbxRegistroPropietario;
        private System.Windows.Forms.TableLayoutPanel tlpRegistroRancho;
        private System.Windows.Forms.Label lblRegistroTipoGanado;
        private System.Windows.Forms.Label lblRegistroRaza;
        private System.Windows.Forms.Label lblRegistroMarquilla;
        private System.Windows.Forms.Label lblRegistroDescripcion;
        private System.Windows.Forms.Label lblRegistroFechaNacimiento;
        private System.Windows.Forms.Label lblRegistroPeso;
        private System.Windows.Forms.ComboBox cbxRegistroTipoGanado;
        private System.Windows.Forms.ComboBox cbxRegistroRaza;
        private System.Windows.Forms.TextBox txtRegistroMarquilla;
        private System.Windows.Forms.RichTextBox rtbRegistroDescipcion;
        private System.Windows.Forms.DateTimePicker dtpRegistroFechaNacimiento;
        private System.Windows.Forms.TextBox txtRegistroPeso;
        private System.Windows.Forms.TableLayoutPanel tlpRegistroGanado;
        private System.Windows.Forms.Label lblRegistroValorVentaKgP;
        private System.Windows.Forms.TextBox txtRegistroValorVentaKgP;
        private System.Windows.Forms.TabControl tcRegistro;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.TabPage tpRegistros;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblFooterNombre;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TableLayoutPanel tlpRegistroValor;
        private System.Windows.Forms.Panel pRegistroContenedor;
        private System.Windows.Forms.Panel pRegistroContenedorS2;
        private System.Windows.Forms.Panel pRegistroContenedorS1;
        private System.Windows.Forms.Panel pRegistroContenedorS7;
        private System.Windows.Forms.Panel pRegistroContenedorS6;
        private System.Windows.Forms.Panel pRegistroContenedorS5;
        private System.Windows.Forms.Panel pRegistroContenedorS4;
        private System.Windows.Forms.Panel pRegistroContenedorS3;
    }
}
