using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolandPeople
{
    public partial class CreatePerson : Form
    {
        Poland_People pP = new Poland_People();

        public CreatePerson()
        {
            InitializeComponent();

            DialogResult= DialogResult.Cancel;
        }

        private void CreatePerson_Load(object sender, EventArgs e)
        {
            var conn = pP.Connection;

            using (var connection = new SqlConnection(conn))
            {
                connection.Open();
                var query = "SELECT * FROM Wojewodztwa";
                SqlCommand cmd = new SqlCommand(query, connection);
                //var adapter = new SqlDataAdapter(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBoxProvince.DataSource = table;
                comboBoxProvince.DisplayMember = "NazwaWojewodztwa";
                comboBoxProvince.ValueMember = "ID_Wojewodztwa";
            }
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int nextAvailableId = -1;
            var conn = pP.Connection;

            using (var connection = new SqlConnection(conn))
            {
                connection.Open();
                var query = "SELECT ID_Osoby FROM Osoby WHERE ID_Osoby=(select max(ID_Osoby) from Osoby)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nextAvailableId = Convert.ToInt32(result) + 1;
                    }
                }
            }

            Person person = new Person();
            person.Id = nextAvailableId;
            person.FirstName = textBoxFirstName.Text;
            person.LastName = textBoxLastName.Text;
            person.Pesel = textBoxPesel.Text;
            person.BirthdayDate = dateTimeBirthday.Value;
            person.SkinColor= textBoxSkinColor.Text;
            person.IdProvince = comboBoxProvince.SelectedIndex + 1;
            person.Occupation = textBoxOccupation.Text;

            pP.CreateNewPerson(person);

            DialogResult= DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
