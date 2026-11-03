using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foldermaker_V1._0
{
    public partial class Utils
    {
        public static void ApplyMaterialSkin(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, 
                Primary.BlueGrey900, Primary.BlueGrey500,
                    Accent.LightBlue200, TextShade.WHITE);
        }

        public static bool FormIsOpen(string name)
        {
            //check if window is already open
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(q => q.Name == name);
            return isOpen;
        }
    }
}
