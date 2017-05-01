using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgStat
{
    public partial class PgStatMainForm : Form
    {
        private PgWorker _pgWorker;
        private bool _isConnected;

        public PgStatMainForm()
        {
            InitializeComponent();
            SetDoubleBuffered(ResultDataGridView, true);
            _isConnected = false;
            ReadXmlQueries();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectButton.Enabled = false;
            if (!_isConnected)
            {
                ConnectDb();
            }
            else
            {
                DisconnectDb();
            }
            ConnectButton.Enabled = true;
        }

        private void DisconnectDb()
        {
            _pgWorker?.Dispose();
            ConnectButton.Text = "Подключить";
            ResultsGroupBox.Enabled = false;
            _isConnected = false;
        }

        private void ConnectDb()
        {
            _pgWorker = new PgWorker(ServerTextBox.Text, PortTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text, DbTextBox.Text);
            if (!_pgWorker.IsConnected) return;
            ConnectButton.Text = "Отключить";
            ResultsGroupBox.Enabled = true;
            _isConnected = true;
        }

        private void GetResultButton_Click(object sender, EventArgs e)
        {
            _pgWorker.GetData(QueriesComboBox.SelectedValue.ToString(), ResultDataGridView);
        }

        private void ReadXmlQueries()
        {
            QueriesDataSet.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "queries.xml");
            QueriesComboBox.DataSource = QueriesDataSet;
            QueriesComboBox.DisplayMember = "query.name";
            QueriesComboBox.ValueMember = "query.command";
        }

        private void SetDoubleBuffered(Control c, bool value)
        {
            PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(c, value, null);
        }
    }
}
