using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NhaKhoa
{
    public partial class Login : Form
    {
        public string LoggedInRole { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private Account login(string username, string password)
        {
            string query = "SELECT UserName, Password, Role FROM Account WHERE UserName = @username AND Password = @password";

            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Account
                        {
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPassWord.Text;

            // Truy vấn DB
            string query = "SELECT Role FROM Account WHERE UserName = @user AND Password = @pass";
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    var role = cmd.ExecuteScalar() as string;

                    if (role != null)
                    {
                        LoggedInRole = role;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đóng toàn bộ ứng dụng
            Application.Exit();

            // HOẶC chỉ đóng form login (nếu form login là form đầu tiên):
            // this.Close();
        }
    }
}
