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
using MySql.Data.MySqlClient;


namespace wpclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "CREATE TABLE infoks";
            string Connect = "Database=hipsters_guru;Data Source=hipsters.mysql.ukraine.com.ua;User Id=hipsters_guru;Password=hipsters_guru";
            //Переменная Connect - это строка подключения в которой:
            //БАЗА - Имя базы в MySQL
            //ХОСТ - Имя или IP-адрес сервера (если локально то можно и localhost)
            //ПОЛЬЗОВАТЕЛЬ - Имя пользователя MySQL
            //ПАРОЛЬ - говорит само за себя - пароль пользователя БД MySQL
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open(); //Устанавливаем соединение с базой данных.
            MyCommand.ExecuteNonQuery();                   //Что то делаем...
            myConnection.Close(); //Обязательно закрываем соединение!

        }
    }
}
