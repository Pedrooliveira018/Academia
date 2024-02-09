namespace Academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numpeso = new System.Windows.Forms.NumericUpDown();
            this.numaltura = new System.Windows.Forms.NumericUpDown();
            this.dateduracao = new System.Windows.Forms.DateTimePicker();
            this.numpeso3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbatividade = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numpeso2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numpeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpeso3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpeso2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // numpeso
            // 
            this.numpeso.DecimalPlaces = 2;
            this.numpeso.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpeso.Location = new System.Drawing.Point(16, 48);
            this.numpeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numpeso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numpeso.Name = "numpeso";
            this.numpeso.Size = new System.Drawing.Size(134, 32);
            this.numpeso.TabIndex = 0;
            this.numpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpeso.ValueChanged += new System.EventHandler(this.numpeso_ValueChanged);
            // 
            // numaltura
            // 
            this.numaltura.DecimalPlaces = 2;
            this.numaltura.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numaltura.Location = new System.Drawing.Point(16, 168);
            this.numaltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numaltura.Name = "numaltura";
            this.numaltura.Size = new System.Drawing.Size(134, 32);
            this.numaltura.TabIndex = 1;
            this.numaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numaltura.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // dateduracao
            // 
            this.dateduracao.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateduracao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateduracao.Location = new System.Drawing.Point(16, 113);
            this.dateduracao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateduracao.MinDate = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            this.dateduracao.Name = "dateduracao";
            this.dateduracao.Size = new System.Drawing.Size(154, 32);
            this.dateduracao.TabIndex = 0;
            this.dateduracao.Value = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            this.dateduracao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numpeso3
            // 
            this.numpeso3.AccessibleDescription = "";
            this.numpeso3.AccessibleName = "";
            this.numpeso3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numpeso3.DecimalPlaces = 2;
            this.numpeso3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpeso3.Location = new System.Drawing.Point(17, 180);
            this.numpeso3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numpeso3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numpeso3.Name = "numpeso3";
            this.numpeso3.Size = new System.Drawing.Size(153, 32);
            this.numpeso3.TabIndex = 1;
            this.numpeso3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpeso3.ValueChanged += new System.EventHandler(this.numpeso3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbatividade
            // 
            this.cmbatividade.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbatividade.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmbatividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbatividade.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbatividade.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbatividade.FormattingEnabled = true;
            this.cmbatividade.Items.AddRange(new object[] {
            "Corrida",
            "Natação",
            "Caminhada",
            "Rit"});
            this.cmbatividade.Location = new System.Drawing.Point(13, 49);
            this.cmbatividade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbatividade.Name = "cmbatividade";
            this.cmbatividade.Size = new System.Drawing.Size(154, 30);
            this.cmbatividade.TabIndex = 2;
            this.cmbatividade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numpeso3);
            this.groupBox3.Controls.Add(this.dateduracao);
            this.groupBox3.Controls.Add(this.cmbatividade);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(413, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(337, 224);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contador de Calorias";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.lbl3);
            this.groupBox5.Location = new System.Drawing.Point(196, 48);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(133, 148);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Atividades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Altura";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.numpeso2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(353, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metas de Hidratação";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox6.Controls.Add(this.lblresultado2);
            this.groupBox6.Location = new System.Drawing.Point(182, 50);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(135, 148);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // numpeso2
            // 
            this.numpeso2.DecimalPlaces = 2;
            this.numpeso2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpeso2.Location = new System.Drawing.Point(16, 69);
            this.numpeso2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numpeso2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numpeso2.Name = "numpeso2";
            this.numpeso2.Size = new System.Drawing.Size(134, 29);
            this.numpeso2.TabIndex = 0;
            this.numpeso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpeso2.ValueChanged += new System.EventHandler(this.numpeso2_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.numaltura);
            this.groupBox2.Controls.Add(this.numpeso);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(353, 224);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMC";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.lblresultado);
            this.groupBox4.Location = new System.Drawing.Point(182, 48);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(135, 148);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(18, 37);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 16);
            this.lblresultado.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(469, 285);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Peso";
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(18, 43);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(0, 16);
            this.lblresultado2.TabIndex = 10;
            this.lblresultado2.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(31, 44);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 16);
            this.lbl3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numpeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpeso3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpeso2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numaltura;
        private System.Windows.Forms.NumericUpDown numpeso;
        private System.Windows.Forms.DateTimePicker dateduracao;
        private System.Windows.Forms.NumericUpDown numpeso3;
        private System.Windows.Forms.ComboBox cmbatividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numpeso2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label lbl3;
    }
}

