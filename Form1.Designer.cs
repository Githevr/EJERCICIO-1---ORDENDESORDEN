namespace WindowsFormsApp1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMostrarDesordenado = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.btnMostrarOrdenado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(115, 81);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(287, 111);
            this.txtInput.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIngresar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(526, 48);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(180, 56);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMostrarDesordenado
            // 
            this.btnMostrarDesordenado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrarDesordenado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDesordenado.Location = new System.Drawing.Point(526, 110);
            this.btnMostrarDesordenado.Name = "btnMostrarDesordenado";
            this.btnMostrarDesordenado.Size = new System.Drawing.Size(180, 56);
            this.btnMostrarDesordenado.TabIndex = 5;
            this.btnMostrarDesordenado.Text = "Mostrar Desordenado";
            this.btnMostrarDesordenado.UseVisualStyleBackColor = false;
            this.btnMostrarDesordenado.Click += new System.EventHandler(this.btnMostrarDesordenado_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(316, 265);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(228, 173);
            this.listBoxOutput.TabIndex = 6;
            // 
            // btnMostrarOrdenado
            // 
            this.btnMostrarOrdenado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrarOrdenado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarOrdenado.Location = new System.Drawing.Point(526, 172);
            this.btnMostrarOrdenado.Name = "btnMostrarOrdenado";
            this.btnMostrarOrdenado.Size = new System.Drawing.Size(180, 54);
            this.btnMostrarOrdenado.TabIndex = 7;
            this.btnMostrarOrdenado.Text = "Mostrar Ordenado";
            this.btnMostrarOrdenado.UseVisualStyleBackColor = false;
            this.btnMostrarOrdenado.Click += new System.EventHandler(this.btnMostrarOrdenado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos Ingresados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarOrdenado);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.btnMostrarDesordenado);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnMostrarDesordenado;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button btnMostrarOrdenado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

