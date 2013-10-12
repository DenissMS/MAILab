using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using MAILab.XmlMap;

namespace MAILab
{
    public partial class ATSSubscribersForm : Form
    {
        private readonly SubscriberObjectMap _data;
        private Item _filter;

        internal class Item
        {
            public string Id;
            public string Text;
            public Criteria[] Criteria;

            public Item(string id, string text, Criteria[] criteria)
            {
                Id = id;
                Text = text;
                Criteria = criteria;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public ATSSubscribersForm()
        {

            InitializeComponent();

            var serializer = new XmlSerializer(typeof (SubscriberObjectMap));
            using (var fs = new FileStream("Data\\Subscribers.xml", FileMode.Open))
            {
                _data = (SubscriberObjectMap) serializer.Deserialize(fs);
            }
            serializer = new XmlSerializer(typeof(FilterObjectMap));
            FilterObjectMap filters;
            using (var fs = new FileStream("Data\\Filters.xml", FileMode.Open))
            {
                filters = (FilterObjectMap) serializer.Deserialize(fs);
            }

            UpdateDataGrid(_data.Subscribers);
            
            foreach (var filter in filters.Filters)
            {
                cmbFilters.Items.Add(new Item(filter.ID, filter.Name, filter.Criteria));
            }
        }

        public void UpdateDataGrid(IEnumerable<Subscriber> data)
        {
            dgvDataBase.Rows.Clear();
            foreach (var s in data)
            {
                dgvDataBase.Rows.Add(s.ID,
                                     string.Format("{0} {1}. {2}.", s.Surname, s.Name[0], s.Patronymic[0]),
                                     s.Address, s.DateOfBirth, s.Facilities ?  Resource.Yes: Resource.No, s.Debt?Resource.Yes:Resource.No, s.Childrens, s.Description,
                                     s.IsViolator ? Resource.Yes : Resource.No,
                                     s.MaritalStatus == MaritalStatus.Married ? Resource.Yes : Resource.No,
                s.IsRetirement ? Resource.Yes : Resource.No);
            }
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < lСriterias.Count; i++)
            {
                switch (_filter.Criteria[i].Type)
                {
                    case CriteriaType.Boolean:
                        _filter.Criteria[i].Value = ((CheckBox) lСriterias[i]).Checked;
                        break;
                    case CriteriaType.Enumeration:
                        break;
                    case CriteriaType.Float:
                    case CriteriaType.Integer:
                        _filter.Criteria[i].Value = ((NumericUpDown)lСriterias[i]).Value;
                        break;
                }
            }
            var result = new FilterRequest(_data.Subscribers, _filter.Criteria);
            UpdateDataGrid(result.Subscribers);
        }

        private void cmbFilters_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            gbRequestParameters.Controls.Clear();
            _filter = (Item)cmbFilters.SelectedItem;
            var location = new Point(6, 19);
            foreach (var criteria in _filter.Criteria)
            {
                const int distance = 23;
                switch (criteria.Type)
                {
                    case CriteriaType.Boolean:
                        var checkBox = new CheckBox
                            {
                                AutoSize = true,
                                Location = location,
                                Name = "chb" + criteria.ID,
                                Text = criteria.Name,
                                UseVisualStyleBackColor = true
                            };
                        lСriterias.Add(checkBox);
                        break;
                    case CriteriaType.Enumeration:
                        break;
                    case CriteriaType.Float:
                    case CriteriaType.Integer:
                        var label = new Label
                            {
                                
                                Location = location,
                                Name = "lbl" + criteria.ID,
                                Text = criteria.Name + ":"
                            };
                        gbRequestParameters.Controls.Add(label);
                        var numeric = new NumericUpDown
                            {
                                Location = new Point(location.X + label.Size.Width, location.Y),
                                Name = "nud" + criteria.ID,
                                Size = new Size(50, 20),
                                Value = 0
                            };
                        lСriterias.Add(numeric);
                        break;
                }
                location.Y += distance;
            }
            foreach (var control in lСriterias)
            {
                gbRequestParameters.Controls.Add(control);
            }
        }
    }
}
