using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitOtomasyonu
{
    public partial class FrmOdalar : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=JUMBO;Initial Catalog=Pansiyon;Integrated Security=True;TrustServerCertificate=True");

        public FrmOdalar()
        {
            InitializeComponent();
            RenkAyarla();
        }
        private void RenkAyarla()
        {
            try
            {
                List<Button> OdaListesi = new List<Button>();
                List<bool> OdaListesiBool = new List<bool>();

                OdaListesi.Add(BtnOda101);
                OdaListesi.Add(BtnOda102);
                OdaListesi.Add(BtnOda103);
                OdaListesi.Add(BtnOda201);
                OdaListesi.Add(BtnOda202);
                OdaListesi.Add(BtnOda203);
                OdaListesi.Add(BtnOda301);
                OdaListesi.Add(BtnOda302);
                OdaListesi.Add(BtnOda303);
                OdaListesi.Add(BtnOda401);
                OdaListesi.Add(BtnOda402);
                OdaListesi.Add(BtnOda403);
                OdaListesi.Add(BtnOda501);
                OdaListesi.Add(BtnOda502);
                OdaListesi.Add(BtnOda503);


                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Oda101, Oda102, Oda103, Oda201, Oda202, Oda203, Oda301, Oda302, Oda303, Oda401, Oda402, Oda403, Oda501, Oda502, Oda503  FROM Odalar WHERE Id = 1", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();


                if (!reader.HasRows)
                {
                    MessageBox.Show("Veri yok!");
                }
                else
                {
                    if (reader.Read())
                    {
                        OdaListesiBool.Add(reader.GetBoolean(0));
                        OdaListesiBool.Add(reader.GetBoolean(1));
                        OdaListesiBool.Add(reader.GetBoolean(2));
                        OdaListesiBool.Add(reader.GetBoolean(3));
                        OdaListesiBool.Add(reader.GetBoolean(4));
                        OdaListesiBool.Add(reader.GetBoolean(5));
                        OdaListesiBool.Add(reader.GetBoolean(6));
                        OdaListesiBool.Add(reader.GetBoolean(7));
                        OdaListesiBool.Add(reader.GetBoolean(8));
                        OdaListesiBool.Add(reader.GetBoolean(9));
                        OdaListesiBool.Add(reader.GetBoolean(10));
                        OdaListesiBool.Add(reader.GetBoolean(11));
                        OdaListesiBool.Add(reader.GetBoolean(12));
                        OdaListesiBool.Add(reader.GetBoolean(13));
                        OdaListesiBool.Add(reader.GetBoolean(14));
                    }
                    else
                    {
                        MessageBox.Show("Veriler okunmadı!");
                    }


                    for (int i = 0; i < 15; i++)
                    {
                        OdaListesi[i].BackColor = (OdaListesiBool[i] == false) ? Color.LightGreen : Color.Red;
                    }

                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
