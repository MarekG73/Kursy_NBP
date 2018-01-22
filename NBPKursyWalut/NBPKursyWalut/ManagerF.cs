using System;
using System.Data;
using System.Windows.Forms;
using System.Net;
using NBPKursyWalut.Forms;
using NBPKursyWalut.Data.Defs;

namespace NBPKursyWalut
{
    public partial class ManagerF : Form
    {
        private Connection _connection = null;
        private WebResponse _response = null;
        private DataManager _dataManager = null;
        private DataSet _xmlData = null;
        private DataShowF _dataShowF = null; 
        private string _message = string.Empty;

        public ManagerF()
        {
            InitializeComponent();
            Prepare();
        }
        private void Prepare()
        {
            _dataManager = new DataManager();
        }
        /// <summary>
        /// Głowna funkcja zarządzająca
        /// </summary>
        /// <param name="p_category">Rodzaj pobrania</param>
        /// <param name="p_type">Typ pobrania</param>
        private void Manager(string p_category, string p_type)
        {
            DownloadType downloadType = DownloadType.NONE;
            // Połączenie
            _connection = new Connection();
            // Wynik zapytania
            _response = _connection.Connect(p_category, p_type);

            if (_response != null)
            {
                // Zapisanie wyniku w dataset 
                _xmlData = _dataManager.SetData(_response);

                if (p_category == "tables")
                {
                    downloadType = DownloadType.CURRENCY_TABLE;
                    _message = "Tabela " + p_type + " pobrana";
                    
                }
                // Pokazanie wyniku w oddzielnym oknie
                _dataShowF = new DataShowF(_xmlData, downloadType, "Tabela kursów walut ");
                _dataShowF.Show();
            }
            else
            {
                _message = "Wystąpił błąd połaczenia z serwisem";
            }
        }

        private void PobierzTabelaA_Button_Click(object sender, EventArgs e)
        {
            Manager("tables", "A");
            StatusTabA_TextBox.Text = _message;
        }
        private void PobierzTabelaB_Button_Click(object sender, EventArgs e)
        {
            Manager("tables", "B");
            StatusTabB_TextBox.Text = _message;
        }
        private void PobierzTabelaC_Button_Click(object sender, EventArgs e)
        {
            Manager("tables", "C");
            StatusTabC_TextBox.Text = _message;
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

