namespace ExpresionRegular
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ExpresionRegular = new System.Windows.Forms.TextBox();
            this.richTextBox_Cadena = new System.Windows.Forms.RichTextBox();
            this.listBox_Coincidencias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(848, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "VALIDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_ExpresionRegular
            // 
            this.textBox_ExpresionRegular.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ExpresionRegular.Location = new System.Drawing.Point(422, 66);
            this.textBox_ExpresionRegular.Name = "textBox_ExpresionRegular";
            this.textBox_ExpresionRegular.Size = new System.Drawing.Size(586, 32);
            this.textBox_ExpresionRegular.TabIndex = 1;
            // 
            // richTextBox_Cadena
            // 
            this.richTextBox_Cadena.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Cadena.Location = new System.Drawing.Point(45, 184);
            this.richTextBox_Cadena.Name = "richTextBox_Cadena";
            this.richTextBox_Cadena.Size = new System.Drawing.Size(658, 337);
            this.richTextBox_Cadena.TabIndex = 2;
            this.richTextBox_Cadena.Text = "";
            // 
            // listBox_Coincidencias
            // 
            this.listBox_Coincidencias.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Coincidencias.FormattingEnabled = true;
            this.listBox_Coincidencias.ItemHeight = 15;
            this.listBox_Coincidencias.Location = new System.Drawing.Point(762, 185);
            this.listBox_Coincidencias.Name = "listBox_Coincidencias";
            this.listBox_Coincidencias.Size = new System.Drawing.Size(246, 334);
            this.listBox_Coincidencias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESA UNA EXPRESION REGULAR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Coincidencias);
            this.Controls.Add(this.richTextBox_Cadena);
            this.Controls.Add(this.textBox_ExpresionRegular);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ExpresionRegular;
        private System.Windows.Forms.RichTextBox richTextBox_Cadena;
        private System.Windows.Forms.ListBox listBox_Coincidencias;
        private System.Windows.Forms.Label label1;
    }
}

