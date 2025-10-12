namespace Laboratorio_3
{
    partial class Problema3
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
            this.Txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.NumVen = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltsCantidad = new System.Windows.Forms.ListBox();
            this.DgbCompleto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.bntImporte = new System.Windows.Forms.Button();
            this.DgbOrdenado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NumVen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCompleto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Font = new System.Drawing.Font("Poor Richard", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.ForeColor = System.Drawing.Color.White;
            this.Txt.Location = new System.Drawing.Point(304, 9);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(214, 35);
            this.Txt.TabIndex = 0;
            this.Txt.Text = "Ventas Anuales ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ventas Realizadas ";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(220, 60);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 4;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged_1);
            // 
            // NumVen
            // 
            this.NumVen.Location = new System.Drawing.Point(252, 25);
            this.NumVen.Name = "NumVen";
            this.NumVen.Size = new System.Drawing.Size(68, 22);
            this.NumVen.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.ltsCantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCant);
            this.panel1.Controls.Add(this.NumVen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 391);
            this.panel1.TabIndex = 6;
            // 
            // ltsCantidad
            // 
            this.ltsCantidad.FormattingEnabled = true;
            this.ltsCantidad.ItemHeight = 16;
            this.ltsCantidad.Location = new System.Drawing.Point(27, 101);
            this.ltsCantidad.Name = "ltsCantidad";
            this.ltsCantidad.Size = new System.Drawing.Size(199, 276);
            this.ltsCantidad.TabIndex = 7;
            // 
            // DgbCompleto
            // 
            this.DgbCompleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbCompleto.Location = new System.Drawing.Point(3, 60);
            this.DgbCompleto.Name = "DgbCompleto";
            this.DgbCompleto.RowHeadersWidth = 51;
            this.DgbCompleto.RowTemplate.Height = 24;
            this.DgbCompleto.Size = new System.Drawing.Size(201, 285);
            this.DgbCompleto.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.btnRefrescar);
            this.panel2.Controls.Add(this.btnOrdenar);
            this.panel2.Controls.Add(this.bntImporte);
            this.panel2.Controls.Add(this.DgbOrdenado);
            this.panel2.Controls.Add(this.DgbCompleto);
            this.panel2.Location = new System.Drawing.Point(350, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 391);
            this.panel2.TabIndex = 8;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(178, 349);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(92, 39);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(288, 15);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(92, 39);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // bntImporte
            // 
            this.bntImporte.Location = new System.Drawing.Point(52, 16);
            this.bntImporte.Name = "bntImporte";
            this.bntImporte.Size = new System.Drawing.Size(92, 39);
            this.bntImporte.TabIndex = 9;
            this.bntImporte.Text = "Importes";
            this.bntImporte.UseVisualStyleBackColor = true;
            this.bntImporte.Click += new System.EventHandler(this.bntImporte_Click);
            // 
            // DgbOrdenado
            // 
            this.DgbOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbOrdenado.Location = new System.Drawing.Point(234, 60);
            this.DgbOrdenado.Name = "DgbOrdenado";
            this.DgbOrdenado.RowHeadersWidth = 51;
            this.DgbOrdenado.RowTemplate.Height = 24;
            this.DgbOrdenado.Size = new System.Drawing.Size(201, 285);
            this.DgbOrdenado.TabIndex = 8;
            // 
            // Problema3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt);
            this.Name = "Problema3";
            this.Text = "Problema3";
            ((System.ComponentModel.ISupportInitialize)(this.NumVen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCompleto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgbOrdenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.NumericUpDown NumVen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ltsCantidad;
        private System.Windows.Forms.DataGridView DgbCompleto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button bntImporte;
        private System.Windows.Forms.DataGridView DgbOrdenado;
    }
}