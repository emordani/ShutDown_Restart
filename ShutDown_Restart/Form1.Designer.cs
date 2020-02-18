namespace ShutDown_Restart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.numericHour = new System.Windows.Forms.NumericUpDown();
            this.numericMinute = new System.Windows.Forms.NumericUpDown();
            this.numericSecond = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioShutDown = new System.Windows.Forms.RadioButton();
            this.radioRestart = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.radioInterval = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(250, 33);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(16, 13);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "h:";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(327, 33);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(18, 13);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "m:";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(406, 33);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(15, 13);
            this.labelSeconds.TabIndex = 2;
            this.labelSeconds.Text = "s:";
            // 
            // numericHour
            // 
            this.numericHour.Location = new System.Drawing.Point(269, 33);
            this.numericHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHour.Name = "numericHour";
            this.numericHour.Size = new System.Drawing.Size(40, 20);
            this.numericHour.TabIndex = 3;
            // 
            // numericMinute
            // 
            this.numericMinute.Location = new System.Drawing.Point(351, 33);
            this.numericMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericMinute.Name = "numericMinute";
            this.numericMinute.Size = new System.Drawing.Size(40, 20);
            this.numericMinute.TabIndex = 4;
            // 
            // numericSecond
            // 
            this.numericSecond.Location = new System.Drawing.Point(427, 33);
            this.numericSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericSecond.Name = "numericSecond";
            this.numericSecond.Size = new System.Drawing.Size(40, 20);
            this.numericSecond.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioShutDown);
            this.groupBox1.Controls.Add(this.radioRestart);
            this.groupBox1.Location = new System.Drawing.Point(25, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power option";
            // 
            // radioShutDown
            // 
            this.radioShutDown.AutoSize = true;
            this.radioShutDown.Location = new System.Drawing.Point(6, 19);
            this.radioShutDown.Name = "radioShutDown";
            this.radioShutDown.Size = new System.Drawing.Size(76, 17);
            this.radioShutDown.TabIndex = 8;
            this.radioShutDown.TabStop = true;
            this.radioShutDown.Text = "Shut down";
            this.radioShutDown.UseVisualStyleBackColor = true;
            // 
            // radioRestart
            // 
            this.radioRestart.AutoSize = true;
            this.radioRestart.Location = new System.Drawing.Point(6, 51);
            this.radioRestart.Name = "radioRestart";
            this.radioRestart.Size = new System.Drawing.Size(59, 17);
            this.radioRestart.TabIndex = 8;
            this.radioRestart.TabStop = true;
            this.radioRestart.Text = "Restart";
            this.radioRestart.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTime);
            this.groupBox2.Controls.Add(this.radioInterval);
            this.groupBox2.Location = new System.Drawing.Point(25, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time option";
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(6, 52);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(74, 17);
            this.radioTime.TabIndex = 10;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "Exact time";
            this.radioTime.UseVisualStyleBackColor = true;
            // 
            // radioInterval
            // 
            this.radioInterval.AutoSize = true;
            this.radioInterval.Location = new System.Drawing.Point(6, 19);
            this.radioInterval.Name = "radioInterval";
            this.radioInterval.Size = new System.Drawing.Size(85, 17);
            this.radioInterval.TabIndex = 9;
            this.radioInterval.TabStop = true;
            this.radioInterval.Text = "Time interval";
            this.radioInterval.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(253, 218);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 25);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(351, 218);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(61, 25);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select power and time option!";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(499, 33);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 20);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericSecond);
            this.Controls.Add(this.numericMinute);
            this.Controls.Add(this.numericHour);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Power";
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.NumericUpDown numericHour;
        private System.Windows.Forms.NumericUpDown numericMinute;
        private System.Windows.Forms.NumericUpDown numericSecond;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioShutDown;
        private System.Windows.Forms.RadioButton radioRestart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.RadioButton radioInterval;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
    }
}

