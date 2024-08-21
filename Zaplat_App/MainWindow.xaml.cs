using System;
using System.Diagnostics;
using System.Windows;

namespace ZaplataCompute
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class ZaplataCompute : Window
   {
      public ZaplataCompute()
      {
         InitializeComponent();
         dateTime.Content = DateTime.Now;
         labelInfo.Content = labelInfo.Content + "\nHej, skriv din lön per timme, din timmar och din skatt.";
      }

      private void button_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            double lönPerTimme = double.Parse(lönPerTimmeTB.Text);
            double timmar = double.Parse(timmarTB.Text);
            double skatt = double.Parse(skattTB.Text);

            double sum = lönPerTimme / 100;
            sum = sum * skatt;
            sum = lönPerTimme - sum;
            sum = sum * timmar;

            labelInfo.Content = "";
            labelInfo.Content = "Info:";
            labelInfo.Content = labelInfo.Content + "\nHej, skriv din lön per timme, din timmar och din skatt.";

            resultL.HorizontalContentAlignment = HorizontalAlignment.Left;
            resultL.Content = "  Belopp att ta emot:";
            resultLDigit.Content = sum + " sek";
         }
         catch (Exception)
         {
            labelInfo.Content = "Ange siffror i alla fält!";
         }
      }

      private void calcB_Click(object sender, RoutedEventArgs e)
      {
         Process.Start("Calc");
      }

      private void button_Click_1(object sender, RoutedEventArgs e)
      {
         lönPerTimmeTB.Text = "";
         timmarTB.Text = "";
         skattTB.Text = "";
         resultL.HorizontalContentAlignment = HorizontalAlignment.Center;
         resultL.Content = "Result:";
         resultLDigit.Content = "";
      }
   }
}
