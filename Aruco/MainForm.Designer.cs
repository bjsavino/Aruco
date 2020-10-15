namespace Aruco
{
   partial class MainForm
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
            this.printArucoBoardButton = new System.Windows.Forms.Button();
            this.cameraButton = new System.Windows.Forms.Button();
            this.useThisFrameButton = new System.Windows.Forms.Button();
            this.cameraImageBox = new Emgu.CV.UI.ImageBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // printArucoBoardButton
            // 
            this.printArucoBoardButton.Location = new System.Drawing.Point(10, 10);
            this.printArucoBoardButton.Margin = new System.Windows.Forms.Padding(2);
            this.printArucoBoardButton.Name = "printArucoBoardButton";
            this.printArucoBoardButton.Size = new System.Drawing.Size(128, 32);
            this.printArucoBoardButton.TabIndex = 0;
            this.printArucoBoardButton.Text = "Print Aruco Board";
            this.printArucoBoardButton.UseVisualStyleBackColor = true;
            this.printArucoBoardButton.Click += new System.EventHandler(this.printArucoBoardButton_Click);
            // 
            // cameraButton
            // 
            this.cameraButton.Location = new System.Drawing.Point(180, 10);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(2);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(238, 32);
            this.cameraButton.TabIndex = 1;
            this.cameraButton.Text = "Open Camera";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // useThisFrameButton
            // 
            this.useThisFrameButton.Enabled = false;
            this.useThisFrameButton.Location = new System.Drawing.Point(444, 10);
            this.useThisFrameButton.Margin = new System.Windows.Forms.Padding(2);
            this.useThisFrameButton.Name = "useThisFrameButton";
            this.useThisFrameButton.Size = new System.Drawing.Size(205, 32);
            this.useThisFrameButton.TabIndex = 3;
            this.useThisFrameButton.Text = "Use this frame";
            this.useThisFrameButton.UseVisualStyleBackColor = true;
            this.useThisFrameButton.Click += new System.EventHandler(this.useThisFrameButton_Click);
            // 
            // cameraImageBox
            // 
            this.cameraImageBox.Location = new System.Drawing.Point(10, 85);
            this.cameraImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.cameraImageBox.Name = "cameraImageBox";
            this.cameraImageBox.Size = new System.Drawing.Size(847, 578);
            this.cameraImageBox.TabIndex = 2;
            this.cameraImageBox.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(10, 53);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(38, 15);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(899, 100);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(75, 23);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(899, 129);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(75, 23);
            this.textBoxY.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Enabled = false;
            this.textBoxZ.Location = new System.Drawing.Point(899, 158);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(75, 23);
            this.textBoxZ.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxW
            // 
            this.textBoxW.Enabled = false;
            this.textBoxW.Location = new System.Drawing.Point(899, 274);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(75, 23);
            this.textBoxW.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "W";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxU
            // 
            this.textBoxU.Enabled = false;
            this.textBoxU.Location = new System.Drawing.Point(899, 216);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(75, 23);
            this.textBoxU.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(879, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "U";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Enabled = false;
            this.textBoxV.Location = new System.Drawing.Point(899, 245);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(75, 23);
            this.textBoxV.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(879, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "V";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.useThisFrameButton);
            this.Controls.Add(this.cameraImageBox);
            this.Controls.Add(this.cameraButton);
            this.Controls.Add(this.printArucoBoardButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Aruco demo";
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button printArucoBoardButton;
      private System.Windows.Forms.Button cameraButton;
      private Emgu.CV.UI.ImageBox cameraImageBox;
      private System.Windows.Forms.Button useThisFrameButton;
      private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label7;
    }
}

