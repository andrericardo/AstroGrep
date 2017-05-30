namespace AstroGrep.Windows.Forms
{
   partial class frmCheckForUpdateTemp
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
         this.lblVersionCheck = new System.Windows.Forms.Label();
         this.btnOK = new System.Windows.Forms.Button();
         this.lnkDownload = new System.Windows.Forms.LinkLabel();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // lblVersionCheck
         // 
         this.lblVersionCheck.AutoSize = true;
         this.lblVersionCheck.Location = new System.Drawing.Point(16, 11);
         this.lblVersionCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblVersionCheck.Name = "lblVersionCheck";
         this.lblVersionCheck.Size = new System.Drawing.Size(131, 15);
         this.lblVersionCheck.TabIndex = 2;
         this.lblVersionCheck.Text = "Checking for updates...";
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(505, 145);
         this.btnOK.Margin = new System.Windows.Forms.Padding(4);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(100, 28);
         this.btnOK.TabIndex = 3;
         this.btnOK.Text = "&OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // lnkDownload
         // 
         this.lnkDownload.AutoSize = true;
         this.lnkDownload.Location = new System.Drawing.Point(16, 58);
         this.lnkDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lnkDownload.Name = "lnkDownload";
         this.lnkDownload.Size = new System.Drawing.Size(99, 15);
         this.lnkDownload.TabIndex = 4;
         this.lnkDownload.TabStop = true;
         this.lnkDownload.Text = "Download Latest";
         this.toolTip1.SetToolTip(this.lnkDownload, "http://astrogrep.sourceforge.net/download/");
         this.lnkDownload.Visible = false;
         this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
         // 
         // frmCheckForUpdateTemp
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(434, 141);
         this.Controls.Add(this.lnkDownload);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.lblVersionCheck);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmCheckForUpdateTemp";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "frmCheckForUpdateTemp";
         this.Load += new System.EventHandler(this.frmCheckForUpdateTemp_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblVersionCheck;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.LinkLabel lnkDownload;
      private System.Windows.Forms.ToolTip toolTip1;
   }
}