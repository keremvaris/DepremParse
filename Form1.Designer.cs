namespace DepremParse
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
        this.dg = new System.Windows.Forms.DataGridView();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbParse = new System.Windows.Forms.ToolStripButton();
        this.tbFilter = new System.Windows.Forms.ToolStripTextBox();
        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        this.tbsonuc = new System.Windows.Forms.ToolStripLabel();
        this.toolStripContainer1.ContentPanel.SuspendLayout();
        this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
        this.toolStripContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
        this.toolStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // toolStripContainer1
        // 
        // 
        // toolStripContainer1.ContentPanel
        // 
        this.toolStripContainer1.ContentPanel.Controls.Add(this.dg);
        this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(444, 367);
        this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
        this.toolStripContainer1.Name = "toolStripContainer1";
        this.toolStripContainer1.Size = new System.Drawing.Size(444, 392);
        this.toolStripContainer1.TabIndex = 0;
        this.toolStripContainer1.Text = "toolStripContainer1";
        // 
        // toolStripContainer1.TopToolStripPanel
        // 
        this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
        // 
        // dg
        // 
        this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dg.Location = new System.Drawing.Point(0, 0);
        this.dg.Name = "dg";
        this.dg.Size = new System.Drawing.Size(444, 367);
        this.dg.TabIndex = 0;
        // 
        // toolStrip1
        // 
        this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
        this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbParse,
            this.tbFilter,
            this.toolStripButton1,
            this.tbsonuc});
        this.toolStrip1.Location = new System.Drawing.Point(3, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(232, 25);
        this.toolStrip1.TabIndex = 0;
        // 
        // tsbParse
        // 
        this.tsbParse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.tsbParse.Image = ((System.Drawing.Image)(resources.GetObject("tsbParse.Image")));
        this.tsbParse.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbParse.Name = "tsbParse";
        this.tsbParse.Size = new System.Drawing.Size(68, 22);
        this.tsbParse.Text = "Yükle ve Böl";
        this.tsbParse.Click += new System.EventHandler(this.tsbParse_Click);
        // 
        // tbFilter
        // 
        this.tbFilter.Name = "tbFilter";
        this.tbFilter.Size = new System.Drawing.Size(100, 25);
        // 
        // toolStripButton1
        // 
        this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
        this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButton1.Name = "toolStripButton1";
        this.toolStripButton1.Size = new System.Drawing.Size(28, 22);
        this.toolStripButton1.Text = "Ara";
        this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
        // 
        // tbsonuc
        // 
        this.tbsonuc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.tbsonuc.Name = "tbsonuc";
        this.tbsonuc.Size = new System.Drawing.Size(0, 22);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(444, 392);
        this.Controls.Add(this.toolStripContainer1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.toolStripContainer1.ContentPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.PerformLayout();
        this.toolStripContainer1.ResumeLayout(false);
        this.toolStripContainer1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbParse;
    private System.Windows.Forms.DataGridView dg;
    private System.Windows.Forms.ToolStripLabel tbsonuc;
    private System.Windows.Forms.ToolStripTextBox tbFilter;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
  }
}

