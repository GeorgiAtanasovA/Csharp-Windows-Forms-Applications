using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Shut_Down_PC
{
   public partial class Shut_Down_PC : Form
   {
      public Shut_Down_PC() { InitializeComponent(); }

      int abortBtnCount = 0;
      int secondsLeft = 0;
      int minutesLeft = 60;
      int min = 0;
      string time;

      private void shutdown_Click(object sender, EventArgs e)//Стартиране на изключването с командата "shutdown"
      {
         if (timerSleep_ShutDown.Enabled == true) { return; }

         SetShutDown_Sleep_Method();

         int shutDownTime = Convert.ToInt32(time); shutDownTime = shutDownTime * 60;

         string startSD = "/s /t " + shutDownTime;

         if (time != null)
         {
            Process.Start("shutdown", startSD);
            Thread.Sleep(1);
            timerSleep_ShutDown.Enabled = true;
         }
         if (timerSleep_ShutDown.Enabled == true) { abortBtnCount = 0; }
      }
      private void sleep_Click(object sender, EventArgs e)//Стартиране на заспиването
      {
         if (timerSleep_ShutDown.Enabled == true) { return; }
         SetShutDown_Sleep_Method();
         if (timerSleep_ShutDown.Enabled == true) { abortBtnCount = 0; ControlBox = false; }
         if (time != null)
         {
            timerSleep_ShutDown.Enabled = true;
         }
      }
      private void shutdownAbort_Click(object sender, EventArgs e)//Спиране на изключването
      {
         time = null;
         abortBtnCount++;
         minutesLeft = 60;
         labelSec.Text = "...";
         labelAbortInfo.Visible = false;
         if (timerSleep_ShutDown.Enabled == true) { Process.Start("shutdown", " /a"); }
         timerSleep_ShutDown.Enabled = false;
         textBox_MinutesInput.Text = "90 min";
         ControlBox = true;
         if (timerSleep_ShutDown.Enabled == true) { abortBtnCount = 0; }
         if (abortBtnCount == 2) { Dispose(); }
      }
      private void Form1_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog.ShowDialog();
         WhiteBlackFormColour_Method(result);
      }
      private void textBoxMinutes_MouseClick(object sender, MouseEventArgs e)
      {
         if (timerSleep_ShutDown.Enabled == true) { return; }
         textBox_MinutesInput.Text = "";
      }
      private void WhiteBlackFormColour_Method(DialogResult result)
      {
         if (result == DialogResult.Cancel) { return; }

         BackColor = colorDialog.Color;
         labelSec.BackColor = colorDialog.Color;
         labelAbortInfo.BackColor = colorDialog.Color;
         labelSecText.BackColor = colorDialog.Color;
         label4.BackColor = colorDialog.Color;
         labelColor.BackColor = colorDialog.Color;

         if (BackColor.Name == "Black")
         {
            labelSec.ForeColor = Color.White;
            labelAbortInfo.ForeColor = Color.White;
            labelSecText.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            labelColor.ForeColor = Color.White;
            textBox_MinutesInput.ForeColor = Color.Black;
         }
         if (BackColor.Name == "White")
         {
            labelSec.ForeColor = Color.Black;
            labelAbortInfo.ForeColor = Color.Black;
            labelSecText.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            labelColor.ForeColor = Color.Black;
            textBox_MinutesInput.ForeColor = Color.Black;
         }
      }
      private void labelColor_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog.ShowDialog();
         WhiteBlackFormColour_Method(result);
      }
      private void timerSleep_ShowMinutes_Tick(object sender, EventArgs e)
      {
         secondsLeft--;
         labelSec.Text = Convert.ToString(secondsLeft);

         if (minutesLeft > 59 /*seconds*/)
         {
            textBox_MinutesInput.Text = Convert.ToString(secondsLeft / 60) + " min";
            minutesLeft = 0;
         }
         if (secondsLeft <= 0)
         {
            timerSleep_ShutDown.Stop();
            Application.SetSuspendState(PowerState.Suspend, false, false);
         }
         minutesLeft++;
      }
      private void SetShutDown_Sleep_Method()
      {
         if (timerSleep_ShutDown.Enabled == true) { return; }
         if (textBox_MinutesInput.Text.Contains("min")) { min = Convert.ToInt32(textBox_MinutesInput.Text.Remove(3)); }
         else
         {
            try { min = Convert.ToInt32(textBox_MinutesInput.Text); }
            catch (OverflowException) { MessageBox.Show("Too long time!"); return; }
            catch (FormatException) { MessageBox.Show("Too wrong number!"); return; }

            if (min == 0) { MessageBox.Show("Too short time!"); return; }
            if (int.MaxValue < Convert.ToInt32(textBox_MinutesInput.Text)) { MessageBox.Show("Too long time!"); return; }
            if (min > 604800) { MessageBox.Show("Too long time!"); return; }
         }
         secondsLeft = min * 60;
         time = Convert.ToString(min);
         labelAbortInfo.Visible = true;
         labelSecText.Visible = true;
      }
      private void textBox_MinutesInput_KeyUp(object sender, KeyEventArgs e)
      {
         if (timerSleep_ShutDown.Enabled == true)
         {
            textBox_MinutesInput.Text = "";
            textBox_MinutesInput.Text = Convert.ToString(secondsLeft / 60);
         }
      }
   }
}