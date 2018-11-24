namespace Lab_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeExact = new System.Windows.Forms.TextBox();
            this.labelTimeExact = new System.Windows.Forms.Label();
            this.textBoxMinChromaticExact = new System.Windows.Forms.TextBox();
            this.labelMinChromaticExact = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeGenetic = new System.Windows.Forms.TextBox();
            this.textBoxMinChromaticGenetic = new System.Windows.Forms.TextBox();
            this.labelTimeGenetic = new System.Windows.Forms.Label();
            this.labelMinChromaticGenetic = new System.Windows.Forms.Label();
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.nmrcFreqMut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chBxUseMutations = new System.Windows.Forms.CheckBox();
            this.lblUseMutations = new System.Windows.Forms.Label();
            this.nmrcCountChildren = new System.Windows.Forms.NumericUpDown();
            this.lblCountChildrenInGen = new System.Windows.Forms.Label();
            this.nmrcCountGen = new System.Windows.Forms.NumericUpDown();
            this.lblCountGen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFreqMut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountGen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(810, 375);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(108, 52);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Запустить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(604, 390);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "Условие";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxGraph.Location = new System.Drawing.Point(5, 18);
            this.pictureBoxGraph.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(567, 397);
            this.pictureBoxGraph.TabIndex = 2;
            this.pictureBoxGraph.TabStop = false;
            this.pictureBoxGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGraph_MouseDown);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(722, 390);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTimeExact);
            this.groupBox1.Controls.Add(this.labelTimeExact);
            this.groupBox1.Controls.Add(this.textBoxMinChromaticExact);
            this.groupBox1.Controls.Add(this.labelMinChromaticExact);
            this.groupBox1.Location = new System.Drawing.Point(595, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Точное решение";
            // 
            // textBoxTimeExact
            // 
            this.textBoxTimeExact.Location = new System.Drawing.Point(198, 42);
            this.textBoxTimeExact.Name = "textBoxTimeExact";
            this.textBoxTimeExact.ReadOnly = true;
            this.textBoxTimeExact.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeExact.TabIndex = 3;
            // 
            // labelTimeExact
            // 
            this.labelTimeExact.AutoSize = true;
            this.labelTimeExact.Location = new System.Drawing.Point(6, 45);
            this.labelTimeExact.Name = "labelTimeExact";
            this.labelTimeExact.Size = new System.Drawing.Size(113, 13);
            this.labelTimeExact.TabIndex = 2;
            this.labelTimeExact.Text = "Затраченное время: ";
            // 
            // textBoxMinChromaticExact
            // 
            this.textBoxMinChromaticExact.Location = new System.Drawing.Point(198, 13);
            this.textBoxMinChromaticExact.Name = "textBoxMinChromaticExact";
            this.textBoxMinChromaticExact.ReadOnly = true;
            this.textBoxMinChromaticExact.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinChromaticExact.TabIndex = 1;
            // 
            // labelMinChromaticExact
            // 
            this.labelMinChromaticExact.AutoSize = true;
            this.labelMinChromaticExact.Location = new System.Drawing.Point(6, 16);
            this.labelMinChromaticExact.Name = "labelMinChromaticExact";
            this.labelMinChromaticExact.Size = new System.Drawing.Size(196, 13);
            this.labelMinChromaticExact.TabIndex = 0;
            this.labelMinChromaticExact.Text = "Минимальное хроматическое число: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmrcFreqMut);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chBxUseMutations);
            this.groupBox2.Controls.Add(this.lblUseMutations);
            this.groupBox2.Controls.Add(this.nmrcCountChildren);
            this.groupBox2.Controls.Add(this.lblCountChildrenInGen);
            this.groupBox2.Controls.Add(this.nmrcCountGen);
            this.groupBox2.Controls.Add(this.lblCountGen);
            this.groupBox2.Controls.Add(this.textBoxTimeGenetic);
            this.groupBox2.Controls.Add(this.textBoxMinChromaticGenetic);
            this.groupBox2.Controls.Add(this.labelTimeGenetic);
            this.groupBox2.Controls.Add(this.labelMinChromaticGenetic);
            this.groupBox2.Location = new System.Drawing.Point(595, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генетический алгоритм";
            // 
            // textBoxTimeGenetic
            // 
            this.textBoxTimeGenetic.Location = new System.Drawing.Point(198, 40);
            this.textBoxTimeGenetic.Name = "textBoxTimeGenetic";
            this.textBoxTimeGenetic.ReadOnly = true;
            this.textBoxTimeGenetic.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeGenetic.TabIndex = 5;
            // 
            // textBoxMinChromaticGenetic
            // 
            this.textBoxMinChromaticGenetic.Location = new System.Drawing.Point(198, 13);
            this.textBoxMinChromaticGenetic.Name = "textBoxMinChromaticGenetic";
            this.textBoxMinChromaticGenetic.ReadOnly = true;
            this.textBoxMinChromaticGenetic.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinChromaticGenetic.TabIndex = 3;
            // 
            // labelTimeGenetic
            // 
            this.labelTimeGenetic.AutoSize = true;
            this.labelTimeGenetic.Location = new System.Drawing.Point(6, 43);
            this.labelTimeGenetic.Name = "labelTimeGenetic";
            this.labelTimeGenetic.Size = new System.Drawing.Size(113, 13);
            this.labelTimeGenetic.TabIndex = 4;
            this.labelTimeGenetic.Text = "Затраченное время: ";
            // 
            // labelMinChromaticGenetic
            // 
            this.labelMinChromaticGenetic.AutoSize = true;
            this.labelMinChromaticGenetic.Location = new System.Drawing.Point(6, 16);
            this.labelMinChromaticGenetic.Name = "labelMinChromaticGenetic";
            this.labelMinChromaticGenetic.Size = new System.Drawing.Size(196, 13);
            this.labelMinChromaticGenetic.TabIndex = 2;
            this.labelMinChromaticGenetic.Text = "Минимальное хроматическое число: ";
            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Controls.Add(this.pictureBoxGraph);
            this.groupBoxGraph.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Size = new System.Drawing.Size(577, 420);
            this.groupBoxGraph.TabIndex = 6;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "Поле для ввода графа";
            // 
            // nmrcFreqMut
            // 
            this.nmrcFreqMut.DecimalPlaces = 2;
            this.nmrcFreqMut.Enabled = false;
            this.nmrcFreqMut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrcFreqMut.Location = new System.Drawing.Point(198, 138);
            this.nmrcFreqMut.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcFreqMut.Name = "nmrcFreqMut";
            this.nmrcFreqMut.Size = new System.Drawing.Size(100, 20);
            this.nmrcFreqMut.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Частота мутаций:";
            // 
            // chBxUseMutations
            // 
            this.chBxUseMutations.AutoSize = true;
            this.chBxUseMutations.Location = new System.Drawing.Point(198, 117);
            this.chBxUseMutations.Name = "chBxUseMutations";
            this.chBxUseMutations.Size = new System.Drawing.Size(15, 14);
            this.chBxUseMutations.TabIndex = 26;
            this.chBxUseMutations.UseVisualStyleBackColor = true;
            // 
            // lblUseMutations
            // 
            this.lblUseMutations.AutoSize = true;
            this.lblUseMutations.Location = new System.Drawing.Point(6, 118);
            this.lblUseMutations.Name = "lblUseMutations";
            this.lblUseMutations.Size = new System.Drawing.Size(131, 13);
            this.lblUseMutations.TabIndex = 25;
            this.lblUseMutations.Text = "Использовать мутации: ";
            // 
            // nmrcCountChildren
            // 
            this.nmrcCountChildren.Location = new System.Drawing.Point(198, 92);
            this.nmrcCountChildren.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcCountChildren.Name = "nmrcCountChildren";
            this.nmrcCountChildren.Size = new System.Drawing.Size(100, 20);
            this.nmrcCountChildren.TabIndex = 24;
            // 
            // lblCountChildrenInGen
            // 
            this.lblCountChildrenInGen.AutoSize = true;
            this.lblCountChildrenInGen.Location = new System.Drawing.Point(6, 94);
            this.lblCountChildrenInGen.Name = "lblCountChildrenInGen";
            this.lblCountChildrenInGen.Size = new System.Drawing.Size(164, 13);
            this.lblCountChildrenInGen.TabIndex = 23;
            this.lblCountChildrenInGen.Text = "Кол-во особоей в полколении: ";
            // 
            // nmrcCountGen
            // 
            this.nmrcCountGen.Location = new System.Drawing.Point(198, 66);
            this.nmrcCountGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcCountGen.Name = "nmrcCountGen";
            this.nmrcCountGen.Size = new System.Drawing.Size(100, 20);
            this.nmrcCountGen.TabIndex = 22;
            // 
            // lblCountGen
            // 
            this.lblCountGen.AutoSize = true;
            this.lblCountGen.Location = new System.Drawing.Point(6, 68);
            this.lblCountGen.Name = "lblCountGen";
            this.lblCountGen.Size = new System.Drawing.Size(110, 13);
            this.lblCountGen.TabIndex = 21;
            this.lblCountGen.Text = "Кол-во полколений: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 446);
            this.Controls.Add(this.groupBoxGraph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonRun);
            this.Name = "MainForm";
            this.Text = "Задача 5b. Раскраска графа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFreqMut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMinChromaticExact;
        private System.Windows.Forms.Label labelMinChromaticExact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMinChromaticGenetic;
        private System.Windows.Forms.Label labelMinChromaticGenetic;
        private System.Windows.Forms.GroupBox groupBoxGraph;
        private System.Windows.Forms.TextBox textBoxTimeExact;
        private System.Windows.Forms.Label labelTimeExact;
        private System.Windows.Forms.TextBox textBoxTimeGenetic;
        private System.Windows.Forms.Label labelTimeGenetic;
        private System.Windows.Forms.NumericUpDown nmrcFreqMut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBxUseMutations;
        private System.Windows.Forms.Label lblUseMutations;
        private System.Windows.Forms.NumericUpDown nmrcCountChildren;
        private System.Windows.Forms.Label lblCountChildrenInGen;
        private System.Windows.Forms.NumericUpDown nmrcCountGen;
        private System.Windows.Forms.Label lblCountGen;
    }
}

