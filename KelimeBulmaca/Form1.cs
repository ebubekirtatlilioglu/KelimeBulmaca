using System.Data.SqlClient;

namespace KelimeBulmaca
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            con = new SqlConnection("server=.; database=SozluklerDb; trusted_connection=true");
            con.Open();
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string harfler = txtHarfler.Text;
            Dictionary<char, int> harfSayi = GecmeSayilariniBul(harfler);
            string cmdText = "SELECT Sozcuk FROM TurkceSozluk WHERE Sozcuk NOT LIKE @p1 AND LEN(Sozcuk) <= @p2";

            foreach (var cift in harfSayi)
            {
                cmdText += $" AND LEN(Sozcuk) - LEN(REPLACE(Sozcuk, '{cift.Key}', '')) <= {cift.Value}";
            }
            cmdText += " ORDER BY LEN(Sozcuk), Sozcuk";
            var cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@p1", $"%[^{harfler}]%");
            cmd.Parameters.AddWithValue("@p2", harfler.Length);
            var dr = cmd.ExecuteReader();

            lstKelimeler.Items.Clear();
            while (dr.Read())
            {
                lstKelimeler.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private Dictionary<char, int> GecmeSayilariniBul(string harfler)
        {
            var sonuc = new Dictionary<char, int>();
            foreach (char harf in harfler)
            {
                if (sonuc.ContainsKey(harf))
                {
                    sonuc[harf]++;
                }
                else
                {
                    sonuc.Add(harf, 1);
                }
            }
            return sonuc;
        }

    
    }
}