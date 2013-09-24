using System.Windows.Forms;

namespace ZPA_Lab_1
{
    public partial class ATSSubscribersForm : Form
    {
        public ATSSubscribersForm()
        {
            InitializeComponent();
            var requests = new Requests();
            cmbRequests.DataSource = requests.Names;
            var dataBase = new DataBase();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {

        }
    }
}
