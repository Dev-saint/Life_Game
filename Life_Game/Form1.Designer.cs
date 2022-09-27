
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
            this.numericUpDown_Timer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDown_DensityPlantsEating = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Resolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityPredators = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityFood = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_DensityPoison = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPlantsEating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPoison)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityPoison);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityFood);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_DensityPredators);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_Timer);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStop);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
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
            // numericUpDown_Timer
            // 
            this.numericUpDown_Timer.Location = new System.Drawing.Point(13, 420);
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
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время тика";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(13, 497);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(182, 31);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(13, 459);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(182, 32);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDown_DensityPlantsEating
            // 
            this.numericUpDown_DensityPlantsEating.Location = new System.Drawing.Point(10, 117);
            this.numericUpDown_DensityPlantsEating.Maximum = new decimal(new int[] {
            25,
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
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плотность населения\r\nтравоядных клеток";
            // 
            // numericUpDown_Resolution
            // 
            this.numericUpDown_Resolution.Location = new System.Drawing.Point(13, 42);
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
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
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
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Плотность населения\r\nклеток-хищников";
            // 
            // numericUpDown_DensityPredators
            // 
            this.numericUpDown_DensityPredators.Location = new System.Drawing.Point(10, 192);
            this.numericUpDown_DensityPredators.Maximum = new decimal(new int[] {
            25,
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
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Плотность расположения еды\r\n";
            // 
            // numericUpDown_DensityFood
            // 
            this.numericUpDown_DensityFood.Location = new System.Drawing.Point(10, 253);
            this.numericUpDown_DensityFood.Maximum = new decimal(new int[] {
            25,
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
            25,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Плотность расположения яда";
            // 
            // numericUpDown_DensityPoison
            // 
            this.numericUpDown_DensityPoison.Location = new System.Drawing.Point(10, 315);
            this.numericUpDown_DensityPoison.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_DensityPoison.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DensityPoison.Name = "numericUpDown_DensityPoison";
            this.numericUpDown_DensityPoison.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_DensityPoison.TabIndex = 14;
            this.numericUpDown_DensityPoison.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_DensityPoison.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPlantsEating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DensityPoison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
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
    }
}

