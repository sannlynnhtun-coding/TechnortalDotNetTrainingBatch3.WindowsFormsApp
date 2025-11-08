namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World.");
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
            //MessageBox.Show("");
            //frm.ShowDialog();
        }
    }
}
