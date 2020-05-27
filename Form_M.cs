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
    public partial class Form_M : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JO84FD1\HP;Initial Catalog=Autobuspark;Integrated Security=True");
        // //////////////////////////////////////////////////////////////////////////ФУНКЦИИ////////////////////////////////////////////////////////////////
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
                    da = new SqlDataAdapter("SELECT Table_Remont.ID,FIO_Masters as 'ФИО мастера', Time_remont as 'Время ремонта', Type as 'Тип сложности', Cost as 'Стоимость'   FROM Table_Remont", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;
                case 4:
                    da = new SqlDataAdapter("SELECT Table_Stop.ID, Type_Stop as 'Тип остановки', ID_Way as 'ID маршрута', Ticket_office as 'Билетная касса'   FROM Table_Stop", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;
                case 5:
                    da = new SqlDataAdapter("SELECT Table_Voditely.ID,FIO as 'ФИО водителя', Oklad as 'Зарплата', Stag as 'Стаж', Adress as 'Адрес проживания'   FROM Table_Voditely", con);
                    da.Fill(dt);
                    d.DataSource = dt;
                    break;
            }
        }
        void clear()
        {
            id1_txt.Text = ""; name1_txt.Text = "";  surname1_txt.Text = ""; gender1_txt.Text = "";   
            id2_txt.Text = ""; name2_txt.Text = "";  city2_txt.Text = "";    visitors2_txt.Text = ""; 
            id3_txt.Text = ""; topic3_txt.Text = ""; start3_txt.Text = "";   end3_txt.Text = "";       expositor3_txt.Text = "";      
            id4_txt.Text = ""; name4_txt.Text = "";  surname4_txt.Text = ""; nation4_txt.Text = "";    
            id5_txt.Text = ""; name5_txt.Text = "";  cost5_txt.Text = "";    painter5_txt.Text = "";   restoration5_txt.Text = "";   
        }
        void delete(string str1, string str2, DataGridView d, int n)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM " + str1 + " WHERE ID='" + str2 + "'", con);
            cmd.ExecuteNonQuery();
            load_data(d, n);
            clear();
            MessageBox.Show("Запись Удалена");
        }
        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Form_M()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            load_data(expositor_table, 1);
            load_data(museum_table, 2);
            load_data(exposition_table, 3);
            load_data(painter_table, 4);
            load_data(picture_table, 5);
        }
        // /////////////////////////////////////////////////////////////////////////Автобус////////////////////////////////////////////////////
        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_bus values('"+id1_txt.Text+"','" +name1_txt.Text+"','"+surname1_txt.Text+"','"+gender1_txt.Text+"')", con);
            cmd.ExecuteNonQuery();
            load_data(expositor_table, 1);
            clear();
            MessageBox.Show("Сохранено");
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Table_bus SET Kolvo_bus='" + name1_txt.Text+"', Mest_in_bus='"+surname1_txt.Text+ "', Adress_park='" +gender1_txt.Text + "' where ID = '" + id1_txt.Text + "'", con);
            cmd.ExecuteNonQuery();
            load_data(expositor_table, 1);
            clear();
            MessageBox.Show("Данные Обновлены");
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            delete("dbo.Table_bus", id1_txt.Text, expositor_table, 1);
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }
           
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cri = expositor_table.CurrentCell.RowIndex;
            id1_txt.Text = expositor_table.Rows[cri].Cells[0].Value.ToString();
            name1_txt.Text = expositor_table.Rows[cri].Cells[1].Value.ToString();
            surname1_txt.Text = expositor_table.Rows[cri].Cells[2].Value.ToString();
            gender1_txt.Text = expositor_table.Rows[cri].Cells[3].Value.ToString();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Table_bus.ID, Table_bus.Kolvo_bus as 'Количество', Mest_in_bus as 'Мест в автобусе', Adress_park as 'Адрес парка'FROM dbo.Table_bus WHERE " + comboBox1.Text + " LIKE '%" + find1_txt.Text + "%'  ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            expositor_table.DataSource = dt;
        }
        // /////////////////////////////////////////////////////////////////////////Пассажир////////////////////////////////////////////////////
        private void delete2_btn_Click(object sender, EventArgs e)
        {
            delete("dbo.Table_Passengers", id2_txt.Text, museum_table, 2);
        }
        private void save2_btn_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Passengers values('" + id2_txt.Text + "','" + name2_txt.Text + "','" + city2_txt.Text + "','" + visitors2_txt.Text +  "')", con);
            cmd.ExecuteNonQuery();
            load_data(museum_table, 2);
            clear();
            MessageBox.Show("Сохранено");
        }
        private void clear2_btn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void update2_btn_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Table_Passengers SET ID='" + id2_txt.Text  + "', FIO_passagers='" + name2_txt.Text + "', User_ID='" + city2_txt.Text + "', FIO_Voditely='" + visitors2_txt.Text + "' where ID = '" + id2_txt.Text + "'", con);
            cmd.ExecuteNonQuery();
            load_data(museum_table, 2);
            clear();
            MessageBox.Show("Данные Обновлены");
        }    
        private void start2_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }
       
        private void museum_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cri = museum_table.CurrentCell.RowIndex;
            id2_txt.Text = museum_table.Rows[cri].Cells[0].Value.ToString();
            name2_txt.Text = museum_table.Rows[cri].Cells[1].Value.ToString();
            city2_txt.Text = museum_table.Rows[cri].Cells[2].Value.ToString();
            visitors2_txt.Text = museum_table.Rows[cri].Cells[3].Value.ToString();
           
        }
        // /////////////////////////////////////////////////////////////////////////Водитель////////////////////////////////////////////////////
        private void exposition_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cri = exposition_table.CurrentCell.RowIndex;
            id3_txt.Text = exposition_table.Rows[cri].Cells[0].Value.ToString();
            topic3_txt.Text = exposition_table.Rows[cri].Cells[1].Value.ToString();
            start3_txt.Text = exposition_table.Rows[cri].Cells[2].Value.ToString();
            end3_txt.Text = exposition_table.Rows[cri].Cells[3].Value.ToString();
            expositor3_txt.Text = exposition_table.Rows[cri].Cells[4].Value.ToString();
            
        }
        private void start3_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }

        private void clear3_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void delete3_btn_Click(object sender, EventArgs e)
        {
            delete("dbo.Table_Remont", id3_txt.Text, exposition_table, 3);
        }

        private void save3_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Remont values('" + id3_txt.Text + "','" + topic3_txt.Text + "','" + start3_txt.Text + "','" + end3_txt.Text + "','" + expositor3_txt.Text + "')", con);

          /*SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Passengers values('" + id2_txt.Text + "','" + name2_txt.Text + "','" + city2_txt.Text + "','" + visitors2_txt.Text +  "')", con);*/
            cmd.ExecuteNonQuery();
            load_data(exposition_table, 3);
            clear();
            MessageBox.Show("Сохранено");
        }

        private void update3_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Table_Remont SET ID='" + id3_txt.Text + "', FIO_Masters='" + topic3_txt.Text + "', Time_remont='" + start3_txt.Text + "', Type='" + end3_txt.Text + "', Cost='" + expositor3_txt.Text+ "' where ID = '" + id3_txt.Text + "'  ", con);
            cmd.ExecuteNonQuery();
            load_data(exposition_table, 3);
            clear();
            MessageBox.Show("Данные Обновлены");
        }

        // /////////////////////////////////////////////////////////////////////////ХУДОЖНИКИ////////////////////////////////////////////////////////////
        private void painter_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cri = painter_table.CurrentCell.RowIndex;
            id4_txt.Text = painter_table.Rows[cri].Cells[0].Value.ToString();
            surname4_txt.Text = painter_table.Rows[cri].Cells[2].Value.ToString();
            name4_txt.Text = painter_table.Rows[cri].Cells[1].Value.ToString();
            nation4_txt.Text = painter_table.Rows[cri].Cells[3].Value.ToString();
        }

        private void delete4_btn_Click(object sender, EventArgs e)
        {
            delete("dbo.Table_Stop", id4_txt.Text, painter_table, 4);
        }

        private void clear4_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void save4_btn_Click(object sender, EventArgs e)
        {

          /*SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Remont values('" + id3_txt.Text + "','" + topic3_txt.Text + "','" + start3_txt.Text + "','" + end3_txt.Text + "','" + expositor3_txt.Text + "')", con);*/
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Stop values('" + id4_txt.Text + "','" + name4_txt.Text + "','" + surname4_txt.Text + "','" + nation4_txt.Text + "')", con);
            cmd.ExecuteNonQuery();
            load_data(painter_table, 4);
            clear();
            MessageBox.Show("Сохранено");
        }

        private void update4_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Table_Stop SET ID='" + id4_txt.Text + "', Type_Stop='" + name4_txt.Text + "', ID_Way='" + surname4_txt.Text + "',Ticket_office='" + nation4_txt.Text + "' where ID = '" + id4_txt.Text + "'", con);
          /*SqlCommand cmd = new SqlCommand("UPDATE dbo.Table_Remont SET ID='" + id3_txt.Text + "', FIO_Masters='" + topic3_txt.Text + "', Time_remont='" + start3_txt.Text + "', Type='" + end3_txt.Text + "', Cost='" + expositor3_txt.Text + "' where ID = '" + id3_txt.Text + "'  ", con);*/
            cmd.ExecuteNonQuery();
            load_data(painter_table, 4);
            clear();
            MessageBox.Show("Данные Обновлены");
        }

        private void start4_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }

        private void find4_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.Table_Stop.ID, Type_Stop as 'Тип остановки', ID_Way as 'ID маршрута', Ticket_office as 'Билетная касса' FROM dbo.Table_Stop WHERE " + comboBox4.Text + " LIKE '%" + find4_txt.Text + "%'  ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            painter_table.DataSource = dt;
        }
        // /////////////////////////////////////////////////////////////////////////КАРТИНЫ////////////////////////////////////////////////////////////
        private void clear5_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void delete5_btn_Click(object sender, EventArgs e)
        {
            delete("dbo.Picture", id5_txt.Text, picture_table, 5);
        }

        private void start5_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Enter f = new Form_Enter();
            f.Show();
        }
        private void picture_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cri = picture_table.CurrentCell.RowIndex;
            id5_txt.Text = picture_table.Rows[cri].Cells[0].Value.ToString();
            name5_txt.Text = picture_table.Rows[cri].Cells[1].Value.ToString();
            cost5_txt.Text = picture_table.Rows[cri].Cells[2].Value.ToString();
            painter5_txt.Text = picture_table.Rows[cri].Cells[3].Value.ToString();
            restoration5_txt.Text = picture_table.Rows[cri].Cells[4].Value.ToString();

        }

        private void save5_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table_Voditely values('" + id5_txt.Text + "','" + name5_txt.Text + "','" + cost5_txt.Text + "','" + painter5_txt.Text + "','" + restoration5_txt.Text + "')", con);
            cmd.ExecuteNonQuery();
            load_data(picture_table, 5);
            clear();
            MessageBox.Show("Сохранено");
        }

        private void update5_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Table_Voditely SET ID='" + id5_txt.Text + "', FIO='" + name5_txt.Text + "', Oklad='" + cost5_txt.Text + "', Stag='" + painter5_txt.Text + "', Adress='"  + restoration5_txt.Text + "' where ID = '" + id5_txt.Text + "' ", con);
            cmd.ExecuteNonQuery();
            load_data(picture_table, 5);
            clear();
            MessageBox.Show("Данные Обновлены");
        }

        

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void count2_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list4_l_Click(object sender, EventArgs e)
        {

        }
    }
}
