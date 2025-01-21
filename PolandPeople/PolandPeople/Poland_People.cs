using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PolandPeople
{
    public enum ESearchType
    {
        PESEL,
        LAST_NAME,
        PROVINCE
    }
    public partial class Poland_People : Form
    {
        static string _connection = "";
        string _serverName = "";
        string _databaseName = "";

        ESearchType eSearchType = ESearchType.PESEL;

        public string Connection { get { return _connection; } }

        public Poland_People()
        {
            InitializeComponent();
            DialogResult= DialogResult.OK;
        }
        
        public void CreateNewPerson(Person person)
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                var sqlInsert = "INSERT INTO Osoby " +
                                "(ID_Osoby, Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, ID_Wojewodztwa, Zawod) VALUES " +
                                "(@ID_Osoby, @Imie, @Nazwisko, @PESEL, @DataUrodzenia, @KolorSkory, @ID_Wojewodztwa, @Zawod);";

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    command.Parameters.AddWithValue("@ID_Osoby", person.Id);
                    command.Parameters.AddWithValue("@Imie", person.FirstName);
                    command.Parameters.AddWithValue("@Nazwisko", person.LastName);
                    command.Parameters.AddWithValue("@PESEL", person.Pesel);
                    command.Parameters.AddWithValue("@DataUrodzenia", person.BirthdayDate);
                    command.Parameters.AddWithValue("@KolorSkory", person.SkinColor);
                    command.Parameters.AddWithValue("@ID_Wojewodztwa", person.IdProvince);
                    command.Parameters.AddWithValue("@Zawod", person.Occupation);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadPeople()
        {
            using (var connection = new SqlConnection(_connection))
            {
                var query = "SELECT * FROM Osoby";
                var adapter = new SqlDataAdapter(query, connection);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void SearchPeopleBy(ESearchType searchType, string userInput)
        {
            using (var connection = new SqlConnection(_connection))
            {
                var query = "";
                switch(searchType)
                {
                    case ESearchType.PESEL:
                        query = "SELECT * FROM Osoby WHERE PESEL=@PESEL";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PESEL", userInput);

                            var adapter = new SqlDataAdapter(command);
                            var table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                        break;
                    case ESearchType.LAST_NAME:
                        query = "SELECT * FROM Osoby WHERE Nazwisko=@Nazwisko";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nazwisko", userInput);

                            var adapter = new SqlDataAdapter(command);
                            var table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                        break;
                    case ESearchType.PROVINCE:
                        query = "SELECT Osoby.* FROM Osoby INNER JOIN Wojewodztwa ON Osoby.ID_Wojewodztwa = Wojewodztwa.ID_Wojewodztwa WHERE Wojewodztwa.NazwaWojewodztwa = @NazwaWojewodztwa;";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NazwaWojewodztwa", userInput);

                            var adapter = new SqlDataAdapter(command);
                            var table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                        break;
                }
                
            }
        }

        private void DeletePerson(int personId)
        {
            using (var connection = new SqlConnection(_connection))
            {
                connection.Open();
                var sqlDelete = "DELETE FROM Osoby WHERE ID_Osoby=@ID_Osoby";
                using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                {
                    command.Parameters.AddWithValue("@ID_Osoby", personId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _serverName = textBoxServer.Text;
            _databaseName = textBoxDatabase.Text;
            _connection = $"Data Source={_serverName};Initial Catalog={_databaseName}; Integrated Security=true";

            LoadPeople();
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            CreatePerson createPerson = new CreatePerson();
            if (createPerson.ShowDialog() == DialogResult.OK)
            {
                LoadPeople();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var val = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int personId = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usun¹æ tê osobê?", "Usuñ osobê", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            DeletePerson(personId);
            LoadPeople();
        }

        private void buttonFindByLastName_Click(object sender, EventArgs e)
        {
            string userInput = textBoxSearch.Text;
            SearchPeopleBy(eSearchType, userInput);
        }

        private void radioButtonPesel_CheckedChanged(object sender, EventArgs e)
        {
            eSearchType = ESearchType.PESEL;
        }

        private void radioButtonLastName_CheckedChanged(object sender, EventArgs e)
        {
            eSearchType = ESearchType.LAST_NAME;
        }

        private void radioButtonProvince_CheckedChanged(object sender, EventArgs e)
        {
            eSearchType= ESearchType.PROVINCE;
        }
    }
}