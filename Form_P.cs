using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Maket
{
    public partial class Form_P : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JO84FD1\HP;Initial Catalog=Autobuspark;Integrated Security=True");
        public Form_P()
        {
            InitializeComponent();
        }
        private void Form_P_Load(object sender, EventArgs e)
        {
            con.Open();
            load_data(painter_table, 1);
            load_data(museum_table, 2);
            load_data(exposition_table, 3);
            DateTime date = DateTime.Today;
            label1.Text = date.ToString();
        }
        // //////////////////////////////////////////////ФУНКЦИИ///////////////////////////////////////////
        void load_data(DataGridView d, int n)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            switch (n)
            {
                case 1:
                    da = new SqlDataAdapter("SELECT Table_bus.ID, Kolvo_bus as 'Количество', Mest_in_bus as 'Мест в автобусе', Adress_park as 'Адрес парка'   FROM Table_bus", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;


                case 2:
                    da = new SqlDataAdapter("SELECT Table_Passengers.ID,FIO_passagers as 'ФИО пассажира', User_ID as 'ID водителя', FIO_Voditely as 'ФИО водителя'   FROM Table_Passengers", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;


                case 3:
                    da = new SqlDataAdapter("SELECT Table_Stop.ID, Type_Stop as 'Тип остановки', ID_Way as 'ID маршрута', Ticket_office as 'Билетная касса'   FROM Table_Stop", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;

            }
        }
        // ////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }
        // //////////////////////////////////////////Пассажиры//////////////////////////////////////////////////
        private void start2_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }
        private void open2_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Adress_park as 'Адрес парка', Kolvo_bus as 'Количество автобусов' from dbo.Table_bus where Availability=1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            museum_table.DataSource = dt;
        }

        private void update2_btn_Click(object sender, EventArgs e)
        {
            
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name as 'Название', City as 'Город', Max_Number_of_Visitors as 'Макс.Кол-во.Посетителей', Open_Date as 'Дата Открытия', Topic as 'Тематика', Start_Date as 'Дата Начала', End_Date as 'Дата Окончания' FROM dbo.Museum left join dbo.Exposition on (dbo.Museum.ID=dbo.Exposition.Museum_ID) WHERE " +  "'  ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                museum_table.DataSource = dt;
            }
        }
        // //////////////////////////////////////////Остановки//////////////////////////////////////////////////
        private void start3_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }

        private void exposition_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Topic as 'Тематика', Start_Date as 'Дата Начала', End_Date as 'Дата Окончания', Name as 'Музей' FROM dbo.Exposition join dbo.Museum on(dbo.Exposition.Museum_ID= dbo.Museum.ID) where getdate() between Start_Date and End_Date", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            exposition_table.DataSource = dt;
        }

       

        private void update1_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") load_data(painter_table, 1);
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Table_bus.ID, Table_bus.Kolvo_bus as 'Количество', Mest_in_bus as 'Мест в автобусе', Adress_park as 'Адрес парка'FROM dbo.Table_bus WHERE " + comboBox1.Text + " LIKE '%" + find1_txt.Text + "%'  ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                painter_table.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }

    }
}