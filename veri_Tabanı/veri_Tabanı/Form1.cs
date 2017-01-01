using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql bağlantısı için ekliyoruz.
 
namespace sql_baglanti
{
    public partial class Form1 : Form  www.ahmetcansever.com
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        
        void griddoldur()
    {
            con = new SqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
    }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
 
        private void button1_Click(object sender, EventArgs e) // Ekle butonu
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenci(ogrenci_no,ogrenci_ad,ogrenci_soyad,ogrenci_sehir) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
 
        private void button3_Click(object sender,EventArgs e)//GÜNCELLE BUTONU
        {
            cmd =newOleDbCommand();
            con.Open();
            cmd.Connection= con;
            cmd.CommandText="update ogrenci set ogrenci_ad='"+ textBox2.Text+"',ogrenci_soyad='"+ textBox3.Text+"',ogrenci_sehir='"+ textBox4.Text+"' where ogrenci_no="+textBox1.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
 
            }
 
         private void button4_Click(object sender,EventArgs e)//SİLME BUTONU
         {
            cmd =newOleDbCommand();
            con.Open();
            cmd.Connection= con;
            cmd.CommandText="delete from ogrenci where ogrenci_no="+textBox1.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
         }
}