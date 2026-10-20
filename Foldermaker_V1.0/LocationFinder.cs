using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foldermaker_V1._0
{
    public partial class LocationFinder : MaterialSkin.Controls.MaterialForm
    {
        public string folderPath = null;
        public int folderAmount = 0;

        FolderBrowserDialog folder;
        public LocationFinder()
        {
            InitializeComponent();
            folder = new FolderBrowserDialog();

            Utils.ApplyMaterialSkin(this);
  
        }
        public static void LocationFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Function to close the application when the user clicks the close button,
            //with a confirmation dialog

            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
               "Confirm Exit", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;// prevent the form from closing
            }
            else
            {

            }
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            try
            {
                folderAmount = (int)NUD_FolderAmount.Value;

                // Check if the folder path is null or empty then prevent the user from proceeding to the next form
                if (string.IsNullOrEmpty(folderPath))
                {
                    MessageBox.Show("Please select a folder location first.");
                    return;
                }

                var foldernaming = new FolderNaming(folderAmount, folderPath);
                foldernaming.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occurred while creating the folders.");
            }
        }

        private void BTN_FindLocation_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the folder browser dialog and get the selected folder path
                DialogResult result = folder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderPath = folder.SelectedPath;
                    TB_destination.Text = folderPath;
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void LocationFinder_Load(object sender, EventArgs e)
        {
            NUD_FolderAmount.Minimum = 1;
            NUD_FolderAmount.Value = 1;
        }
    }
}
