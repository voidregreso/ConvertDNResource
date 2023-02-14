using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Threading;

namespace ConvertResource
{
    public partial class ConvertForm : Form
    {
        private string[] compres_files = null, resx_files = null;

        public ConvertForm()
        {
            InitializeComponent();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = ".NET compiled resources file(*.resources)|*.resources";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                compres_files = openFileDialog.FileNames;
                txtResources.Text = string.Join("|", compres_files);
            }
            openFileDialog.FileName = string.Empty;
        }

        private void btnResx_Click(object sender, EventArgs e)
        {
            openFileDialog_resx.Filter = "Original RESXs(*.resx)|*.resx";
            openFileDialog_resx.Multiselect = true;
            if (openFileDialog_resx.ShowDialog() == DialogResult.OK)
            {
                resx_files = openFileDialog_resx.FileNames;
                txtResx.Text = string.Join("|", resx_files);
            }
            openFileDialog_resx.FileName = string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var selectedTab = mainTab.SelectedIndex;
            Thread backgroundThread;
            if (selectedTab == 0 && compres_files?.Length > 0)
            {
                string basePath = Path.GetDirectoryName(compres_files[0]);
                Directory.CreateDirectory(basePath);
                backgroundThread = new Thread(() =>
                {
                    foreach (string strResources in compres_files)
                    {
                        string strResx = Path.ChangeExtension(strResources, ".resx");
                        using (var reader = new ResourceReader(strResources))
                        using (var writer = new ResXResourceWriter(strResx))
                        {
                            foreach (DictionaryEntry en in reader)
                            {
                                writer.AddMetadata(en.Key.ToString(), en.Value);
                            }
                        }
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Succeeded to convert!", "Tips");
                        txtResources.Text = string.Empty;
                    });
                });

                backgroundThread.IsBackground = true;
                backgroundThread.Start();
            }
            else if (selectedTab == 1 && resx_files?.Length > 0)
            {
                string basePath = Path.GetDirectoryName(resx_files[0]);
                Directory.CreateDirectory(basePath);

                backgroundThread = new Thread(() =>
                {
                    foreach (string strResx in resx_files)
                    {
                        string strRec = Path.ChangeExtension(strResx, ".resources");

                        using (ResXResourceReader resxReader = new ResXResourceReader(strResx))
                        using (ResourceSet resourceSet = new ResourceSet(resxReader))
                        using (ResourceWriter resourceWriter = new ResourceWriter(strRec))
                        {
                            foreach (DictionaryEntry entry in resourceSet)
                            {
                                resourceWriter.AddResource(entry.Key.ToString(), entry.Value);
                            }
                        }
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Succeeded to convert!", "Tips");
                        txtResources.Text = string.Empty;
                    });
                });

                backgroundThread.IsBackground = true;
                backgroundThread.Start();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void MyDragDrop(object sender, DragEventArgs e)
        {
            var selectedTab = mainTab.SelectedIndex;
            if (selectedTab == 0)
            {
                compres_files = e.Data.GetData(DataFormats.FileDrop) as string[];
                txtResources.Text = string.Join("|", compres_files);
                openFileDialog.FileName = string.Empty;
            }
            else if (selectedTab == 1)
            {
                resx_files = e.Data.GetData(DataFormats.FileDrop) as string[];
                txtResx.Text = string.Join("|", resx_files);
                openFileDialog_resx.FileName = string.Empty;
            }
        }

        private void MyDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}