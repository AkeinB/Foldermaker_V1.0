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
    
    public partial class FolderNaming : MaterialSkin.Controls.MaterialForm
    {
        private readonly int folderAmount;
        private readonly string folderPath;
        public FolderNaming(int FolderAmount, string FolderPath)
        {
            InitializeComponent();
            Utils.ApplyMaterialSkin(this);
            folderAmount = FolderAmount;
            folderPath = FolderPath;
        }
    }
}
