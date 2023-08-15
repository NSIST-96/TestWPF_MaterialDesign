using System.Windows;
using System.Windows.Controls;

namespace TestWPF_MaterialDesign.Utilites
{
    class Btn : RadioButton
    {
        static Btn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
        }
    }
}
