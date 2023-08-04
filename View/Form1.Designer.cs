namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.pnlAyuda = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.pnllAdmArticulos = new System.Windows.Forms.Panel();
            this.btnAdmArticulos = new FontAwesome.Sharp.IconButton();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnAvanzada = new System.Windows.Forms.Button();
            this.btnporNombre = new System.Windows.Forms.Button();
            this.btnnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pnlAvanzada = new System.Windows.Forms.Panel();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pxbArticulo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.menuLateral.SuspendLayout();
            this.pnlAyuda.SuspendLayout();
            this.pnllAdmArticulos.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlAvanzada.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(251, 40);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(0, 40);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(251, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(0, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(251, 40);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // menuLateral
            // 
            this.menuLateral.AutoScroll = true;
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuLateral.Controls.Add(this.pnlAyuda);
            this.menuLateral.Controls.Add(this.btnAyuda);
            this.menuLateral.Controls.Add(this.pnllAdmArticulos);
            this.menuLateral.Controls.Add(this.btnAdmArticulos);
            this.menuLateral.Controls.Add(this.pnlBuscar);
            this.menuLateral.Controls.Add(this.btnnBuscar);
            this.menuLateral.Controls.Add(this.panelLogo);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 0);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(251, 530);
            this.menuLateral.TabIndex = 14;
            // 
            // pnlAyuda
            // 
            this.pnlAyuda.Controls.Add(this.button1);
            this.pnlAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAyuda.Location = new System.Drawing.Point(0, 441);
            this.pnlAyuda.Name = "pnlAyuda";
            this.pnlAyuda.Size = new System.Drawing.Size(251, 52);
            this.pnlAyuda.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(251, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Contacto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAyuda.IconColor = System.Drawing.Color.Snow;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 40;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 396);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(251, 45);
            this.btnAyuda.TabIndex = 23;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // pnllAdmArticulos
            // 
            this.pnllAdmArticulos.Controls.Add(this.btnModificar);
            this.pnllAdmArticulos.Controls.Add(this.btnEliminar);
            this.pnllAdmArticulos.Controls.Add(this.btnAgregar);
            this.pnllAdmArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllAdmArticulos.Location = new System.Drawing.Point(0, 274);
            this.pnllAdmArticulos.Name = "pnllAdmArticulos";
            this.pnllAdmArticulos.Size = new System.Drawing.Size(251, 122);
            this.pnllAdmArticulos.TabIndex = 2;
            // 
            // btnAdmArticulos
            // 
            this.btnAdmArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAdmArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmArticulos.FlatAppearance.BorderSize = 0;
            this.btnAdmArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmArticulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmArticulos.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnAdmArticulos.IconColor = System.Drawing.Color.Snow;
            this.btnAdmArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmArticulos.IconSize = 40;
            this.btnAdmArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmArticulos.Location = new System.Drawing.Point(0, 229);
            this.btnAdmArticulos.Name = "btnAdmArticulos";
            this.btnAdmArticulos.Size = new System.Drawing.Size(251, 45);
            this.btnAdmArticulos.TabIndex = 22;
            this.btnAdmArticulos.Text = "Adminitración De Articulos";
            this.btnAdmArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmArticulos.UseVisualStyleBackColor = false;
            this.btnAdmArticulos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.btnAvanzada);
            this.pnlBuscar.Controls.Add(this.btnporNombre);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 145);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(251, 84);
            this.pnlBuscar.TabIndex = 1;
            // 
            // btnAvanzada
            // 
            this.btnAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAvanzada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvanzada.FlatAppearance.BorderSize = 0;
            this.btnAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvanzada.Location = new System.Drawing.Point(0, 40);
            this.btnAvanzada.Name = "btnAvanzada";
            this.btnAvanzada.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAvanzada.Size = new System.Drawing.Size(251, 40);
            this.btnAvanzada.TabIndex = 20;
            this.btnAvanzada.Text = "Avanzada";
            this.btnAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvanzada.UseVisualStyleBackColor = false;
            this.btnAvanzada.Click += new System.EventHandler(this.btnAvanzada_Click_1);
            // 
            // btnporNombre
            // 
            this.btnporNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnporNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnporNombre.FlatAppearance.BorderSize = 0;
            this.btnporNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnporNombre.Location = new System.Drawing.Point(0, 0);
            this.btnporNombre.Name = "btnporNombre";
            this.btnporNombre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnporNombre.Size = new System.Drawing.Size(251, 40);
            this.btnporNombre.TabIndex = 15;
            this.btnporNombre.Text = "Rapida";
            this.btnporNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnporNombre.UseVisualStyleBackColor = false;
            this.btnporNombre.Click += new System.EventHandler(this.btnporNombre_Click);
            // 
            // btnnBuscar
            // 
            this.btnnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnBuscar.FlatAppearance.BorderSize = 0;
            this.btnnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnnBuscar.IconColor = System.Drawing.Color.Snow;
            this.btnnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnBuscar.IconSize = 40;
            this.btnnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnBuscar.Location = new System.Drawing.Point(0, 100);
            this.btnnBuscar.Name = "btnnBuscar";
            this.btnnBuscar.Size = new System.Drawing.Size(251, 45);
            this.btnnBuscar.TabIndex = 21;
            this.btnnBuscar.Text = "Buscar";
            this.btnnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnBuscar.UseVisualStyleBackColor = false;
            this.btnnBuscar.Click += new System.EventHandler(this.btnnBuscar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconButton1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PersonFalling;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(245, 91);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Logo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtFiltrar.Location = new System.Drawing.Point(4, 2);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(251, 23);
            this.txtFiltrar.TabIndex = 6;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(4, 29);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(658, 301);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pnlAvanzada
            // 
            this.pnlAvanzada.Controls.Add(this.lblCriterio);
            this.pnlAvanzada.Controls.Add(this.lblCampo);
            this.pnlAvanzada.Controls.Add(this.btnBuscar);
            this.pnlAvanzada.Controls.Add(this.lblFiltroAvanzado);
            this.pnlAvanzada.Controls.Add(this.txtFiltroAvanzado);
            this.pnlAvanzada.Controls.Add(this.cboCriterio);
            this.pnlAvanzada.Controls.Add(this.cboCampo);
            this.pnlAvanzada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAvanzada.Location = new System.Drawing.Point(0, 335);
            this.pnlAvanzada.Name = "pnlAvanzada";
            this.pnlAvanzada.Size = new System.Drawing.Size(997, 90);
            this.pnlAvanzada.TabIndex = 20;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCriterio.Location = new System.Drawing.Point(199, 11);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(53, 17);
            this.lblCriterio.TabIndex = 8;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCampo.Location = new System.Drawing.Point(4, 11);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(52, 17);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.Location = new System.Drawing.Point(556, 4);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 31);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(388, 11);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 17);
            this.lblFiltroAvanzado.TabIndex = 9;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(435, 8);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(113, 23);
            this.txtFiltroAvanzado.TabIndex = 10;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(261, 8);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(5);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(118, 24);
            this.cboCriterio.TabIndex = 12;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(65, 8);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(5);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(125, 24);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.pnlAvanzada);
            this.panel1.Controls.Add(this.dgvArticulos);
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Controls.Add(this.pxbArticulo);
            this.panel1.Location = new System.Drawing.Point(257, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 425);
            this.panel1.TabIndex = 15;
            // 
            // pxbArticulo
            // 
            this.pxbArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pxbArticulo.Location = new System.Drawing.Point(667, 29);
            this.pxbArticulo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pxbArticulo.MaximumSize = new System.Drawing.Size(324, 299);
            this.pxbArticulo.MinimumSize = new System.Drawing.Size(324, 299);
            this.pxbArticulo.Name = "pxbArticulo";
            this.pxbArticulo.Size = new System.Drawing.Size(324, 299);
            this.pxbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbArticulo.TabIndex = 1;
            this.pxbArticulo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 100);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.LightGray;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 23;
            this.btnMaximizar.Location = new System.Drawing.Point(1202, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(26, 31);
            this.btnMaximizar.TabIndex = 18;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCerrar.IconColor = System.Drawing.Color.LightGray;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 23;
            this.btnCerrar.Location = new System.Drawing.Point(1234, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 31);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 23;
            this.btnMinimizar.Location = new System.Drawing.Point(1170, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 31);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1261, 530);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.menuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(1240, 525);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuLateral.ResumeLayout(false);
            this.pnlAyuda.ResumeLayout(false);
            this.pnllAdmArticulos.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlAvanzada.ResumeLayout(false);
            this.pnlAvanzada.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnporNombre;
        private System.Windows.Forms.Button btnAvanzada;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private System.Windows.Forms.Panel pnllAdmArticulos;
        private FontAwesome.Sharp.IconButton btnAdmArticulos;
        private System.Windows.Forms.Panel pnlBuscar;
        private FontAwesome.Sharp.IconButton btnnBuscar;
        private System.Windows.Forms.PictureBox pxbArticulo;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel pnlAvanzada;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAyuda;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

