﻿namespace examen2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario de trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las horas trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingrese el valor de las horas";
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(271, 120);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(138, 20);
            this.txthoras.TabIndex = 0;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(290, 203);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(119, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(550, 140);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(140, 48);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Su salario es: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(246, 337);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(22, 26);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotal;
    }
}

