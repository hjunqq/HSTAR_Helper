using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HSTAR_Helper.Views
{
    /// <summary>
    /// Interaction logic for DragDropView.xaml
    /// </summary>
    public partial class DragDropView : UserControl
    {
        public DragDropView()
        {
            InitializeComponent();
        }

        private void UniformStackPanel_Drop(object sender, DragEventArgs e)
        {

        }

        //private void UniformStackPanel_Drop(object sender, DragEventArgs e)
        //{

        //}

        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        DataObject data = new DataObject();
        //        string[] dataFormats = data.GetFormats();
        //    }
        //}
    }
}
