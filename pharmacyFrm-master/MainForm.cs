using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pharmacyFrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyFrm
{
    
    public partial class MainForm : Form
    {
        public static Common.DataMode DM;
        
        string addr = "";
        public MainForm()
        {
            DM = new Common.DataMode();
            InitializeComponent();

        }

        private bool bDrag;
        private Point startPos;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addr = "Junggu";
            label3.Text = addr;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addr = "Seogu";
            label3.Text = addr;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            addr = "Namgu";
            label3.Text = addr;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            addr = "Bukgu";
            label3.Text = addr;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addr = "Donggu";
            label3.Text = addr;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            addr = "Dalseogu";
            label3.Text = addr;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            addr = "Dalseonggun";
            label3.Text = addr;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            addr = "Suseonggu";
            label3.Text = addr;
        }

        async void guna2Button9_ClickAsync(object sender, EventArgs e)
        {

            NameBox.Clear();
            JArray j = await DM.OpenAsync($"SELECT * FROM {addr} WHERE address like '%{guna2TextBox1.Text}%' ");
           

            foreach (JObject jObject in j)

            {
                NameBox.Items.Add(jObject.GetValue("Name").ToString());
            }
        }

        private async void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebLoad();
           

            if (NameBox.SelectedItems.Count != 0)
            {
                int SelectRow = NameBox.SelectedItems[0].Index;
                string a = NameBox.Items[SelectRow].SubItems[0].Text;

                JArray j = await DM.OpenAsync($"SELECT * FROM {addr} WHERE Name = '{a}'");

                foreach(JObject i in j)
                {
                    NameTextbox.Text = i.GetValue("Name").ToString();
                    AddressTextBox.Text = i.GetValue("Address").ToString();
                    PhoneTextBox.Text = i.GetValue("Phone").ToString();
                    MonText.Text = i.GetValue("Mon").ToString();
                    TueText.Text = i.GetValue("Tue").ToString();
                    WedText.Text = i.GetValue("Wed").ToString();
                    ThuBox.Text = i.GetValue("Thu").ToString();
                    FriBox.Text = i.GetValue("Fri").ToString();
                    SatBox.Text = i.GetValue("Sat").ToString();
                    SunBox.Text = i.GetValue("Sun").ToString();
                    HoliBox.Text = i.GetValue("Holi").ToString();

                }

            }

           
            string address = AddressTextBox.Text;
            string name = NameTextbox.Text;
            object[] ps = new object[] { address, name };
            webBrowser1.Document.InvokeScript("address", ps);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 50, 50));
            Version ver = webBrowser1.Version;
            string name = webBrowser1.ProductName;
            string str = webBrowser1.ProductVersion;
            string html = "http://handfarm.kro.kr:8080/portfolio/kakaomap.html";
            webBrowser1.Navigate(html);
        }

        public void WebLoad()
        {
            
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && bDrag == false)
            {
                startPos.X = e.X;
                startPos.Y = e.Y;

                SetCapture(Handle);
                bDrag = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bDrag == true)
            {
                this.Left += e.X - startPos.X;
                this.Top += e.Y - startPos.Y;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bDrag == true)
            {
                ReleaseCapture();
                bDrag = false;
            }
        }
        [DllImport("user32")]
        public static extern IntPtr SetCapture(IntPtr hWnd);
        [DllImport("user32")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                     , int nTopRect
                                                     , int nRightRect
                                                     , int nBottomRect
                                                     , int nWidthEllipse
                                                     , int nHeightEllipse);

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
