namespace ForwardCheckingOrar
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
            this.gridOrar = new System.Windows.Forms.DataGridView();
            this.btnGenereazaOrar = new System.Windows.Forms.Button();
            this.listGrupe = new System.Windows.Forms.ListBox();
            this.listSali = new System.Windows.Forms.ListBox();
            this.btnAdaugaGrupa = new System.Windows.Forms.Button();
            this.btnAdaugaSala = new System.Windows.Forms.Button();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtGrupa = new System.Windows.Forms.TextBox();
            this.txtIntervale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exemplu2 = new System.Windows.Forms.Button();
            this.exemplu3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sterge1 = new System.Windows.Forms.Button();
            this.sterge2 = new System.Windows.Forms.Button();
            this.btnRezervaSala = new System.Windows.Forms.Button();
            this.txtIntervalStart = new System.Windows.Forms.MaskedTextBox();
            this.txtIntervalEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStergeOrar = new System.Windows.Forms.Button();
            this.Grupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrar
            // 
            this.gridOrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupa,
            this.SalaCol,
            this.Interval});
            this.gridOrar.Location = new System.Drawing.Point(12, 12);
            this.gridOrar.Name = "gridOrar";
            this.gridOrar.Size = new System.Drawing.Size(343, 388);
            this.gridOrar.TabIndex = 0;
            // 
            // btnGenereazaOrar
            // 
            this.btnGenereazaOrar.Location = new System.Drawing.Point(71, 415);
            this.btnGenereazaOrar.Name = "btnGenereazaOrar";
            this.btnGenereazaOrar.Size = new System.Drawing.Size(94, 23);
            this.btnGenereazaOrar.TabIndex = 1;
            this.btnGenereazaOrar.Text = "Genereaza orar\r\n";
            this.btnGenereazaOrar.UseVisualStyleBackColor = true;
            this.btnGenereazaOrar.Click += new System.EventHandler(this.btnGenereazaOrar_Click);
            // 
            // listGrupe
            // 
            this.listGrupe.FormattingEnabled = true;
            this.listGrupe.Location = new System.Drawing.Point(449, 12);
            this.listGrupe.Name = "listGrupe";
            this.listGrupe.Size = new System.Drawing.Size(176, 160);
            this.listGrupe.TabIndex = 2;
            // 
            // listSali
            // 
            this.listSali.FormattingEnabled = true;
            this.listSali.Location = new System.Drawing.Point(668, 12);
            this.listSali.Name = "listSali";
            this.listSali.Size = new System.Drawing.Size(197, 160);
            this.listSali.TabIndex = 3;
            // 
            // btnAdaugaGrupa
            // 
            this.btnAdaugaGrupa.Location = new System.Drawing.Point(512, 272);
            this.btnAdaugaGrupa.Name = "btnAdaugaGrupa";
            this.btnAdaugaGrupa.Size = new System.Drawing.Size(87, 23);
            this.btnAdaugaGrupa.TabIndex = 4;
            this.btnAdaugaGrupa.Text = "Adauga grupa";
            this.btnAdaugaGrupa.UseVisualStyleBackColor = true;
            this.btnAdaugaGrupa.Click += new System.EventHandler(this.btnAdaugaGrupa_Click);
            // 
            // btnAdaugaSala
            // 
            this.btnAdaugaSala.Location = new System.Drawing.Point(750, 207);
            this.btnAdaugaSala.Name = "btnAdaugaSala";
            this.btnAdaugaSala.Size = new System.Drawing.Size(80, 23);
            this.btnAdaugaSala.TabIndex = 5;
            this.btnAdaugaSala.Text = "Adauga sala";
            this.btnAdaugaSala.UseVisualStyleBackColor = true;
            this.btnAdaugaSala.Click += new System.EventHandler(this.btnAdaugaSala_Click);
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(750, 181);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(80, 20);
            this.txtSala.TabIndex = 6;
            // 
            // txtGrupa
            // 
            this.txtGrupa.Location = new System.Drawing.Point(512, 188);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.Size = new System.Drawing.Size(87, 20);
            this.txtGrupa.TabIndex = 7;
            // 
            // txtIntervale
            // 
            this.txtIntervale.Location = new System.Drawing.Point(512, 229);
            this.txtIntervale.Name = "txtIntervale";
            this.txtIntervale.Size = new System.Drawing.Size(87, 20);
            this.txtIntervale.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grupa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Intervale grupa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exemplu 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exemplu2
            // 
            this.exemplu2.Location = new System.Drawing.Point(577, 410);
            this.exemplu2.Name = "exemplu2";
            this.exemplu2.Size = new System.Drawing.Size(67, 23);
            this.exemplu2.TabIndex = 13;
            this.exemplu2.Text = "Exemplu 2";
            this.exemplu2.UseVisualStyleBackColor = true;
            this.exemplu2.Click += new System.EventHandler(this.exemplu2_Click);
            // 
            // exemplu3
            // 
            this.exemplu3.Location = new System.Drawing.Point(666, 410);
            this.exemplu3.Name = "exemplu3";
            this.exemplu3.Size = new System.Drawing.Size(67, 23);
            this.exemplu3.TabIndex = 14;
            this.exemplu3.Text = "Exemplu 3";
            this.exemplu3.UseVisualStyleBackColor = true;
            this.exemplu3.Click += new System.EventHandler(this.exemplu3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Exemple";
            // 
            // sterge1
            // 
            this.sterge1.Location = new System.Drawing.Point(512, 324);
            this.sterge1.Name = "sterge1";
            this.sterge1.Size = new System.Drawing.Size(87, 23);
            this.sterge1.TabIndex = 16;
            this.sterge1.Text = "Sterge Grupe";
            this.sterge1.UseVisualStyleBackColor = true;
            this.sterge1.Click += new System.EventHandler(this.sterge1_Click);
            // 
            // sterge2
            // 
            this.sterge2.Location = new System.Drawing.Point(714, 324);
            this.sterge2.Name = "sterge2";
            this.sterge2.Size = new System.Drawing.Size(91, 23);
            this.sterge2.TabIndex = 17;
            this.sterge2.Text = "Sterge Sali";
            this.sterge2.UseVisualStyleBackColor = true;
            this.sterge2.Click += new System.EventHandler(this.sterge2_Click);
            // 
            // btnRezervaSala
            // 
            this.btnRezervaSala.Location = new System.Drawing.Point(695, 285);
            this.btnRezervaSala.Name = "btnRezervaSala";
            this.btnRezervaSala.Size = new System.Drawing.Size(135, 23);
            this.btnRezervaSala.TabIndex = 18;
            this.btnRezervaSala.Text = "Rezerva sala";
            this.btnRezervaSala.UseVisualStyleBackColor = true;
            this.btnRezervaSala.Click += new System.EventHandler(this.btnRezervaSala_Click);
            // 
            // txtIntervalStart
            // 
            this.txtIntervalStart.Location = new System.Drawing.Point(693, 259);
            this.txtIntervalStart.Name = "txtIntervalStart";
            this.txtIntervalStart.Size = new System.Drawing.Size(65, 20);
            this.txtIntervalStart.TabIndex = 19;
            // 
            // txtIntervalEnd
            // 
            this.txtIntervalEnd.Location = new System.Drawing.Point(764, 259);
            this.txtIntervalEnd.Name = "txtIntervalEnd";
            this.txtIntervalEnd.Size = new System.Drawing.Size(66, 20);
            this.txtIntervalEnd.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "De la";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pana la";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Rezervare";
            // 
            // btnStergeOrar
            // 
            this.btnStergeOrar.Location = new System.Drawing.Point(171, 415);
            this.btnStergeOrar.Name = "btnStergeOrar";
            this.btnStergeOrar.Size = new System.Drawing.Size(94, 23);
            this.btnStergeOrar.TabIndex = 24;
            this.btnStergeOrar.Text = "Sterge orar";
            this.btnStergeOrar.UseVisualStyleBackColor = true;
            this.btnStergeOrar.Click += new System.EventHandler(this.btnStergeOrar_Click);
            // 
            // Grupa
            // 
            this.Grupa.HeaderText = "Grupa";
            this.Grupa.Name = "Grupa";
            // 
            // SalaCol
            // 
            this.SalaCol.HeaderText = "Sala";
            this.SalaCol.Name = "SalaCol";
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnStergeOrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIntervalEnd);
            this.Controls.Add(this.txtIntervalStart);
            this.Controls.Add(this.btnRezervaSala);
            this.Controls.Add(this.sterge2);
            this.Controls.Add(this.sterge1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exemplu3);
            this.Controls.Add(this.exemplu2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervale);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.btnAdaugaSala);
            this.Controls.Add(this.btnAdaugaGrupa);
            this.Controls.Add(this.listSali);
            this.Controls.Add(this.listGrupe);
            this.Controls.Add(this.btnGenereazaOrar);
            this.Controls.Add(this.gridOrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrar;
        private System.Windows.Forms.Button btnGenereazaOrar;
        private System.Windows.Forms.ListBox listGrupe;
        private System.Windows.Forms.ListBox listSali;
        private System.Windows.Forms.Button btnAdaugaGrupa;
        private System.Windows.Forms.Button btnAdaugaSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtGrupa;
        private System.Windows.Forms.TextBox txtIntervale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exemplu2;
        private System.Windows.Forms.Button exemplu3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sterge1;
        private System.Windows.Forms.Button sterge2;
        private System.Windows.Forms.Button btnRezervaSala;
        private System.Windows.Forms.MaskedTextBox txtIntervalStart;
        private System.Windows.Forms.TextBox txtIntervalEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStergeOrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
    }
}

