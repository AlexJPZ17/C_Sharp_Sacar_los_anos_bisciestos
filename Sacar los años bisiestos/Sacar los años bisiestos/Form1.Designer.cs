namespace Sacar_los_años_bisiestos
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.TextBox_Inicial = new System.Windows.Forms.TextBox();
            this.TextBox_Final = new System.Windows.Forms.TextBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button_Limpiar = new System.Windows.Forms.Button();
            this.Button_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Inicial
            // 
            this.TextBox_Inicial.Location = new System.Drawing.Point(100, 18);
            this.TextBox_Inicial.MaxLength = 4;
            this.TextBox_Inicial.Name = "TextBox_Inicial";
            this.TextBox_Inicial.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Inicial.TabIndex = 13;
            // 
            // TextBox_Final
            // 
            this.TextBox_Final.Location = new System.Drawing.Point(100, 58);
            this.TextBox_Final.MaxLength = 4;
            this.TextBox_Final.Name = "TextBox_Final";
            this.TextBox_Final.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Final.TabIndex = 12;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(13, 95);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(187, 186);
            this.ListBox1.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 15);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Año inicial";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 15);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Año final";
            // 
            // Button_Limpiar
            // 
            this.Button_Limpiar.Location = new System.Drawing.Point(114, 298);
            this.Button_Limpiar.Name = "Button_Limpiar";
            this.Button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Button_Limpiar.TabIndex = 8;
            this.Button_Limpiar.Text = "Limpiar";
            this.Button_Limpiar.UseVisualStyleBackColor = true;
            this.Button_Limpiar.Click += new System.EventHandler(this.Button_Limpiar_Click);
            // 
            // Button_Calcular
            // 
            this.Button_Calcular.Location = new System.Drawing.Point(21, 298);
            this.Button_Calcular.Name = "Button_Calcular";
            this.Button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.Button_Calcular.TabIndex = 7;
            this.Button_Calcular.Text = "Calcular";
            this.Button_Calcular.UseVisualStyleBackColor = true;
            this.Button_Calcular.Click += new System.EventHandler(this.Button_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 339);
            this.Controls.Add(this.TextBox_Inicial);
            this.Controls.Add(this.TextBox_Final);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button_Limpiar);
            this.Controls.Add(this.Button_Calcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox_Inicial;
        internal System.Windows.Forms.TextBox TextBox_Final;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button_Limpiar;
        internal System.Windows.Forms.Button Button_Calcular;
    }
}

