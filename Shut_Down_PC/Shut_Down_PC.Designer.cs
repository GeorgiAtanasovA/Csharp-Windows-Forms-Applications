namespace Shut_Down_PC
{
   partial class Shut_Down_PC
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shut_Down_PC));
         this.btnShutdown = new System.Windows.Forms.Button();
         this.textBox_MinutesInput = new System.Windows.Forms.TextBox();
         this.labelSec = new System.Windows.Forms.Label();
         this.btnAbort = new System.Windows.Forms.Button();
         this.timerSleep_ShutDown = new System.Windows.Forms.Timer(this.components);
         this.labelAbortInfo = new System.Windows.Forms.Label();
         this.labelSecText = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.labelColor = new System.Windows.Forms.Label();
         this.btnSleep = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnShutdown
         // 
         this.btnShutdown.BackColor = System.Drawing.Color.Sienna;
         this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnShutdown.FlatAppearance.BorderSize = 2;
         this.btnShutdown.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
         this.btnShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
         this.btnShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
         this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnShutdown.Font = new System.Drawing.Font("Cooper Black", 10F);
         this.btnShutdown.Location = new System.Drawing.Point(151, 12);
         this.btnShutdown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnShutdown.Name = "btnShutdown";
         this.btnShutdown.Size = new System.Drawing.Size(110, 29);
         this.btnShutdown.TabIndex = 0;
         this.btnShutdown.Text = "Shutdown";
         this.btnShutdown.UseVisualStyleBackColor = false;
         this.btnShutdown.Click += new System.EventHandler(this.shutdown_Click);
         // 
         // textBox_MinutesInput
         // 
         this.textBox_MinutesInput.BackColor = System.Drawing.Color.Gainsboro;
         this.textBox_MinutesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox_MinutesInput.Font = new System.Drawing.Font("Cooper Black", 14F);
         this.textBox_MinutesInput.Location = new System.Drawing.Point(18, 13);
         this.textBox_MinutesInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.textBox_MinutesInput.Multiline = true;
         this.textBox_MinutesInput.Name = "textBox_MinutesInput";
         this.textBox_MinutesInput.Size = new System.Drawing.Size(110, 27);
         this.textBox_MinutesInput.TabIndex = 1;
         this.textBox_MinutesInput.Text = "90 min";
         this.textBox_MinutesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.textBox_MinutesInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMinutes_MouseClick);
         this.textBox_MinutesInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_MinutesInput_KeyUp);
         // 
         // labelSec
         // 
         this.labelSec.AutoSize = true;
         this.labelSec.BackColor = System.Drawing.Color.SaddleBrown;
         this.labelSec.Location = new System.Drawing.Point(53, 69);
         this.labelSec.Name = "labelSec";
         this.labelSec.Size = new System.Drawing.Size(21, 19);
         this.labelSec.TabIndex = 2;
         this.labelSec.Text = "...";
         // 
         // btnAbort
         // 
         this.btnAbort.BackColor = System.Drawing.Color.Sienna;
         this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnAbort.FlatAppearance.BorderSize = 2;
         this.btnAbort.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
         this.btnAbort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
         this.btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
         this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAbort.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Bold);
         this.btnAbort.Location = new System.Drawing.Point(151, 80);
         this.btnAbort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnAbort.Name = "btnAbort";
         this.btnAbort.Size = new System.Drawing.Size(110, 29);
         this.btnAbort.TabIndex = 3;
         this.btnAbort.Text = "Abort";
         this.btnAbort.UseVisualStyleBackColor = false;
         this.btnAbort.Click += new System.EventHandler(this.shutdownAbort_Click);
         // 
         // timerSleep_ShutDown
         // 
         this.timerSleep_ShutDown.Interval = 1000;
         this.timerSleep_ShutDown.Tick += new System.EventHandler(this.timerSleep_ShowMinutes_Tick);
         // 
         // labelAbortInfo
         // 
         this.labelAbortInfo.AutoSize = true;
         this.labelAbortInfo.BackColor = System.Drawing.Color.SaddleBrown;
         this.labelAbortInfo.Font = new System.Drawing.Font("Arial", 8F);
         this.labelAbortInfo.Location = new System.Drawing.Point(9, 113);
         this.labelAbortInfo.Name = "labelAbortInfo";
         this.labelAbortInfo.Size = new System.Drawing.Size(197, 16);
         this.labelAbortInfo.TabIndex = 4;
         this.labelAbortInfo.Text = "Press \'Abort\' to stop the process";
         this.labelAbortInfo.Visible = false;
         // 
         // labelSecText
         // 
         this.labelSecText.AutoSize = true;
         this.labelSecText.BackColor = System.Drawing.Color.SaddleBrown;
         this.labelSecText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.labelSecText.Location = new System.Drawing.Point(16, 69);
         this.labelSecText.Name = "labelSecText";
         this.labelSecText.Size = new System.Drawing.Size(36, 19);
         this.labelSecText.TabIndex = 2;
         this.labelSecText.Text = "sec";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.SaddleBrown;
         this.label4.Font = new System.Drawing.Font("Arial", 8F);
         this.label4.Location = new System.Drawing.Point(9, 130);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(160, 16);
         this.label4.TabIndex = 4;
         this.label4.Text = "Double click \'Abort\' to Exit";
         // 
         // labelColor
         // 
         this.labelColor.AutoSize = true;
         this.labelColor.BackColor = System.Drawing.Color.SaddleBrown;
         this.labelColor.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
         this.labelColor.Location = new System.Drawing.Point(247, 133);
         this.labelColor.Margin = new System.Windows.Forms.Padding(0);
         this.labelColor.Name = "labelColor";
         this.labelColor.Size = new System.Drawing.Size(31, 12);
         this.labelColor.TabIndex = 4;
         this.labelColor.Text = "Color";
         this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.labelColor.DoubleClick += new System.EventHandler(this.labelColor_DoubleClick);
         // 
         // btnSleep
         // 
         this.btnSleep.BackColor = System.Drawing.Color.Sienna;
         this.btnSleep.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnSleep.FlatAppearance.BorderSize = 2;
         this.btnSleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
         this.btnSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
         this.btnSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
         this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSleep.Font = new System.Drawing.Font("Cooper Black", 10F);
         this.btnSleep.Location = new System.Drawing.Point(151, 46);
         this.btnSleep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnSleep.Name = "btnSleep";
         this.btnSleep.Size = new System.Drawing.Size(110, 29);
         this.btnSleep.TabIndex = 5;
         this.btnSleep.Text = "Sleep";
         this.btnSleep.UseVisualStyleBackColor = false;
         this.btnSleep.Click += new System.EventHandler(this.sleep_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.SaddleBrown;
         this.CancelButton = this.btnAbort;
         this.ClientSize = new System.Drawing.Size(282, 151);
         this.Controls.Add(this.btnSleep);
         this.Controls.Add(this.labelColor);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.labelAbortInfo);
         this.Controls.Add(this.btnAbort);
         this.Controls.Add(this.labelSecText);
         this.Controls.Add(this.labelSec);
         this.Controls.Add(this.textBox_MinutesInput);
         this.Controls.Add(this.btnShutdown);
         this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.MaximizeBox = false;
         this.MinimumSize = new System.Drawing.Size(280, 160);
         this.Name = "Form1";
         this.Opacity = 0.9D;
         this.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.Text = "Shut Down";
         this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnShutdown;
      private System.Windows.Forms.TextBox textBox_MinutesInput;
      private System.Windows.Forms.Label labelSec;
      private System.Windows.Forms.Button btnAbort;
      private System.Windows.Forms.Timer timerSleep_ShutDown;
      private System.Windows.Forms.Label labelAbortInfo;
      private System.Windows.Forms.Label labelSecText;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ColorDialog colorDialog;
      private System.Windows.Forms.Label labelColor;
      private System.Windows.Forms.Button btnSleep;
   }
}

