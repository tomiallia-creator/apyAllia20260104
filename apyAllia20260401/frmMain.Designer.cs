namespace apyAllia20260401
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbGestion = new System.Windows.Forms.ComboBox();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.tableProductos = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtStock = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCargados = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelProductos.SuspendLayout();
            this.tableProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(-5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(416, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "------ Gestión de Productos ------";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Gray;
            this.lblCodigo.Location = new System.Drawing.Point(6, 3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(96, 29);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(6, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 113);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(152, 29);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Gray;
            this.lblPrecio.Location = new System.Drawing.Point(6, 197);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(85, 29);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Gray;
            this.lblStock.Location = new System.Drawing.Point(6, 245);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 29);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Gray;
            this.lblCategoria.Location = new System.Drawing.Point(6, 295);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(127, 29);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(172, 116);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 68);
            this.txtDescripcion.TabIndex = 9;
            // 
            // cmbGestion
            // 
            this.cmbGestion.FormattingEnabled = true;
            this.cmbGestion.Items.AddRange(new object[] {
            "Bebidas",
            "Alimentos",
            "Limpieza",
            "Higiene ",
            "Libreria"});
            this.cmbGestion.Location = new System.Drawing.Point(172, 298);
            this.cmbGestion.Name = "cmbGestion";
            this.cmbGestion.Size = new System.Drawing.Size(173, 21);
            this.cmbGestion.TabIndex = 12;
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelProductos.Controls.Add(this.tableProductos);
            this.panelProductos.Controls.Add(this.lblTitulo);
            this.panelProductos.Location = new System.Drawing.Point(38, 12);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(407, 382);
            this.panelProductos.TabIndex = 13;
            // 
            // tableProductos
            // 
            this.tableProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableProductos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableProductos.ColumnCount = 2;
            this.tableProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.70854F));
            this.tableProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.29146F));
            this.tableProductos.Controls.Add(this.maskedTxtCodigo, 1, 0);
            this.tableProductos.Controls.Add(this.cmbGestion, 1, 5);
            this.tableProductos.Controls.Add(this.maskedTxtStock, 1, 4);
            this.tableProductos.Controls.Add(this.lblCodigo, 0, 0);
            this.tableProductos.Controls.Add(this.lblNombre, 0, 1);
            this.tableProductos.Controls.Add(this.txtDescripcion, 1, 2);
            this.tableProductos.Controls.Add(this.lblPrecio, 0, 3);
            this.tableProductos.Controls.Add(this.txtNombre, 1, 1);
            this.tableProductos.Controls.Add(this.lblStock, 0, 4);
            this.tableProductos.Controls.Add(this.lblCategoria, 0, 5);
            this.tableProductos.Controls.Add(this.lblDescripcion, 0, 2);
            this.tableProductos.Controls.Add(this.maskedTxtPrecio, 1, 3);
            this.tableProductos.Location = new System.Drawing.Point(3, 32);
            this.tableProductos.Name = "tableProductos";
            this.tableProductos.RowCount = 6;
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableProductos.Size = new System.Drawing.Size(401, 347);
            this.tableProductos.TabIndex = 0;
            // 
            // maskedTxtCodigo
            // 
            this.maskedTxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTxtCodigo.Location = new System.Drawing.Point(172, 6);
            this.maskedTxtCodigo.Mask = "99999-999";
            this.maskedTxtCodigo.Name = "maskedTxtCodigo";
            this.maskedTxtCodigo.Size = new System.Drawing.Size(105, 20);
            this.maskedTxtCodigo.TabIndex = 7;
            this.maskedTxtCodigo.ValidatingType = typeof(int);
            // 
            // maskedTxtStock
            // 
            this.maskedTxtStock.Location = new System.Drawing.Point(172, 248);
            this.maskedTxtStock.Mask = "99999";
            this.maskedTxtStock.Name = "maskedTxtStock";
            this.maskedTxtStock.Size = new System.Drawing.Size(105, 20);
            this.maskedTxtStock.TabIndex = 11;
            this.maskedTxtStock.ValidatingType = typeof(int);
            // 
            // maskedTxtPrecio
            // 
            this.maskedTxtPrecio.Location = new System.Drawing.Point(172, 200);
            this.maskedTxtPrecio.Mask = "99999";
            this.maskedTxtPrecio.Name = "maskedTxtPrecio";
            this.maskedTxtPrecio.Size = new System.Drawing.Size(105, 20);
            this.maskedTxtPrecio.TabIndex = 10;
            this.maskedTxtPrecio.ValidatingType = typeof(int);
            // 
            // picFondo
            // 
            this.picFondo.Image = global::apyAllia20260401.Properties.Resources.ChatGPT_Image_1_abr_2026__09_19_20;
            this.picFondo.Location = new System.Drawing.Point(1, -3);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(492, 581);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 14;
            this.picFondo.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnCargar.Location = new System.Drawing.Point(41, 397);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(204, 43);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnCancelar.Location = new System.Drawing.Point(248, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 43);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblCargados);
            this.panel1.Location = new System.Drawing.Point(42, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 120);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::apyAllia20260401.Properties.Resources.ChatGPT_Image_1_abr_2026__09_19_20;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblCargados
            // 
            this.lblCargados.AutoSize = true;
            this.lblCargados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCargados.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargados.ForeColor = System.Drawing.Color.Gray;
            this.lblCargados.Location = new System.Drawing.Point(-6, 0);
            this.lblCargados.Name = "lblCargados";
            this.lblCargados.Size = new System.Drawing.Size(418, 29);
            this.lblCargados.TabIndex = 17;
            this.lblCargados.Text = "--------- Datos Cargados ---------";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(3, 41);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(14, 16);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(490, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            this.tableProductos.ResumeLayout(false);
            this.tableProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbGestion;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.MaskedTextBox maskedTxtCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTxtPrecio;
        private System.Windows.Forms.MaskedTextBox maskedTxtStock;
        private System.Windows.Forms.TableLayoutPanel tableProductos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCargados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
    }
}