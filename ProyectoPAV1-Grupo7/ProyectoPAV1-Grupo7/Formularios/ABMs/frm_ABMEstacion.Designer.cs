﻿namespace ProyectoPAV1_Grupo7.Formularios
{
    partial class frm_ABMEstacion
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblFechaHabilitacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCuit = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(16, 65);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(43, 17);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(16, 97);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(95, 17);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(13, 131);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(39, 17);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Calle";
            // 
            // lblFechaHabilitacion
            // 
            this.lblFechaHabilitacion.AutoSize = true;
            this.lblFechaHabilitacion.Location = new System.Drawing.Point(16, 285);
            this.lblFechaHabilitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHabilitacion.Name = "lblFechaHabilitacion";
            this.lblFechaHabilitacion.Size = new System.Drawing.Size(95, 17);
            this.lblFechaHabilitacion.TabIndex = 4;
            this.lblFechaHabilitacion.Text = "Fecha de Alta";
            this.lblFechaHabilitacion.Click += new System.EventHandler(this.lblFechaHabilitacion_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 280);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtBoxCuit
            // 
            this.txtBoxCuit.Location = new System.Drawing.Point(147, 62);
            this.txtBoxCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCuit.MaxLength = 11;
            this.txtBoxCuit.Name = "txtBoxCuit";
            this.txtBoxCuit.Size = new System.Drawing.Size(132, 22);
            this.txtBoxCuit.TabIndex = 6;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(147, 94);
            this.txtBoxRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRazonSocial.MaxLength = 25;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(132, 22);
            this.txtBoxRazonSocial.TabIndex = 7;
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Location = new System.Drawing.Point(147, 126);
            this.txtBoxCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCalle.MaxLength = 32;
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(265, 22);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(147, 157);
            this.txtBoxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNumero.MaxLength = 5;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNumero.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(525, 351);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 160);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Provincia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Barrio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 218);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 248);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 16;
            // 
            // frm_ABMEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxCalle);
            this.Controls.Add(this.txtBoxRazonSocial);
            this.Controls.Add(this.txtBoxCuit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaHabilitacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ABMEstacion";
            this.Text = "ABM Estación de Servicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblFechaHabilitacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxCuit;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}