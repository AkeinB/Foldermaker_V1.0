namespace Foldermaker_V1._0
{
    partial class FolderNaming
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
            this.FLP_TextBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_CreateFolders = new MaterialSkin.Controls.MaterialButton();
            this.BTN_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // FLP_TextBoxContainer
            // 
            this.FLP_TextBoxContainer.AutoScroll = true;
            this.FLP_TextBoxContainer.Location = new System.Drawing.Point(6, 140);
            this.FLP_TextBoxContainer.Name = "FLP_TextBoxContainer";
            this.FLP_TextBoxContainer.Size = new System.Drawing.Size(567, 424);
            this.FLP_TextBoxContainer.TabIndex = 0;
            // 
            // BTN_CreateFolders
            // 
            this.BTN_CreateFolders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_CreateFolders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_CreateFolders.Depth = 0;
            this.BTN_CreateFolders.HighEmphasis = true;
            this.BTN_CreateFolders.Icon = null;
            this.BTN_CreateFolders.Location = new System.Drawing.Point(390, 586);
            this.BTN_CreateFolders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_CreateFolders.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_CreateFolders.Name = "BTN_CreateFolders";
            this.BTN_CreateFolders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_CreateFolders.Size = new System.Drawing.Size(142, 36);
            this.BTN_CreateFolders.TabIndex = 1;
            this.BTN_CreateFolders.Text = "Create Folders";
            this.BTN_CreateFolders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_CreateFolders.UseAccentColor = false;
            this.BTN_CreateFolders.UseVisualStyleBackColor = true;
            this.BTN_CreateFolders.Click += new System.EventHandler(this.BTN_CreateFolders_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Cancel.Depth = 0;
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.HighEmphasis = true;
            this.BTN_Cancel.Icon = null;
            this.BTN_Cancel.Location = new System.Drawing.Point(214, 586);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Cancel.Size = new System.Drawing.Size(77, 36);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Cancel.UseAccentColor = false;
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Set Folder Names";
            // 
            // FolderNaming
            // 
            this.AcceptButton = this.BTN_CreateFolders;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(585, 653);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_CreateFolders);
            this.Controls.Add(this.FLP_TextBoxContainer);
            this.Name = "FolderNaming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderNaming";
            this.Load += new System.EventHandler(this.FolderNaming_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_TextBoxContainer;
        private MaterialSkin.Controls.MaterialButton BTN_CreateFolders;
        private MaterialSkin.Controls.MaterialButton BTN_Cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}