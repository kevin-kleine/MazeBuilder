﻿namespace MazeBuilder
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
         this.drawButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // drawButton
         // 
         this.drawButton.Location = new System.Drawing.Point(1110, 875);
         this.drawButton.Name = "drawButton";
         this.drawButton.Size = new System.Drawing.Size(75, 23);
         this.drawButton.TabIndex = 0;
         this.drawButton.Text = "Draw";
         this.drawButton.UseVisualStyleBackColor = true;
         this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1186, 899);
         this.Controls.Add(this.drawButton);
         this.Name = "MainWindow";
         this.Text = "MainWindow";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button drawButton;
   }
}

