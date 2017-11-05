using System;
using System.Windows.Forms;

namespace NumberRecognizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BLearning_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog.SelectedPath;
                var trainingForm = new TrainingForm(path);
                trainingForm.ShowDialog();
            }
        }
    }
}
