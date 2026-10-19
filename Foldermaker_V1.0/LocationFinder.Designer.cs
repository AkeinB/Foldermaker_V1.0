namespace Foldermaker_V1._0
{
    partial class LocationFinder
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
            this.TB_destination = new MaterialSkin.Controls.MaterialTextBox2();
            this.LB_FolderLocation = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_Next = new MaterialSkin.Controls.MaterialButton();
            this.LB_FolderAmount = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_FindLocation = new MaterialSkin.Controls.MaterialButton();
            this.NUD_FolderAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FolderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_destination
            // 
            this.TB_destination.AnimateReadOnly = false;
            this.TB_destination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TB_destination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TB_destination.Depth = 0;
            this.TB_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_destination.HideSelection = true;
            this.TB_destination.LeadingIcon = null;
            this.TB_destination.Location = new System.Drawing.Point(155, 100);
            this.TB_destination.MaxLength = 32767;
            this.TB_destination.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_destination.Name = "TB_destination";
            this.TB_destination.Padding = new System.Windows.Forms.Padding(30);
            this.TB_destination.PasswordChar = '\0';
            this.TB_destination.PrefixSuffixText = null;
            this.TB_destination.ReadOnly = false;
            this.TB_destination.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_destination.SelectedText = "";
            this.TB_destination.SelectionLength = 0;
            this.TB_destination.SelectionStart = 0;
            this.TB_destination.ShortcutsEnabled = true;
            this.TB_destination.Size = new System.Drawing.Size(393, 48);
            this.TB_destination.TabIndex = 0;
            this.TB_destination.TabStop = false;
            this.TB_destination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TB_destination.TrailingIcon = null;
            this.TB_destination.UseSystemPasswordChar = false;
            // 
            // LB_FolderLocation
            // 
            this.LB_FolderLocation.AutoSize = true;
            this.LB_FolderLocation.Depth = 0;
            this.LB_FolderLocation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LB_FolderLocation.Location = new System.Drawing.Point(23, 119);
            this.LB_FolderLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LB_FolderLocation.Name = "LB_FolderLocation";
            this.LB_FolderLocation.Size = new System.Drawing.Size(111, 19);
            this.LB_FolderLocation.TabIndex = 1;
            this.LB_FolderLocation.Text = "Folder Location";
            // 
            // BTN_Next
            // 
            this.BTN_Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Next.Depth = 0;
            this.BTN_Next.HighEmphasis = true;
            this.BTN_Next.Icon = null;
            this.BTN_Next.Location = new System.Drawing.Point(484, 272);
            this.BTN_Next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Next.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Next.Size = new System.Drawing.Size(64, 36);
            this.BTN_Next.TabIndex = 2;
            this.BTN_Next.Text = "Next";
            this.BTN_Next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Next.UseAccentColor = false;
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // LB_FolderAmount
            // 
            this.LB_FolderAmount.AutoSize = true;
            this.LB_FolderAmount.Depth = 0;
            this.LB_FolderAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LB_FolderAmount.Location = new System.Drawing.Point(23, 205);
            this.LB_FolderAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.LB_FolderAmount.Name = "LB_FolderAmount";
            this.LB_FolderAmount.Size = new System.Drawing.Size(105, 19);
            this.LB_FolderAmount.TabIndex = 3;
            this.LB_FolderAmount.Text = "Folder Amount";
            // 
            // BTN_FindLocation
            // 
            this.BTN_FindLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_FindLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_FindLocation.Depth = 0;
            this.BTN_FindLocation.HighEmphasis = true;
            this.BTN_FindLocation.Icon = null;
            this.BTN_FindLocation.Location = new System.Drawing.Point(555, 109);
            this.BTN_FindLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_FindLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_FindLocation.Name = "BTN_FindLocation";
            this.BTN_FindLocation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_FindLocation.Size = new System.Drawing.Size(64, 36);
            this.BTN_FindLocation.TabIndex = 5;
            this.BTN_FindLocation.Text = "...";
            this.BTN_FindLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_FindLocation.UseAccentColor = false;
            this.BTN_FindLocation.UseVisualStyleBackColor = true;
            this.BTN_FindLocation.Click += new System.EventHandler(this.BTN_FindLocation_Click);
            // 
            // NUD_FolderAmount
            // 
            this.NUD_FolderAmount.Location = new System.Drawing.Point(155, 204);
            this.NUD_FolderAmount.Name = "NUD_FolderAmount";
            this.NUD_FolderAmount.Size = new System.Drawing.Size(56, 20);
            this.NUD_FolderAmount.TabIndex = 6;
            // 
            // LocationFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 317);
            this.Controls.Add(this.NUD_FolderAmount);
            this.Controls.Add(this.BTN_FindLocation);
            this.Controls.Add(this.LB_FolderAmount);
            this.Controls.Add(this.BTN_Next);
            this.Controls.Add(this.LB_FolderLocation);
            this.Controls.Add(this.TB_destination);
            this.Name = "LocationFinder";
            this.Sizable = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LocationFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FolderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TB_destination;
        private MaterialSkin.Controls.MaterialLabel LB_FolderLocation;
        private MaterialSkin.Controls.MaterialButton BTN_Next;
        private MaterialSkin.Controls.MaterialLabel LB_FolderAmount;
        private MaterialSkin.Controls.MaterialButton BTN_FindLocation;
        private System.Windows.Forms.NumericUpDown NUD_FolderAmount;
    }
}

