namespace View
{
    partial class FrmAlta
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.pxbAlta = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorAgregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImagenLocal = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAgregar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(53, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigo.Location = new System.Drawing.Point(56, 139);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(58, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUrlImagen.Location = new System.Drawing.Point(44, 217);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(76, 17);
            this.lblUrlImagen.TabIndex = 4;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(59, 302);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoria.Location = new System.Drawing.Point(48, 258);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(22, 155);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(22, 194);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(22, 237);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagen.TabIndex = 11;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(22, 278);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 12;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(22, 322);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 13;
            // 
            // pxbAlta
            // 
            this.pxbAlta.Location = new System.Drawing.Point(245, 57);
            this.pxbAlta.Name = "pxbAlta";
            this.pxbAlta.Size = new System.Drawing.Size(283, 258);
            this.pxbAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbAlta.TabIndex = 14;
            this.pxbAlta.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(245, 329);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 40);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(400, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorAgregar
            // 
            this.errorAgregar.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnImagenLocal);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblUrlImagen);
            this.panel1.Controls.Add(this.cboMarca);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.txtUrlImagen);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 428);
            this.panel1.TabIndex = 18;
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.FlatAppearance.BorderSize = 0;
            this.btnImagenLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagenLocal.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnImagenLocal.IconColor = System.Drawing.Color.Black;
            this.btnImagenLocal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImagenLocal.IconSize = 25;
            this.btnImagenLocal.Location = new System.Drawing.Point(149, 232);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(24, 29);
            this.btnImagenLocal.TabIndex = 18;
            this.btnImagenLocal.UseVisualStyleBackColor = true;
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pxbAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(572, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(572, 428);
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAgregar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.PictureBox pxbAlta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorAgregar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnImagenLocal;
    }
}