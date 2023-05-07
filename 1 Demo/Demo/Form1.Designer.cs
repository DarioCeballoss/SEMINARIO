namespace Demo
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.txt_a = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.Label();
            this.btn_e = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(70, 33);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 24);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(70, 63);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(70, 92);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // txt_a
            // 
            this.txt_a.AutoSize = true;
            this.txt_a.Location = new System.Drawing.Point(235, 43);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(14, 13);
            this.txt_a.TabIndex = 3;
            this.txt_a.Text = "A";
            // 
            // txt_b
            // 
            this.txt_b.AutoSize = true;
            this.txt_b.Location = new System.Drawing.Point(235, 73);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(14, 13);
            this.txt_b.TabIndex = 4;
            this.txt_b.Text = "B";
            // 
            // txt_c
            // 
            this.txt_c.AutoSize = true;
            this.txt_c.Location = new System.Drawing.Point(235, 102);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(14, 13);
            this.txt_c.TabIndex = 5;
            this.txt_c.Text = "C";
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(70, 121);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(75, 23);
            this.btn_e.TabIndex = 6;
            this.btn_e.Text = "Exit";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "ve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Label txt_a;
        private System.Windows.Forms.Label txt_b;
        private System.Windows.Forms.Label txt_c;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

