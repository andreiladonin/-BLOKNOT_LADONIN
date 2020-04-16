using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocknot
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set;}
        void SetSymbol(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanget;
    }
    public partial class MainForm : Form, IMainForm

    {
        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += butOpenFile_Click;
            butSave.Click += butSave_Click;
            fileContent.TextChanged += fldContent_TextChanged;
            butSelectFile.Click += butSelectFile_Click;
            numeFont.Click += numFont_ValueChange;
        }

        #region Проброс событий
        private void butOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void fldContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanget != null) ContentChanget(this, EventArgs.Empty);
        }
        #endregion

        #region Реализация
        public string FilePath
        {
            get { return fldFilePath.Text; }
        }
        public string Content
        {
            get {  return fileContent.Text; }
            set { fileContent.Text = value; }

        }

       

        public void SetSymbol (int count)
        {
            lblSymbolCount.Text = count.ToString();
        }


       public event EventHandler FileOpenClick;
       public event EventHandler FileSaveClick;
       public event EventHandler ContentChanget;

        #endregion


        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dialog.FileName;

                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);

            }
        }

        private void numFont_ValueChange (object sender, EventArgs e)
        {
            fileContent.Font = new Font("Arial", (float)numeFont.Value);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Шрифт_Click(object sender, EventArgs e)
        {

        }
    }
}
