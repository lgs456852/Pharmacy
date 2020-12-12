using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pharmacyFrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyFrm
{
    public partial class LoginFrm : Form
    {
        public static Common.DataMode DM;
        int a = 0;

        public LoginFrm()
        {
            InitializeComponent();
            DM = new Common.DataMode();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }
        public async Task<User_Info> Login(string id, string pass)
        {
            User_Info u = null;
            JArray j = await DM.OpenAsync($"SELECT * FROM user_info WHERE id = '{id}' AND pass = '{pass}'");
            if (j == null || j.Count == 0)
            {
                a = 0;
            }
            else
            {
                a = 1;
                //로그인 성공
                try
                {
                    u = JsonConvert.DeserializeObject<List<User_Info>>(j.ToString())[0];
                }
                catch (Exception e)
                {
                    Console.WriteLine("pharmacy.Common.UserInfo.Login:" + e.ToString());
                }
            }
            return u;
        }

        public bool isLogin
        {
            get
            {
                if (a == 0)
                {
                    return false;
                }
                return true;
            }
        }



        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IDbox.Text.Equals(""))
            {
                MessageBox.Show("ID를 입력해주세요", "IDError");
            }
            else if (PassBox.Text.Equals(""))
            {
                MessageBox.Show("Password 를 입력해주세요. ", "PassError");
            }
            else
            {
                await Login(IDbox.Text, PassBox.Text);

                if (isLogin)
                {
                    MessageBox.Show("로그인 성공", "Succ");
                    this.Visible = false;
                    MainForm mainFrm = new MainForm();
                    mainFrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("로그인 실패", "Error");
                }
            }
        }

        private void LoginFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
