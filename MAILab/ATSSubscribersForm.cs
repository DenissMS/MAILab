using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MAILab
{
    public partial class ATSSubscribersForm : Form
    {
        private DataBase _data;

        public ATSSubscribersForm()
        {
            InitializeComponent();
            var requests = new Filters();
            cmbRequests.DataSource = requests.Names;
            var serializer = new XmlSerializer(typeof (DataBase));
            using (var fs = new FileStream("DataBase.xml", FileMode.Open))
            {
                _data = (DataBase) serializer.Deserialize(fs);
            }
            foreach (var s in _data.Subscribers)
            {
                dgvDataBase.Rows.Add(s.ID,
                                     string.Format("{0} {1} {2}", s.Surname, s.Name,
                                                   s.Patronymic),
                                     s.Address, s.DateOfBirth, s.Facilities.List, s.Debt, s.Childrens, s.Description,
                                     s.IsAlcoholic ? "Да" : "Нет",
                                     s.MaritalStatus == MaritalStatus.Married ? "Да" : "Нет");
            }
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {

        }
    }
}
