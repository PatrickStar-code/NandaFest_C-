using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace NandaFest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


       

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_txt_Click(object sender, EventArgs e)
        {
            login_txt.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            senha_txt.BackColor = SystemColors.Control;
        }

        private void senha_txt_Click(object sender, EventArgs e)
        {
            senha_txt.BackColor = Color.White;
            panel4.BackColor = Color.White;
            login_txt.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            senha_txt.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            senha_txt.UseSystemPasswordChar = true;
        }

        private void logar_btn_Click(object sender, EventArgs e)
        {
            string login = login_txt.Text;
            string senha = senha_txt.Text;
            if (login != "" && senha != "")
            {
                try
                {

                    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=fest;";
                    string sql = "SELECT * FROM gestores WHERE login_gestor = @login_gestor and senha_gestor = @senha_gestor";

                    //A variável databaseConnection define uma string para conexão com o BD.
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);


                    MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
                    commandDatabase.Parameters.Clear();

                    MySqlDataReader reader;

                    commandDatabase.Parameters.AddWithValue("@login_gestor",
                    login_txt.Text);
                    commandDatabase.Parameters.AddWithValue("@senha_gestor",
                  senha_txt.Text);
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login Realizado com sucesso");
                        this.Hide();
                        Aplication home = new Aplication();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha Incorretos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Prencha todos os dados");
            }
        }
    }
}
