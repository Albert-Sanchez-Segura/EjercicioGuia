namespace cliente2
{
    partial class ConversorTemp
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
            this.Peticiones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FarCel = new System.Windows.Forms.RadioButton();
            this.CelFar = new System.Windows.Forms.RadioButton();
            this.dato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Peticiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Peticiones
            // 
            this.Peticiones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Peticiones.Controls.Add(this.button1);
            this.Peticiones.Controls.Add(this.FarCel);
            this.Peticiones.Controls.Add(this.CelFar);
            this.Peticiones.Controls.Add(this.dato);
            this.Peticiones.Controls.Add(this.label1);
            this.Peticiones.Location = new System.Drawing.Point(221, 88);
            this.Peticiones.Name = "Peticiones";
            this.Peticiones.Size = new System.Drawing.Size(399, 296);
            this.Peticiones.TabIndex = 0;
            this.Peticiones.TabStop = false;
            this.Peticiones.Text = "Peticiones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FarCel
            // 
            this.FarCel.AutoSize = true;
            this.FarCel.Location = new System.Drawing.Point(44, 142);
            this.FarCel.Name = "FarCel";
            this.FarCel.Size = new System.Drawing.Size(198, 21);
            this.FarCel.TabIndex = 3;
            this.FarCel.TabStop = true;
            this.FarCel.Text = "grados Farenheit a Celsius";
            this.FarCel.UseVisualStyleBackColor = true;
            // 
            // CelFar
            // 
            this.CelFar.AutoSize = true;
            this.CelFar.Location = new System.Drawing.Point(44, 115);
            this.CelFar.Name = "CelFar";
            this.CelFar.Size = new System.Drawing.Size(198, 21);
            this.CelFar.TabIndex = 1;
            this.CelFar.TabStop = true;
            this.CelFar.Text = "grados Celsius a Farenheit";
            this.CelFar.UseVisualStyleBackColor = true;
            // 
            // dato
            // 
            this.dato.Location = new System.Drawing.Point(44, 70);
            this.dato.Name = "dato";
            this.dato.Size = new System.Drawing.Size(318, 22);
            this.dato.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el valor a convertir (decimal con punto):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Conectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conversor temperatura: Celsius-Farenheit Farenheit-Celsius";
            // 
            // ConversorTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Peticiones);
            this.Name = "ConversorTemp";
            this.Text = "Form1";
            this.Peticiones.ResumeLayout(false);
            this.Peticiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Peticiones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton FarCel;
        private System.Windows.Forms.RadioButton CelFar;
        private System.Windows.Forms.TextBox dato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

