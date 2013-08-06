namespace MazeBuilder
{
   partial class MainWindow
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
         this.drawButton = new System.Windows.Forms.Button();
         this.analyzeButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.mazeWidthNumeric = new System.Windows.Forms.NumericUpDown();
         this.mazeHeightNumeric = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.cellSizeNumeric = new System.Windows.Forms.NumericUpDown();
         this.incrementByNumeric = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.endSizeNumeric = new System.Windows.Forms.NumericUpDown();
         this.startSizeNumeric = new System.Windows.Forms.NumericUpDown();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.printButton = new System.Windows.Forms.Button();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         ((System.ComponentModel.ISupportInitialize)(this.mazeWidthNumeric)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mazeHeightNumeric)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumeric)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.incrementByNumeric)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.endSizeNumeric)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.startSizeNumeric)).BeginInit();
         this.SuspendLayout();
         // 
         // drawButton
         // 
         this.drawButton.Location = new System.Drawing.Point(138, 186);
         this.drawButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.drawButton.Name = "drawButton";
         this.drawButton.Size = new System.Drawing.Size(112, 35);
         this.drawButton.TabIndex = 0;
         this.drawButton.Text = "Draw";
         this.drawButton.UseVisualStyleBackColor = true;
         this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
         // 
         // analyzeButton
         // 
         this.analyzeButton.Location = new System.Drawing.Point(18, 186);
         this.analyzeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.analyzeButton.Name = "analyzeButton";
         this.analyzeButton.Size = new System.Drawing.Size(112, 35);
         this.analyzeButton.TabIndex = 1;
         this.analyzeButton.Text = "Analyze";
         this.analyzeButton.UseVisualStyleBackColor = true;
         this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(134, 14);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Maze Width:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(134, 69);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(103, 20);
         this.label2.TabIndex = 3;
         this.label2.Text = "Maze Height:";
         // 
         // mazeWidthNumeric
         // 
         this.mazeWidthNumeric.Location = new System.Drawing.Point(138, 38);
         this.mazeWidthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.mazeWidthNumeric.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
         this.mazeWidthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.mazeWidthNumeric.Name = "mazeWidthNumeric";
         this.mazeWidthNumeric.Size = new System.Drawing.Size(112, 26);
         this.mazeWidthNumeric.TabIndex = 4;
         this.mazeWidthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.mazeWidthNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
         // 
         // mazeHeightNumeric
         // 
         this.mazeHeightNumeric.Location = new System.Drawing.Point(138, 94);
         this.mazeHeightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.mazeHeightNumeric.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
         this.mazeHeightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.mazeHeightNumeric.Name = "mazeHeightNumeric";
         this.mazeHeightNumeric.Size = new System.Drawing.Size(112, 26);
         this.mazeHeightNumeric.TabIndex = 5;
         this.mazeHeightNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.mazeHeightNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(134, 125);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(104, 20);
         this.label3.TabIndex = 6;
         this.label3.Text = "Cell Size (px):";
         // 
         // cellSizeNumeric
         // 
         this.cellSizeNumeric.Location = new System.Drawing.Point(138, 150);
         this.cellSizeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.cellSizeNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.cellSizeNumeric.Name = "cellSizeNumeric";
         this.cellSizeNumeric.Size = new System.Drawing.Size(112, 26);
         this.cellSizeNumeric.TabIndex = 7;
         this.cellSizeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.cellSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // incrementByNumeric
         // 
         this.incrementByNumeric.Location = new System.Drawing.Point(18, 150);
         this.incrementByNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.incrementByNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
         this.incrementByNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.incrementByNumeric.Name = "incrementByNumeric";
         this.incrementByNumeric.Size = new System.Drawing.Size(112, 26);
         this.incrementByNumeric.TabIndex = 13;
         this.incrementByNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.incrementByNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(14, 125);
         this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(107, 20);
         this.label4.TabIndex = 12;
         this.label4.Text = "Increment By:";
         // 
         // endSizeNumeric
         // 
         this.endSizeNumeric.Location = new System.Drawing.Point(18, 94);
         this.endSizeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.endSizeNumeric.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
         this.endSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.endSizeNumeric.Name = "endSizeNumeric";
         this.endSizeNumeric.Size = new System.Drawing.Size(112, 26);
         this.endSizeNumeric.TabIndex = 11;
         this.endSizeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.endSizeNumeric.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
         // 
         // startSizeNumeric
         // 
         this.startSizeNumeric.Location = new System.Drawing.Point(18, 38);
         this.startSizeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.startSizeNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
         this.startSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.startSizeNumeric.Name = "startSizeNumeric";
         this.startSizeNumeric.Size = new System.Drawing.Size(112, 26);
         this.startSizeNumeric.TabIndex = 10;
         this.startSizeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.startSizeNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(14, 69);
         this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(77, 20);
         this.label5.TabIndex = 9;
         this.label5.Text = "End Size:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(14, 14);
         this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(83, 20);
         this.label6.TabIndex = 8;
         this.label6.Text = "Start Size:";
         // 
         // printButton
         // 
         this.printButton.Location = new System.Drawing.Point(138, 231);
         this.printButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.printButton.Name = "printButton";
         this.printButton.Size = new System.Drawing.Size(112, 35);
         this.printButton.TabIndex = 14;
         this.printButton.Text = "Print";
         this.printButton.UseVisualStyleBackColor = true;
         this.printButton.Click += new System.EventHandler(this.printButton_Click);
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(18, 231);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(112, 32);
         this.progressBar1.TabIndex = 15;
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(268, 275);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.printButton);
         this.Controls.Add(this.incrementByNumeric);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.endSizeNumeric);
         this.Controls.Add(this.startSizeNumeric);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.cellSizeNumeric);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.mazeHeightNumeric);
         this.Controls.Add(this.mazeWidthNumeric);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.analyzeButton);
         this.Controls.Add(this.drawButton);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "MainWindow";
         this.Text = "MainWindow";
         this.Load += new System.EventHandler(this.MainWindow_Load);
         ((System.ComponentModel.ISupportInitialize)(this.mazeWidthNumeric)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mazeHeightNumeric)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumeric)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.incrementByNumeric)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.endSizeNumeric)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.startSizeNumeric)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button drawButton;
      private System.Windows.Forms.Button analyzeButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown mazeWidthNumeric;
      private System.Windows.Forms.NumericUpDown mazeHeightNumeric;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown cellSizeNumeric;
      private System.Windows.Forms.NumericUpDown incrementByNumeric;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.NumericUpDown endSizeNumeric;
      private System.Windows.Forms.NumericUpDown startSizeNumeric;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button printButton;
      private System.Windows.Forms.ProgressBar progressBar1;
   }
}

