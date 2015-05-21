namespace Practica_5
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFecha = new System.Windows.Forms.Label();
            this.monthCalendarCalendario = new System.Windows.Forms.MonthCalendar();
            this.labelAutor = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.richTextBoxCuerpo = new System.Windows.Forms.RichTextBox();
            this.labelCuerpo = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(25, 20);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(59, 20);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // monthCalendarCalendario
            // 
            this.monthCalendarCalendario.Location = new System.Drawing.Point(25, 51);
            this.monthCalendarCalendario.Name = "monthCalendarCalendario";
            this.monthCalendarCalendario.TabIndex = 1;
            this.monthCalendarCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarCalendario_DateChanged);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(21, 243);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(53, 20);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutor.Location = new System.Drawing.Point(25, 270);
            this.textBoxAutor.MaxLength = 100;
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 22);
            this.textBoxAutor.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(169, 243);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(53, 20);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(173, 270);
            this.textBoxTitulo.MaxLength = 100;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitulo.TabIndex = 5;
            // 
            // richTextBoxCuerpo
            // 
            this.richTextBoxCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCuerpo.Location = new System.Drawing.Point(25, 356);
            this.richTextBoxCuerpo.MaxLength = 117;
            this.richTextBoxCuerpo.Name = "richTextBoxCuerpo";
            this.richTextBoxCuerpo.Size = new System.Drawing.Size(248, 96);
            this.richTextBoxCuerpo.TabIndex = 6;
            this.richTextBoxCuerpo.Text = "";
            // 
            // labelCuerpo
            // 
            this.labelCuerpo.AutoSize = true;
            this.labelCuerpo.BackColor = System.Drawing.Color.Transparent;
            this.labelCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuerpo.ForeColor = System.Drawing.Color.White;
            this.labelCuerpo.Location = new System.Drawing.Point(21, 329);
            this.labelCuerpo.Name = "labelCuerpo";
            this.labelCuerpo.Size = new System.Drawing.Size(67, 20);
            this.labelCuerpo.TabIndex = 7;
            this.labelCuerpo.Text = "Cuerpo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardar.Location = new System.Drawing.Point(173, 305);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 39);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Practica_5.Properties.Resources.madera_azul;
            this.ClientSize = new System.Drawing.Size(299, 476);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelCuerpo);
            this.Controls.Add(this.richTextBoxCuerpo);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.monthCalendarCalendario);
            this.Controls.Add(this.labelFecha);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 515);
            this.MinimumSize = new System.Drawing.Size(315, 515);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blog";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.MonthCalendar monthCalendarCalendario;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.RichTextBox richTextBoxCuerpo;
        private System.Windows.Forms.Label labelCuerpo;
        private System.Windows.Forms.Button buttonGuardar;


    }
}

