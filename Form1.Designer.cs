namespace RPoint
{
    partial class FormFractal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxViewing = new System.Windows.Forms.PictureBox();
            this.labelP1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownPointX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPointY = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownCountPoint = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCaption = new System.Windows.Forms.Label();
            this.comboBoxRatio = new System.Windows.Forms.ComboBox();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.numericUpDownPaperY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPaperX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonErase = new System.Windows.Forms.Button();
            this.numericUpDownAllPoint = new System.Windows.Forms.NumericUpDown();
            this.labelAllPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaperY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaperX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAllPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxViewing
            // 
            this.pictureBoxViewing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxViewing.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBoxViewing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxViewing.Location = new System.Drawing.Point(223, 12);
            this.pictureBoxViewing.Name = "pictureBoxViewing";
            this.pictureBoxViewing.Size = new System.Drawing.Size(596, 426);
            this.pictureBoxViewing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxViewing.TabIndex = 0;
            this.pictureBoxViewing.TabStop = false;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(13, 80);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(31, 13);
            this.labelP1.TabIndex = 2;
            this.labelP1.Text = "Point";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalculate.Location = new System.Drawing.Point(153, 411);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(64, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // numericUpDownPointX
            // 
            this.numericUpDownPointX.DecimalPlaces = 3;
            this.numericUpDownPointX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPointX.Location = new System.Drawing.Point(68, 75);
            this.numericUpDownPointX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPointX.Name = "numericUpDownPointX";
            this.numericUpDownPointX.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownPointX.TabIndex = 6;
            this.numericUpDownPointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownPointY
            // 
            this.numericUpDownPointY.DecimalPlaces = 3;
            this.numericUpDownPointY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPointY.Location = new System.Drawing.Point(153, 75);
            this.numericUpDownPointY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPointY.Name = "numericUpDownPointY";
            this.numericUpDownPointY.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownPointY.TabIndex = 7;
            this.numericUpDownPointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewPoints.Location = new System.Drawing.Point(16, 108);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.Size = new System.Drawing.Size(201, 184);
            this.dataGridViewPoints.TabIndex = 8;
            // 
            // X
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.X.DefaultCellStyle = dataGridViewCellStyle1;
            this.X.HeaderText = "X";
            this.X.MaxInputLength = 4;
            this.X.MinimumWidth = 30;
            this.X.Name = "X";
            this.X.ToolTipText = "Point coordinate on the X axis";
            this.X.Width = 75;
            // 
            // Y
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.Y.DefaultCellStyle = dataGridViewCellStyle2;
            this.Y.HeaderText = "Y";
            this.Y.MaxInputLength = 4;
            this.Y.MinimumWidth = 30;
            this.Y.Name = "Y";
            this.Y.ToolTipText = "Point coordinate on the Y axis";
            this.Y.Width = 75;
            // 
            // numericUpDownCountPoint
            // 
            this.numericUpDownCountPoint.Location = new System.Drawing.Point(130, 12);
            this.numericUpDownCountPoint.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCountPoint.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCountPoint.Name = "numericUpDownCountPoint";
            this.numericUpDownCountPoint.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownCountPoint.TabIndex = 9;
            this.numericUpDownCountPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCountPoint.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(13, 14);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(87, 13);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Number of points";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandom.Location = new System.Drawing.Point(16, 411);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(61, 23);
            this.buttonRandom.TabIndex = 11;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(80, 411);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(67, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(12, 356);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(206, 13);
            this.labelCaption.TabIndex = 13;
            this.labelCaption.Text = "The ratio of the distances to the new point";
            // 
            // comboBoxRatio
            // 
            this.comboBoxRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRatio.FormattingEnabled = true;
            this.comboBoxRatio.Items.AddRange(new object[] {
            "1/1",
            "2/1",
            "1/2",
            "3/1",
            "1/3",
            "Random"});
            this.comboBoxRatio.Location = new System.Drawing.Point(15, 372);
            this.comboBoxRatio.Name = "comboBoxRatio";
            this.comboBoxRatio.Size = new System.Drawing.Size(201, 21);
            this.comboBoxRatio.TabIndex = 15;
            this.comboBoxRatio.Text = "1/1";
            // 
            // labelDimensions
            // 
            this.labelDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Location = new System.Drawing.Point(13, 304);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(57, 13);
            this.labelDimensions.TabIndex = 16;
            this.labelDimensions.Text = "Image size";
            // 
            // numericUpDownPaperY
            // 
            this.numericUpDownPaperY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPaperY.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPaperY.Location = new System.Drawing.Point(126, 323);
            this.numericUpDownPaperY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownPaperY.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownPaperY.Name = "numericUpDownPaperY";
            this.numericUpDownPaperY.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownPaperY.TabIndex = 18;
            this.numericUpDownPaperY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPaperY.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownPaperX
            // 
            this.numericUpDownPaperX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPaperX.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPaperX.Location = new System.Drawing.Point(16, 323);
            this.numericUpDownPaperX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownPaperX.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownPaperX.Name = "numericUpDownPaperX";
            this.numericUpDownPaperX.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownPaperX.TabIndex = 17;
            this.numericUpDownPaperX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPaperX.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(16, 108);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(42, 23);
            this.buttonErase.TabIndex = 20;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // numericUpDownAllPoint
            // 
            this.numericUpDownAllPoint.Location = new System.Drawing.Point(130, 44);
            this.numericUpDownAllPoint.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAllPoint.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownAllPoint.Name = "numericUpDownAllPoint";
            this.numericUpDownAllPoint.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownAllPoint.TabIndex = 21;
            this.numericUpDownAllPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAllPoint.ThousandsSeparator = true;
            this.numericUpDownAllPoint.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // labelAllPoint
            // 
            this.labelAllPoint.AutoSize = true;
            this.labelAllPoint.Location = new System.Drawing.Point(12, 48);
            this.labelAllPoint.Name = "labelAllPoint";
            this.labelAllPoint.Size = new System.Drawing.Size(112, 13);
            this.labelAllPoint.TabIndex = 22;
            this.labelAllPoint.Text = "Total number of points";
            // 
            // FormFractal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.labelAllPoint);
            this.Controls.Add(this.numericUpDownAllPoint);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPaperY);
            this.Controls.Add(this.numericUpDownPaperX);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.comboBoxRatio);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.numericUpDownCountPoint);
            this.Controls.Add(this.dataGridViewPoints);
            this.Controls.Add(this.numericUpDownPointY);
            this.Controls.Add(this.numericUpDownPointX);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.pictureBoxViewing);
            this.Name = "FormFractal";
            this.Text = "Fractal geometry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaperY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaperX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAllPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxViewing;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownPointX;
        private System.Windows.Forms.NumericUpDown numericUpDownPointY;
        private System.Windows.Forms.DataGridView dataGridViewPoints;
        private System.Windows.Forms.NumericUpDown numericUpDownCountPoint;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.ComboBox comboBoxRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label labelDimensions;
        private System.Windows.Forms.NumericUpDown numericUpDownPaperY;
        private System.Windows.Forms.NumericUpDown numericUpDownPaperX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.NumericUpDown numericUpDownAllPoint;
        private System.Windows.Forms.Label labelAllPoint;
    }
}

