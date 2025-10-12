namespace Laboratorio_3
{
    partial class Problema4
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.bntImporte = new System.Windows.Forms.Button();
            this.DgbCompleto = new System.Windows.Forms.DataGridView();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.ltsCantidad = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumVen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgbOrdenado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgbOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(493, 408);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(111, 32);
            this.btnRefrescar.TabIndex = 23;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(629, 89);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 22;
            this.btnOrdenar.Text = "Ordenar ";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // bntImporte
            // 
            this.bntImporte.Location = new System.Drawing.Point(407, 89);
            this.bntImporte.Name = "bntImporte";
            this.bntImporte.Size = new System.Drawing.Size(75, 23);
            this.bntImporte.TabIndex = 21;
            this.bntImporte.Text = "Importe";
            this.bntImporte.UseVisualStyleBackColor = true;
            // 
            // DgbCompleto
            // 
            this.DgbCompleto.AllowUserToOrderColumns = true;
            this.DgbCompleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbCompleto.Location = new System.Drawing.Point(328, 125);
            this.DgbCompleto.Name = "DgbCompleto";
            this.DgbCompleto.RowHeadersWidth = 51;
            this.DgbCompleto.RowTemplate.Height = 24;
            this.DgbCompleto.Size = new System.Drawing.Size(220, 260);
            this.DgbCompleto.TabIndex = 20;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(167, 115);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 19;
            // 
            // ltsCantidad
            // 
            this.ltsCantidad.FormattingEnabled = true;
            this.ltsCantidad.ItemHeight = 16;
            this.ltsCantidad.Location = new System.Drawing.Point(31, 169);
            this.ltsCantidad.Name = "ltsCantidad";
            this.ltsCantidad.Size = new System.Drawing.Size(119, 244);
            this.ltsCantidad.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtG", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad";
            // 
            // NumVen
            // 
            this.NumVen.Location = new System.Drawing.Point(292, 80);
            this.NumVen.Name = "NumVen";
            this.NumVen.Size = new System.Drawing.Size(73, 22);
            this.NumVen.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtG", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ventas Realizadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtG", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ventas Anual";
            // 
            // DgbOrdenado
            // 
            this.DgbOrdenado.AllowUserToOrderColumns = true;
            this.DgbOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbOrdenado.Location = new System.Drawing.Point(554, 125);
            this.DgbOrdenado.Name = "DgbOrdenado";
            this.DgbOrdenado.RowHeadersWidth = 51;
            this.DgbOrdenado.RowTemplate.Height = 24;
            this.DgbOrdenado.Size = new System.Drawing.Size(220, 260);
            this.DgbOrdenado.TabIndex = 13;
            // 
            // Problema4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.bntImporte);
            this.Controls.Add(this.DgbCompleto);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.ltsCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumVen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgbOrdenado);
            this.Name = "Problema4";
            this.Text = "Problema4";
            ((System.ComponentModel.ISupportInitialize)(this.DgbCompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgbOrdenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button bntImporte;
        private System.Windows.Forms.DataGridView DgbCompleto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.ListBox ltsCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgbOrdenado;
    }
}