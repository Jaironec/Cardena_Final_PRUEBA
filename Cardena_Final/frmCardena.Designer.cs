
namespace Cardena_Final
{
    partial class frmCardena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtHoras_dic = new System.Windows.Forms.TextBox();
            this.txtHoras_rec = new System.Windows.Forms.TextBox();
            this.txtHoras_otr = new System.Windows.Forms.TextBox();
            this.txtHoras_tota = new System.Windows.Forms.TextBox();
            this.dataGridViewFinal = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoras_Perd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas dictadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horas recuperadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horas otras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horas totales";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(201, 45);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(121, 20);
            this.txtAnio.TabIndex = 8;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(201, 70);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(121, 20);
            this.txtMes.TabIndex = 9;
            // 
            // txtHoras_dic
            // 
            this.txtHoras_dic.Location = new System.Drawing.Point(201, 96);
            this.txtHoras_dic.MaxLength = 2;
            this.txtHoras_dic.Name = "txtHoras_dic";
            this.txtHoras_dic.Size = new System.Drawing.Size(121, 20);
            this.txtHoras_dic.TabIndex = 10;
            // 
            // txtHoras_rec
            // 
            this.txtHoras_rec.Location = new System.Drawing.Point(225, 151);
            this.txtHoras_rec.MaxLength = 2;
            this.txtHoras_rec.Name = "txtHoras_rec";
            this.txtHoras_rec.Size = new System.Drawing.Size(121, 20);
            this.txtHoras_rec.TabIndex = 11;
            // 
            // txtHoras_otr
            // 
            this.txtHoras_otr.Location = new System.Drawing.Point(225, 177);
            this.txtHoras_otr.MaxLength = 2;
            this.txtHoras_otr.Name = "txtHoras_otr";
            this.txtHoras_otr.Size = new System.Drawing.Size(121, 20);
            this.txtHoras_otr.TabIndex = 12;
            // 
            // txtHoras_tota
            // 
            this.txtHoras_tota.Location = new System.Drawing.Point(225, 203);
            this.txtHoras_tota.MaxLength = 3;
            this.txtHoras_tota.Name = "txtHoras_tota";
            this.txtHoras_tota.ReadOnly = true;
            this.txtHoras_tota.Size = new System.Drawing.Size(121, 20);
            this.txtHoras_tota.TabIndex = 13;
            // 
            // dataGridViewFinal
            // 
            this.dataGridViewFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinal.Location = new System.Drawing.Point(31, 257);
            this.dataGridViewFinal.Name = "dataGridViewFinal";
            this.dataGridViewFinal.Size = new System.Drawing.Size(739, 150);
            this.dataGridViewFinal.TabIndex = 14;
            this.dataGridViewFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinal_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(470, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(470, 90);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(201, 18);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurso.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Horas Perdidas";
            // 
            // txtHoras_Perd
            // 
            this.txtHoras_Perd.Location = new System.Drawing.Point(201, 125);
            this.txtHoras_Perd.MaxLength = 2;
            this.txtHoras_Perd.Name = "txtHoras_Perd";
            this.txtHoras_Perd.Size = new System.Drawing.Size(121, 20);
            this.txtHoras_Perd.TabIndex = 19;
            // 
            // frmCardena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoras_Perd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridViewFinal);
            this.Controls.Add(this.txtHoras_tota);
            this.Controls.Add(this.txtHoras_otr);
            this.Controls.Add(this.txtHoras_rec);
            this.Controls.Add(this.txtHoras_dic);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCardena";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCardena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtHoras_dic;
        private System.Windows.Forms.TextBox txtHoras_rec;
        private System.Windows.Forms.TextBox txtHoras_otr;
        private System.Windows.Forms.TextBox txtHoras_tota;
        private System.Windows.Forms.DataGridView dataGridViewFinal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoras_Perd;
    }
}

