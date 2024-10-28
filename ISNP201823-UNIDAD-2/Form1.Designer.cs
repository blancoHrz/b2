using System;

namespace ISNP201823_UNIDAD_2
{
    partial class PELICULAS
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblReguistro = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.textBox3);
            this.grbDatos.Controls.Add(this.txtGenero);
            this.grbDatos.Controls.Add(this.txtPelicula);
            this.grbDatos.Controls.Add(this.lblSinopsis);
            this.grbDatos.Controls.Add(this.lblGenero);
            this.grbDatos.Controls.Add(this.lblPelicula);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(366, 267);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "PELICULAS SUGERIDAS ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 101);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 163);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(88, 72);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(265, 20);
            this.txtGenero.TabIndex = 4;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(88, 49);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(265, 20);
            this.txtPelicula.TabIndex = 3;
            this.txtPelicula.TextChanged += new System.EventHandler(this.txtPelicula_TextChanged);
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(20, 101);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(46, 13);
            this.lblSinopsis.TabIndex = 2;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(20, 79);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Genero";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(20, 56);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(44, 13);
            this.lblPelicula.TabIndex = 0;
            this.lblPelicula.Text = "Pelicula";
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblReguistro);
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Location = new System.Drawing.Point(12, 285);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(180, 78);
            this.grbNavegacion.TabIndex = 1;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "NAVEGACION";
            // 
            // lblReguistro
            // 
            this.lblReguistro.AutoSize = true;
            this.lblReguistro.Location = new System.Drawing.Point(68, 38);
            this.lblReguistro.Name = "lblReguistro";
            this.lblReguistro.Size = new System.Drawing.Size(0, 13);
            this.lblReguistro.TabIndex = 4;
            this.lblReguistro.Click += new System.EventHandler(this.lblReguistro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(149, 33);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(31, 23);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "⤜";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(0, 33);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(31, 23);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "⤛";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(35, 33);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(31, 23);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "⤙";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(112, 33);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(31, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "⤚";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(198, 286);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(180, 77);
            this.grbEdicion.TabIndex = 2;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "EDICION";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(91, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 52);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(0, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(0, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // PELICULAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 522);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Name = "PELICULAS";
            this.Text = "PELICULAS";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblReguistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private EventHandler label2_Click;
        private EventHandler textBox3_TextChanged;
        private EventHandler Form1_Load;
    }
}

