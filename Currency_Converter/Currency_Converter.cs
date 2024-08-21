using System;
using System.Windows.Forms;

namespace Currency_Converter
{
   static class Currency_Converter
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new CurrencyConvert());
    }
  }
}
