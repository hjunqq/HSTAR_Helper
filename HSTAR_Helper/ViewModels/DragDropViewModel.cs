using DevExpress.Mvvm;
using System.IO;
using System.Windows;

namespace HSTAR_Helper.ViewModels
{
    public class DragDropViewModel : ViewModelBase
    {
        public virtual string FileName
        {
            get => GetProperty(() => FileName);
            set => SetProperty(() => FileName, value);
        }

        public DragDropViewModel()
        {
            FileName = "Test";
        }
        public void UniformStackPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string filename = Path.GetFileName(files[0]);

                FileName = filename;
            }
        }

    }
}