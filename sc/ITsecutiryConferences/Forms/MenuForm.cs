using ITsecutiryConferences.DataBase;
using ITsecutiryConferences.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITsecutiryConferences.Forms
{
    public partial class MenuForm : Form
    {
        private List<Events> EventsList = new List<Events>();

        public MenuForm()
        {
            InitializeComponent();
            GetEventList();
            GridSettings();
            //
            this.Icon = Properties.Resources.icon;
        }

        #region Grid Events
        private void GetEventList()
        {
            try
            {
                using (var Connection = new SqlConnection(ConfigurationData.DbConnect))
                {
                    Connection.Open();
                    //
                    using (var EventList = new SqlCommand(
                        "SELECT Events.Name, Events.Date, Events.Days, City.Name " +
                        "FROM " +
                        "Events " +
                        "INNER JOIN City ON City.ID = Events.City", Connection))
                    {
                        using (var ReadEventList = EventList.ExecuteReader())
                        {
                            while (ReadEventList.Read())
                            {
                                var Event = new Events()
                                {
                                    Name = ReadEventList[0].ToString(),
                                    Date = Convert.ToDateTime(ReadEventList[1]),
                                    Days = Convert.ToInt32(ReadEventList[2]),
                                    City = ReadEventList[3].ToString()
                                };
                                //
                                EventsList.Add(Event);
                            }
                            //
                            GridEvents.DataSource = EventsList;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Список мероприятий получить невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridSettings()
        {
            GridEvents.RowHeadersVisible = false;
            GridEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //
            GridEvents.Columns[0].HeaderText = "Наименование";
            GridEvents.Columns[1].HeaderText = "Дата";
            GridEvents.Columns[2].HeaderText = "Дней";
            GridEvents.Columns[3].HeaderText = "Город";
        }

        #endregion

        #region Filter
        private void DateFilter_ValueChanged(object sender, EventArgs e)
        {
            GridEvents.DataSource = EventsList.Where(item => item.Date.Date == DateFilter.Value.Date).ToList();
        }

        private void ButtonResetFilter_Click(object sender, EventArgs e)
        {
            DateFilter.Value = DateTime.Now;
            //
            GridEvents.DataSource = EventsList;
        }
        #endregion

        #region Redirect to Authorization
        private void button1_Click(object sender, EventArgs e)
        {
            new AuthorizationForm().Show();
            //
            this.Hide();
        }
        #endregion

        #region Close Application
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}