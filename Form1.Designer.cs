namespace WPF_HomeWork_13_14
{
  partial class Form1
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
      this.btnGoBack = new System.Windows.Forms.Button();
      this.btnGoForward = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.btnOpen = new System.Windows.Forms.Button();
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // btnGoBack
      // 
      this.btnGoBack.Location = new System.Drawing.Point(13, 15);
      this.btnGoBack.Name = "btnGoBack";
      this.btnGoBack.Size = new System.Drawing.Size(58, 24);
      this.btnGoBack.TabIndex = 0;
      this.btnGoBack.Text = "<<";
      this.btnGoBack.UseVisualStyleBackColor = true;
      this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
      // 
      // btnGoForward
      // 
      this.btnGoForward.Location = new System.Drawing.Point(77, 15);
      this.btnGoForward.Name = "btnGoForward";
      this.btnGoForward.Size = new System.Drawing.Size(56, 24);
      this.btnGoForward.TabIndex = 1;
      this.btnGoForward.Text = ">>";
      this.btnGoForward.UseVisualStyleBackColor = true;
      this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(149, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 22);
      this.label1.TabIndex = 2;
      this.label1.Text = "Path :";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(210, 17);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(638, 22);
      this.txtPath.TabIndex = 3;
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(854, 17);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 4;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // webBrowser
      // 
      this.webBrowser.Location = new System.Drawing.Point(13, 46);
      this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.Size = new System.Drawing.Size(916, 481);
      this.webBrowser.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(941, 539);
      this.Controls.Add(this.webBrowser);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGoForward);
      this.Controls.Add(this.btnGoBack);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGoBack;
    private System.Windows.Forms.Button btnGoForward;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.WebBrowser webBrowser;
  }
}

