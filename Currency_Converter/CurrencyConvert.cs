using System;
using System.Threading;
using System.Windows.Forms;

namespace Currency_Converter
{
   public partial class CurrencyConvert : Form
   {
      public CurrencyConvert()
      {
         InitializeComponent();

         webBrowser.Navigate(Settings.Default.georgi);
         searchField.AppendText(Settings.Default.georgi);

      }
      private void OpenConverter_Click(object sender, EventArgs e)
      {
         ActiveForm.Width = 500;
         ActiveForm.Height = 470;
         webBrowser.Navigate(Settings.Default.georgi);
         webBrowser.Document.Encoding = "UTF-8";

         searchField.Clear();
         searchField.AppendText(Settings.Default.georgi);
      }
      private void Close_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Good Bay :)");
         Thread.Sleep(300);
         base.Dispose();
      }
      private void Search_MouseClick(object sender, MouseEventArgs e)
      {
         ActiveForm.Width = 1000;
         ActiveForm.Height = 700;
         searchField.Clear();
         searchField.AppendText("https://www.google.bg");
         webBrowser.Navigate("https://www.google.bg");
         webBrowser.Document.Encoding = "UTF-8";
      }
      private new void Enter(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            webBrowser.Navigate(searchField.Text);
         }
      }
   }
}
