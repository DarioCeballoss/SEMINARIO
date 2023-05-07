namespace Calcular_vuelto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_costo = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.lbl_efectivo = new System.Windows.Forms.Label();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.lbl_buelto = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_costo
            // 
            resources.ApplyResources(this.lbl_costo, "lbl_costo");
            this.lbl_costo.Name = "lbl_costo";
            // 
            // txt_costo
            // 
            resources.ApplyResources(this.txt_costo, "txt_costo");
            this.txt_costo.Name = "txt_costo";
            // 
            // lbl_efectivo
            // 
            resources.ApplyResources(this.lbl_efectivo, "lbl_efectivo");
            this.lbl_efectivo.Name = "lbl_efectivo";
            // 
            // txt_efectivo
            // 
            resources.ApplyResources(this.txt_efectivo, "txt_efectivo");
            this.txt_efectivo.Name = "txt_efectivo";
            // 
            // lbl_buelto
            // 
            resources.ApplyResources(this.lbl_buelto, "lbl_buelto");
            this.lbl_buelto.Name = "lbl_buelto";
            // 
            // btn_resultado
            // 
            resources.ApplyResources(this.btn_resultado, "btn_resultado");
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_referencia
            // 
            resources.ApplyResources(this.lbl_referencia, "lbl_referencia");
            this.lbl_referencia.Name = "lbl_referencia";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.lbl_referencia);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.lbl_buelto);
            this.Controls.Add(this.txt_efectivo);
            this.Controls.Add(this.lbl_efectivo);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.lbl_costo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label lbl_efectivo;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.Label lbl_buelto;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_referencia;
    }
}

