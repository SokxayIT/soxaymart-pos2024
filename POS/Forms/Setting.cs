using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.Server;
            txtDBName.Text = Properties.Settings.Default.DBName;
            txtPass.Text = Properties.Settings.Default.Pass;
            txtUser.Text = Properties.Settings.Default.Users;
            txtstore.Text = Properties.Settings.Default.storeID.ToString();
            txtpoint.Text = Properties.Settings.Default.storePoint.ToString();
            txteuser.Text = Properties.Settings.Default.e_usernaem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = string.Format("Data Source={0};Initial Catalog={1}; User ID = {2}; Password ={3};", txtServer.Text, txtDBName.Text,txtUser.Text,txtPass.Text);
            try
            {
                SqlHelper hp = new SqlHelper(connString);
                if (hp.IsConnection)
                {
                    Appsetting settings = new Appsetting();
                    settings.SaveConnectionString("POS.Properties.Settings.RMSConnectionString", connString);
                    Properties.Settings.Default.Server = txtServer.Text;
                    Properties.Settings.Default.DBName = txtDBName.Text;
                    Properties.Settings.Default.Users = txtUser.Text;
                    Properties.Settings.Default.Pass = txtPass.Text;
                    Properties.Settings.Default.storePoint = decimal.Parse(txtpoint.Text);
                    Properties.Settings.Default.storeID = int.Parse(txtstore.Text);
                    Properties.Settings.Default.clockseq= 0;
                    Properties.Settings.Default.e_usernaem= txteuser.Text;
                    Properties.Settings.Default.clock = true;
                    Properties.Settings.Default.Save();
                    FrmDialogOK.Show("Your connection string has been succesfully saved", "Message");
                }
            }
            catch (Exception ex)
            {
                FrmDialogOK.Show(ex.Message, "Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = string.Format("Data Source={0};Initial Catalog={1}; User ID = {2}; Password ={3};", txtServer.Text, txtDBName.Text, txtUser.Text, txtPass.Text);
            try
            {
                SqlHelper hp = new SqlHelper(connString);
                if (hp.IsConnection)
                {
                    FrmDialogOK.Show("Connected to server", "Message");
                }
            }
            catch (Exception ex)
            {
                FrmDialogOK.Show(ex.Message, "Message");
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Appsetting
    {
        Configuration config;
        public Appsetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
    public class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string conn)
        {
            cn = new SqlConnection(conn);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
