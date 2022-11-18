namespace Life_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxTypesOfCells = new System.Windows.Forms.ListBox();
            this.numericUpDown_FoodBirth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityPoison = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityFood = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityPredators = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Timer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityPlantsEating = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Resolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FoodBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPoison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPlantsEating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxTypesOfCells);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxStop);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxStart);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_FoodBirth);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityPoison);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityFood);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityPredators);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_Timer);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityPlantsEating);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_Resolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 552);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxTypesOfCells
            // 
            this.listBoxTypesOfCells.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTypesOfCells.FormattingEnabled = true;
            this.listBoxTypesOfCells.ItemHeight = 20;
            this.listBoxTypesOfCells.Items.AddRange(new object[] {
            "Травоядные",
            "Хищники",
            "Растительная еда",
            "Яд"});
            this.listBoxTypesOfCells.Location = new System.Drawing.Point(72, 415);
            this.listBoxTypesOfCells.Name = "listBoxTypesOfCells";
            this.listBoxTypesOfCells.Size = new System.Drawing.Size(166, 124);
            this.listBoxTypesOfCells.TabIndex = 19;
            // 
            // numericUpDown_FoodBirth
            // 
            this.numericUpDown_FoodBirth.Location = new System.Drawing.Point(10, 286);
            this.numericUpDown_FoodBirth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_FoodBirth.Name = "numericUpDown_FoodBirth";
            this.numericUpDown_FoodBirth.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_FoodBirth.TabIndex = 17;
            this.numericUpDown_FoodBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FoodBirth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "Шанс появления клеток еды\r\nв следующем поколении";
            // 
            // numericUpDown_DensityPoison
            // 
            this.numericUpDown_DensityPoison.Location = new System.Drawing.Point(10, 226);
            this.numericUpDown_DensityPoison.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_DensityPoison.Name = "numericUpDown_DensityPoison";
            this.numericUpDown_DensityPoison.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_DensityPoison.TabIndex = 14;
            this.numericUpDown_DensityPoison.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_DensityPoison.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Плотность расположения яда";
            // 
            // numericUpDown_DensityFood
            // 
            this.numericUpDown_DensityFood.Location = new System.Drawing.Point(10, 183);
            this.numericUpDown_DensityFood.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_DensityFood.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DensityFood.Name = "numericUpDown_DensityFood";
            this.numericUpDown_DensityFood.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_DensityFood.TabIndex = 12;
            this.numericUpDown_DensityFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_DensityFood.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Плотность расположения еды\r\n";
            // 
            // numericUpDown_DensityPredators
            // 
            this.numericUpDown_DensityPredators.Location = new System.Drawing.Point(10, 140);
            this.numericUpDown_DensityPredators.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_DensityPredators.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DensityPredators.Name = "numericUpDown_DensityPredators";
            this.numericUpDown_DensityPredators.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_DensityPredators.TabIndex = 10;
            this.numericUpDown_DensityPredators.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_DensityPredators.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Плотность населения\r\nклеток-хищников";
            // 
            // numericUpDown_Timer
            // 
            this.numericUpDown_Timer.Location = new System.Drawing.Point(10, 389);
            this.numericUpDown_Timer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Timer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Timer.Name = "numericUpDown_Timer";
            this.numericUpDown_Timer.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_Timer.TabIndex = 8;
            this.numericUpDown_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Timer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время тика";
            // 
            // numericUpDown_DensityPlantsEating
            // 
            this.numericUpDown_DensityPlantsEating.Location = new System.Drawing.Point(10, 80);
            this.numericUpDown_DensityPlantsEating.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_DensityPlantsEating.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DensityPlantsEating.Name = "numericUpDown_DensityPlantsEating";
            this.numericUpDown_DensityPlantsEating.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_DensityPlantsEating.TabIndex = 4;
            this.numericUpDown_DensityPlantsEating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_DensityPlantsEating.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плотность населения\r\nтравоядных клеток";
            // 
            // numericUpDown_Resolution
            // 
            this.numericUpDown_Resolution.Location = new System.Drawing.Point(10, 20);
            this.numericUpDown_Resolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_Resolution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_Resolution.Name = "numericUpDown_Resolution";
            this.numericUpDown_Resolution.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_Resolution.TabIndex = 2;
            this.numericUpDown_Resolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Resolution.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStop.Image = global::Life_Game.Resource1.pictureBoxStop_Image;
            this.pictureBoxStop.Location = new System.Drawing.Point(10, 480);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(61, 59);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop.TabIndex = 20;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStart.Image = global::Life_Game.Resource1.pictureBoxStart_Image;
            this.pictureBoxStart.Location = new System.Drawing.Point(10, 415);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(61, 59);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 19;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Life Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FoodBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPoison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPlantsEating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Resolution;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_DensityPlantsEating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_DensityPredators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_DensityPoison;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_DensityFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_FoodBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.ListBox listBoxTypesOfCells;
        private System.Windows.Forms.PictureBox pictureBoxStop;
    }
}