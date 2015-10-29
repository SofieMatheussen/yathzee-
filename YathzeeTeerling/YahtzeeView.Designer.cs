namespace YathzeeTeerling
{
  partial class YahtzeeView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.smijtAlleTeerlingen = new System.Windows.Forms.Button();
            this.startOpnieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smijtAlleTeerlingen
            // 
            this.smijtAlleTeerlingen.Location = new System.Drawing.Point(25, 204);
            this.smijtAlleTeerlingen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smijtAlleTeerlingen.Name = "smijtAlleTeerlingen";
            this.smijtAlleTeerlingen.Size = new System.Drawing.Size(107, 28);
            this.smijtAlleTeerlingen.TabIndex = 0;
            this.smijtAlleTeerlingen.Text = "Smijt allemaal";
            this.smijtAlleTeerlingen.UseVisualStyleBackColor = true;
            this.smijtAlleTeerlingen.Click += new System.EventHandler(this.gooiAlleTeerlingen_Click);
            // 
            // startOpnieuw
            // 
            this.startOpnieuw.Location = new System.Drawing.Point(140, 204);
            this.startOpnieuw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startOpnieuw.Name = "startOpnieuw";
            this.startOpnieuw.Size = new System.Drawing.Size(123, 28);
            this.startOpnieuw.TabIndex = 1;
            this.startOpnieuw.Text = "opnieuw";
            this.startOpnieuw.UseVisualStyleBackColor = true;
            this.startOpnieuw.Click += new System.EventHandler(this.startOpnieuw_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.startOpnieuw);
            this.Controls.Add(this.smijtAlleTeerlingen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(313, 245);
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button smijtAlleTeerlingen;
    private System.Windows.Forms.Button startOpnieuw;
  }
}
