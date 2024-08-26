namespace Currency_Converter
{
  partial class Currency_Convert
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
      if(disposing && (components != null))
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency_Convert));
         this.open_converter = new System.Windows.Forms.Button();
         this.webBrowser = new System.Windows.Forms.WebBrowser();
         this.close = new System.Windows.Forms.Button();
         this.searchField = new System.Windows.Forms.TextBox();
         this.Search = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // open_converter
         // 
         this.open_converter.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.open_converter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.open_converter.BackColor = System.Drawing.Color.PaleGreen;
         this.open_converter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.open_converter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.open_converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.open_converter.Location = new System.Drawing.Point(32, 41);
         this.open_converter.Name = "open_converter";
         this.open_converter.Size = new System.Drawing.Size(158, 37);
         this.open_converter.TabIndex = 0;
         this.open_converter.Text = "Open Converter";
         this.open_converter.UseVisualStyleBackColor = false;
         this.open_converter.Click += new System.EventHandler(this.OpenConverter_Click);
         // 
         // webBrowser
         // 
         this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.webBrowser.Location = new System.Drawing.Point(1, 84);
         this.webBrowser.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
         this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
         this.webBrowser.Name = "webBrowser";
         this.webBrowser.Size = new System.Drawing.Size(485, 344);
         this.webBrowser.TabIndex = 1;
         // 
         // close
         // 
         this.close.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.close.BackColor = System.Drawing.Color.PaleGreen;
         this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.close.Location = new System.Drawing.Point(360, 41);
         this.close.Name = "close";
         this.close.Size = new System.Drawing.Size(90, 37);
         this.close.TabIndex = 0;
         this.close.Text = "Close";
         this.close.UseVisualStyleBackColor = false;
         this.close.Click += new System.EventHandler(this.Close_Click);
         // 
         // searchField
         // 
         this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.searchField.Location = new System.Drawing.Point(10, 7);
         this.searchField.MinimumSize = new System.Drawing.Size(4, 32);
         this.searchField.Name = "searchField";
         this.searchField.Size = new System.Drawing.Size(464, 32);
         this.searchField.TabIndex = 0;
         this.searchField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter);
         // 
         // Search
         // 
         this.Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Search.BackColor = System.Drawing.Color.PaleGreen;
         this.Search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.Search.Location = new System.Drawing.Point(196, 41);
         this.Search.Name = "Search";
         this.Search.Size = new System.Drawing.Size(158, 37);
         this.Search.TabIndex = 0;
         this.Search.Text = "Search";
         this.Search.UseVisualStyleBackColor = false;
         this.Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Search_MouseClick);
         // 
         // CurrencyConvert
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PaleGreen;
         this.ClientSize = new System.Drawing.Size(482, 426);
         this.Controls.Add(this.Search);
         this.Controls.Add(this.searchField);
         this.Controls.Add(this.close);
         this.Controls.Add(this.webBrowser);
         this.Controls.Add(this.open_converter);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "CurrencyConvert";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Currency Converter - Browser";
         this.TransparencyKey = System.Drawing.Color.Red;
         this.ResumeLayout(false);
         this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button open_converter;
    private System.Windows.Forms.WebBrowser webBrowser;
    private System.Windows.Forms.Button close;
    private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button Search;
    }
}

