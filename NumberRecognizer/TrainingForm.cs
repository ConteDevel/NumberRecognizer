using System.Windows.Forms;

namespace NumberRecognizer
{
    public partial class TrainingForm : Form
    {
        public const string DataPath = "data.tr";

        private string _path;
        private bool _processing = false;

        public TrainingForm(string path)
        {
            _path = path;

            InitializeComponent();
        }

        private void BProcess_Click(object sender, System.EventArgs e)
        {
            int xCount = (int)nudX.Value;
            var training = new NetTraining(_path, DataPath, xCount);
            training.Process();
            Close();
        }

        private void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_processing)
            {
                e.Cancel = true;
            }
        }
    }
}
