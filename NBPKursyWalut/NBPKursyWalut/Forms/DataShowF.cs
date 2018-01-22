using NBPKursyWalut.Data.Defs;
using NBPKursyWalut.Waluta.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBPKursyWalut.Forms
{
    public partial class DataShowF : Form
    {
        DataSet _dataSet = null;
        WalutaTableUC _walutaTableUC = null;

        public DataShowF(DataSet p_dataSet, DownloadType p_downloadType, string p_caption)
        {
            InitializeComponent();

            _dataSet = p_dataSet;
            this.Text = p_caption + p_dataSet.Tables[0].Rows[0]["Table"];
            switch (p_downloadType)
            {
                case DownloadType.CURRENCY_TABLE:
                    _walutaTableUC = new WalutaTableUC(p_dataSet);
                    _walutaTableUC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    _walutaTableUC.AutoSize = true;
                    _walutaTableUC.Dock = DockStyle.Fill;
                    UcViewFieldGB.Controls.Add(_walutaTableUC);
                    UcViewFieldGB.Text = p_caption +
                        p_dataSet.Tables[0].Rows[0]["Table"] +
                        " numer " + p_dataSet.Tables[0].Rows[0]["No"] +
                        " z dnia " + p_dataSet.Tables[0].Rows[0]["EffectiveDate"];
                    break;
                default:
                    break;
            }
        }
    }
}
