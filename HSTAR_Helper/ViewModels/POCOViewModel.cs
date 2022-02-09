using DevExpress.Mvvm.DataAnnotations;
using System.IO;
using System.Windows;

namespace HSTAR_Helper.ViewModels
{
    [POCOViewModel]
    public class POCOViewModel
    {
        public virtual string FileName { get; set; }
        public virtual string FilePath { get; set; }

        public virtual bool IsFileLoaded { get; set; }

        public POCOViewModel()
        {
            IsFileLoaded = true;
        }
        public void UniformStackPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string filename = Path.GetFileName(files[0]);

                FilePath = Path.GetDirectoryName(files[0]);

                FileName = filename;
                
                IsFileLoaded = true;
            }
        }
    }
}