using PCShop.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MotherboardUC.xaml
    /// </summary>
    public partial class MotherboardUC : UserControl
    {
        public MotherboardUC(Classes.Motherboard motherboard)
        {
            InitializeComponent();
            name.Text = $"Модель: {motherboard.Name}";
            image = ImageByte.ByteToImage(motherboard.Image);
        }

    }
}
