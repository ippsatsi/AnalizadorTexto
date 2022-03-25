
namespace AnalizadorTexto
{
    partial class AnaTexto
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
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListExpresiones = new System.Windows.Forms.TextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresion";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(33, 54);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(451, 20);
            this.txtExpresion.TabIndex = 1;
            this.txtExpresion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpresion_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Historial";
            // 
            // txtListExpresiones
            // 
            this.txtListExpresiones.Location = new System.Drawing.Point(33, 151);
            this.txtListExpresiones.Multiline = true;
            this.txtListExpresiones.Name = "txtListExpresiones";
            this.txtListExpresiones.Size = new System.Drawing.Size(451, 258);
            this.txtListExpresiones.TabIndex = 3;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(409, 437);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 4;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // AnaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 472);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.txtListExpresiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label1);
            this.Name = "AnaTexto";
            this.Text = "Analizador de Texto";
            this.Load += new System.EventHandler(this.AnaTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListExpresiones;
        private System.Windows.Forms.Button btCerrar;
    }
}

