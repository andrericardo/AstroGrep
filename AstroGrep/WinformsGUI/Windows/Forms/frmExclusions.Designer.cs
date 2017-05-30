namespace AstroGrep.Windows.Forms
{
   partial class frmExclusions
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
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lstExclusions = new System.Windows.Forms.ListView();
         this.chdEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chdCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chdType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chdValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chdOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnEdit = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnRestoreDefaults = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnOK.Location = new System.Drawing.Point(473, 399);
         this.btnOK.Margin = new System.Windows.Forms.Padding(4);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(100, 25);
         this.btnOK.TabIndex = 0;
         this.btnOK.Text = "&OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnCancel.Location = new System.Drawing.Point(581, 399);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(100, 25);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // lstExclusions
         // 
         this.lstExclusions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lstExclusions.CheckBoxes = true;
         this.lstExclusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdEnabled,
            this.chdCategory,
            this.chdType,
            this.chdValue,
            this.chdOption});
         this.lstExclusions.FullRowSelect = true;
         this.lstExclusions.HideSelection = false;
         this.lstExclusions.Location = new System.Drawing.Point(13, 15);
         this.lstExclusions.Margin = new System.Windows.Forms.Padding(4);
         this.lstExclusions.Name = "lstExclusions";
         this.lstExclusions.Size = new System.Drawing.Size(668, 345);
         this.lstExclusions.TabIndex = 2;
         this.lstExclusions.UseCompatibleStateImageBehavior = false;
         this.lstExclusions.View = System.Windows.Forms.View.Details;
         this.lstExclusions.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstExclusions_ColumnClick);
         this.lstExclusions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstExclusions_ItemCheck);
         this.lstExclusions.SelectedIndexChanged += new System.EventHandler(this.lstExclusions_SelectedIndexChanged);
         this.lstExclusions.DoubleClick += new System.EventHandler(this.lstExclusions_DoubleClick);
         this.lstExclusions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstExclusions_KeyDown);
         this.lstExclusions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstExclusions_MouseDown);
         this.lstExclusions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstExclusions_MouseUp);
         // 
         // chdEnabled
         // 
         this.chdEnabled.Text = "Enabled";
         this.chdEnabled.Width = 75;
         // 
         // chdCategory
         // 
         this.chdCategory.Text = "Category";
         this.chdCategory.Width = 120;
         // 
         // chdType
         // 
         this.chdType.Text = "Type";
         this.chdType.Width = 120;
         // 
         // chdValue
         // 
         this.chdValue.Text = "Value";
         this.chdValue.Width = 160;
         // 
         // chdOption
         // 
         this.chdOption.Text = "Option";
         this.chdOption.Width = 100;
         // 
         // btnAdd
         // 
         this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnAdd.Location = new System.Drawing.Point(13, 368);
         this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(100, 25);
         this.btnAdd.TabIndex = 3;
         this.btnAdd.Text = "&Add...";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnEdit
         // 
         this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnEdit.Location = new System.Drawing.Point(119, 368);
         this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.Size = new System.Drawing.Size(100, 25);
         this.btnEdit.TabIndex = 4;
         this.btnEdit.Text = "&Edit...";
         this.btnEdit.UseVisualStyleBackColor = true;
         this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnDelete.Location = new System.Drawing.Point(225, 368);
         this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(100, 25);
         this.btnDelete.TabIndex = 5;
         this.btnDelete.Text = "&Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnRestoreDefaults
         // 
         this.btnRestoreDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnRestoreDefaults.AutoSize = true;
         this.btnRestoreDefaults.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnRestoreDefaults.Location = new System.Drawing.Point(331, 368);
         this.btnRestoreDefaults.Margin = new System.Windows.Forms.Padding(4);
         this.btnRestoreDefaults.MaximumSize = new System.Drawing.Size(285, 25);
         this.btnRestoreDefaults.MinimumSize = new System.Drawing.Size(125, 25);
         this.btnRestoreDefaults.Name = "btnRestoreDefaults";
         this.btnRestoreDefaults.Size = new System.Drawing.Size(125, 25);
         this.btnRestoreDefaults.TabIndex = 6;
         this.btnRestoreDefaults.Text = "&Restore Defaults";
         this.btnRestoreDefaults.UseVisualStyleBackColor = true;
         this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
         // 
         // frmExclusions
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(694, 437);
         this.Controls.Add(this.btnRestoreDefaults);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnEdit);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.lstExclusions);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(710, 455);
         this.Name = "frmExclusions";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Exclusions";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExclusionsDisplay_FormClosing);
         this.Load += new System.EventHandler(this.frmExclusions_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.ListView lstExclusions;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnEdit;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.ColumnHeader chdType;
      private System.Windows.Forms.ColumnHeader chdValue;
      private System.Windows.Forms.ColumnHeader chdOption;
      private System.Windows.Forms.Button btnRestoreDefaults;
      private System.Windows.Forms.ColumnHeader chdEnabled;
      private System.Windows.Forms.ColumnHeader chdCategory;
   }
}