using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foldermaker_V1._0
{
    
    public partial class FolderNaming : MaterialSkin.Controls.MaterialForm
    {
        private readonly int folderAmount;
        private readonly string folderPath;
        List<string> folderNamesCollection = new List<string>();

        public FolderNaming(int FolderAmount, string FolderPath)
        {
            InitializeComponent();
            Utils.ApplyMaterialSkin(this);
            folderAmount = FolderAmount;
            folderPath = FolderPath;
        }

        private void FolderNaming_Load(object sender, EventArgs e)
        {
            try
            {
                // Dynamically create TextBox based on the folderAmount
                for (int i = 1; i <= folderAmount; i++)
                {
                    TextBox txt = new TextBox();
                    FLP_TextBoxContainer.Controls.Add(txt);
                    txt.Name = "txtFolderName" + i; // Set a unique name for each TextBox
                    txt.Top = i * 30; // Adjust the vertical position of each TextBox
                    txt.Size = new Size(200, 20); // Set the size of each TextBox
                    txt.Text = "Folder " + i; // Set default text for each TextBox and increment the number

                }

                
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BTN_CreateFolders_Click(object sender, EventArgs e)
        {
            try
            {
                //stores values from dynamically created textboxes into a list of strings
                foreach (Control ctrl in FLP_TextBoxContainer.Controls)
                {
                    if (ctrl is TextBox txt)
                    {
                        folderNamesCollection.Add(txt.Text); // Add the text from each TextBox to the list
                    }
                }

                // Create folders based on the names in the list
                foreach (string itemFolderNames in folderNamesCollection)
                {
                    string newFolder = folderPath + "\\" + itemFolderNames;
                    if (!Directory.Exists(newFolder))
                    {
                        Directory.CreateDirectory(newFolder);
                    }
                    else
                    {
                        MessageBox.Show("Folder already exists at this location.");
                        return;
                    }

                }
                // Show a message box indicating that the folders were created successfully
                if (folderNamesCollection.Count == 1)
                {
                    MessageBox.Show("Folder created successfully!");//Display message if only one folder was created
                }
                else
                {
                    MessageBox.Show("All Folders created successfully!");//Display message if multiple folders were created
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
