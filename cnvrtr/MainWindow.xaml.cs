using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Forms;

namespace cnvrtr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            NDest.Text = Directory.GetCurrentDirectory();
        }

        private bool isExist(string file)
        {
            for (int c = 0; c < fileList.Items.Count; c++)
            {
                MyItem El = (MyItem)fileList.Items.GetItemAt(c);
                if (El.Data == file)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image JPEG Files | *.jpg; *.jpeg; *.jpe; *.gfif | Image BMP Files | *.bmp; *.dib; *.rle | Image GIF Files | *.gif | Image TIFF Files | *.tif; *.tiff | Image PNG Files | *.png | Image ICO Files | *.ico | Image WMF Files | *.wmf";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                foreach (String file in dlg.FileNames)
                {
                    if (!isExist(file))
                    {
                        String fName, fExt, fDest;
                        fName = System.IO.Path.GetFileNameWithoutExtension(file);
                        fExt = System.IO.Path.GetExtension(file);
                        fDest = System.IO.Path.GetDirectoryName(file);
                        fileList.Items.Add(new MyItem { Dest = fDest, Extension = fExt, Name = fName, Data = file });
                    }
                }
            }
        }

        private void btnChDst_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult result = dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.SelectedPath))
            {
                string folderName = dlg.SelectedPath;
                NDest.Text = folderName;
            }
        }

        private void main_convert()
        {

        }

        private void cnvrtBtn_Click(object sender, RoutedEventArgs e)
        {
            Converter conv = new Converter();
            switch (cbbFrm.SelectedIndex)
            {
                case 0:
                    {           
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToBMP(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 1:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToJPG(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 2:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToPNG(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 3:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToTIFF(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 4:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToGIF(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 5:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToICO(Elem.Data, Elem.Name);
                        }
                    }
                    break;
                case 6:
                    {
                        for (int c = 0; c < fileList.Items.Count; c++)
                        {
                            MyItem Elem = (MyItem)fileList.Items.GetItemAt(c);
                            conv.convertToWMF(Elem.Data, Elem.Name);
                        }
                    }
                    break;
            }
            System.Windows.MessageBox.Show("Success!");
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            while (fileList.SelectedItems.Count > 0)
            {
                fileList.Items.Remove(fileList.SelectedItems[0]);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            init();
            fileList.Items.Clear();
        }
    }
}
