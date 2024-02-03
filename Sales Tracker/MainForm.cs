using System.Security.Cryptography.X509Certificates;

namespace Sales_Tracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Event> events;

        private void MainForm_Load(object sender, EventArgs e)
        {
            events = new List<Event>();
        }
    }
}
