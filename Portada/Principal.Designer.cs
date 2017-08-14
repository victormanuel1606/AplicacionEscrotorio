namespace Portada
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgwCanciones = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdUbicasion = new System.Windows.Forms.TextBox();
            this.btnterminar = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechallegada = new System.Windows.Forms.DateTimePicker();
            this.pInsertar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.imgPedido = new System.Windows.Forms.PictureBox();
            this.imgUbicasion = new System.Windows.Forms.PictureBox();
            this.btnCanciones = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanciones)).BeginInit();
            this.pInsertar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUbicasion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCanciones
            // 
            this.dgwCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCanciones.Location = new System.Drawing.Point(240, 107);
            this.dgwCanciones.Name = "dgwCanciones";
            this.dgwCanciones.Size = new System.Drawing.Size(645, 166);
            this.dgwCanciones.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(0, 297);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(84, 31);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(59, 111);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insertar Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(59, 164);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de LLegada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Id Ubicacion";
            // 
            // txtIdUbicasion
            // 
            this.txtIdUbicasion.Location = new System.Drawing.Point(59, 58);
            this.txtIdUbicasion.Name = "txtIdUbicasion";
            this.txtIdUbicasion.Size = new System.Drawing.Size(100, 20);
            this.txtIdUbicasion.TabIndex = 16;
            // 
            // btnterminar
            // 
            this.btnterminar.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnterminar.Location = new System.Drawing.Point(809, 342);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 23);
            this.btnterminar.TabIndex = 18;
            this.btnterminar.Text = "Salir";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click_1);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(59, 271);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "id Pedido";
            // 
            // dtFechallegada
            // 
            this.dtFechallegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechallegada.Location = new System.Drawing.Point(59, 218);
            this.dtFechallegada.Name = "dtFechallegada";
            this.dtFechallegada.Size = new System.Drawing.Size(100, 20);
            this.dtFechallegada.TabIndex = 21;
            // 
            // pInsertar
            // 
            this.pInsertar.Controls.Add(this.button1);
            this.pInsertar.Controls.Add(this.panel6);
            this.pInsertar.Controls.Add(this.panel5);
            this.pInsertar.Controls.Add(this.panel4);
            this.pInsertar.Controls.Add(this.panel3);
            this.pInsertar.Controls.Add(this.panel2);
            this.pInsertar.Controls.Add(this.dtFechallegada);
            this.pInsertar.Controls.Add(this.btnIngresar);
            this.pInsertar.Controls.Add(this.txtPedido);
            this.pInsertar.Controls.Add(this.txtCiudad);
            this.pInsertar.Controls.Add(this.label6);
            this.pInsertar.Controls.Add(this.label1);
            this.pInsertar.Controls.Add(this.label2);
            this.pInsertar.Controls.Add(this.label3);
            this.pInsertar.Controls.Add(this.txtIdUbicasion);
            this.pInsertar.Controls.Add(this.txtProveedor);
            this.pInsertar.Controls.Add(this.label4);
            this.pInsertar.Location = new System.Drawing.Point(24, 12);
            this.pInsertar.Name = "pInsertar";
            this.pInsertar.Size = new System.Drawing.Size(206, 331);
            this.pInsertar.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 28);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 28);
            this.panel3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ciudad";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(3, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 28);
            this.panel4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Proveedor";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(3, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 28);
            this.panel5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Id Ubicacion";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(3, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 28);
            this.panel6.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pedido";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.label11);
            this.pMenu.Controls.Add(this.btnCanciones);
            this.pMenu.Controls.Add(this.btnArtista);
            this.pMenu.Location = new System.Drawing.Point(12, 20);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(201, 294);
            this.pMenu.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Menu Principal";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(473, 283);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(188, 31);
            this.btnnuevo.TabIndex = 26;
            this.btnnuevo.Text = "Ingresar Nueva Ubicacion";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Portada.Properties.Resources.GamesExpress;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(379, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(355, 272);
            this.logo.TabIndex = 27;
            this.logo.TabStop = false;
            // 
            // imgPedido
            // 
            this.imgPedido.BackgroundImage = global::Portada.Properties.Resources.unnamed;
            this.imgPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPedido.Location = new System.Drawing.Point(473, 20);
            this.imgPedido.Name = "imgPedido";
            this.imgPedido.Size = new System.Drawing.Size(148, 81);
            this.imgPedido.TabIndex = 25;
            this.imgPedido.TabStop = false;
            // 
            // imgUbicasion
            // 
            this.imgUbicasion.BackgroundImage = global::Portada.Properties.Resources.location;
            this.imgUbicasion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUbicasion.Location = new System.Drawing.Point(473, 20);
            this.imgUbicasion.Name = "imgUbicasion";
            this.imgUbicasion.Size = new System.Drawing.Size(148, 81);
            this.imgUbicasion.TabIndex = 24;
            this.imgUbicasion.TabStop = false;
            // 
            // btnCanciones
            // 
            this.btnCanciones.BackColor = System.Drawing.Color.Transparent;
            this.btnCanciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCanciones.BackgroundImage")));
            this.btnCanciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanciones.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCanciones.Location = new System.Drawing.Point(27, 49);
            this.btnCanciones.Name = "btnCanciones";
            this.btnCanciones.Size = new System.Drawing.Size(159, 99);
            this.btnCanciones.TabIndex = 1;
            this.btnCanciones.Text = "Ubicasiones";
            this.btnCanciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanciones.UseVisualStyleBackColor = false;
            this.btnCanciones.Click += new System.EventHandler(this.btnCanciones_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.BackgroundImage = global::Portada.Properties.Resources.unnamed;
            this.btnArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArtista.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnArtista.Location = new System.Drawing.Point(27, 173);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(159, 99);
            this.btnArtista.TabIndex = 3;
            this.btnArtista.Text = "Pedidos";
            this.btnArtista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(896, 377);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.imgPedido);
            this.Controls.Add(this.imgUbicasion);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pInsertar);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.dgwCanciones);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanciones)).EndInit();
            this.pInsertar.ResumeLayout(false);
            this.pInsertar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUbicasion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCanciones;
        private System.Windows.Forms.Button btnCanciones;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdUbicasion;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechallegada;
        private System.Windows.Forms.Panel pInsertar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox imgUbicasion;
        private System.Windows.Forms.PictureBox imgPedido;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
    }
}

