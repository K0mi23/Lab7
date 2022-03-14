namespace Lab7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.informacionClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Mayor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.informacionClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso Condominio";
            // 
            // informacionClientes
            // 
            this.informacionClientes.AllowUserToAddRows = false;
            this.informacionClientes.AllowUserToDeleteRows = false;
            this.informacionClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionClientes.Location = new System.Drawing.Point(101, 69);
            this.informacionClientes.Name = "informacionClientes";
            this.informacionClientes.ReadOnly = true;
            this.informacionClientes.Size = new System.Drawing.Size(443, 256);
            this.informacionClientes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(101, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar Cuotas Menor a Mayor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mayor
            // 
            this.Mayor.Enabled = false;
            this.Mayor.Location = new System.Drawing.Point(444, 361);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(100, 20);
            this.Mayor.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Listar Cuotas Mayor a Menor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menor
            // 
            this.Menor.Enabled = false;
            this.Menor.Location = new System.Drawing.Point(444, 396);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(100, 20);
            this.Menor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Menor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mayor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Propietario";
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(444, 331);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(127, 20);
            this.Nombre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(650, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.informacionClientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView informacionClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Mayor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Menor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
    }
}

