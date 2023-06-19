using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http.Headers;

namespace Домашня_робота
{
    public partial class Form1 : Form
    {
        string fileName;
        DataTable dt = null;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;

        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionToStorageDB"].ConnectionString);
        }

        private void LoadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Graphics File|*.png; *.jpg; *.jpeg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadPicture();
            }
        }

        private void ShowOneButton_Click(object sender, EventArgs e)
        {
            if(ProductSerialNumberTextBox.Text != string.Empty && Int32.TryParse(ProductSerialNumberTextBox.Text, out int number) && number > 0)
            {
                MemoryStream ms = null;
                byte[] bytes;

                if (dt == null) dt = new DataTable();
                else dt.Clear();

                try
                {
                    adapter = new SqlDataAdapter("select Picture from ProductsPictures where Id = @id", conn);
                    adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = number;
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                    adapter.Fill(dt);

                    bytes = (byte[])dt.Rows[0]["Picture"];
                    ms = new MemoryStream(bytes);
                    StorageProductsPictureBox.Image = Image.FromStream(ms);

                    StorageDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода данных в строку!");
                ProductSerialNumberTextBox.Clear();
                ProductSerialNumberTextBox.Focus();
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            StorageProductsPictureBox.Image = null;

            if (dt == null) dt = new DataTable();
            else dt.Clear();

            adapter = adapter ?? new SqlDataAdapter();

            try
            {
                adapter.SelectCommand = new SqlCommand(@"select Pr.Name as Provider, Pr.Phone,
                                                         P.Name as Product, P.Quantity, P.CostPrice as Price, P.DeliveryDate as [Delivery Date],
                                                         PP.Picture as [Product Image]
                                                         from Providers as Pr join Products as P
                                                         on Pr.Id = P.ProviderId
                                                         join ProductsPictures as PP
                                                         on P.Id = PP.ProductId", conn);

                adapter.Fill(dt);
                StorageDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPicture()
        {
            try
            {
                byte[] bytes = CreateCopy();

                conn.Open();
                SqlCommand comm = new SqlCommand("insert into ProductsPictures(Id, Picture, ProductId) values (@id, @picture, @productid);", conn);

                if (ProductSerialNumberTextBox.Text == null || ProductSerialNumberTextBox.Text.Length == 0) return;

                int index = -1;
                int.TryParse(ProductSerialNumberTextBox.Text, out index);

                if (index < 0) return;

                comm.Parameters.Add("@id", SqlDbType.Int).Value = index;
                comm.Parameters.Add("@productid", SqlDbType.Int).Value = index;
                comm.Parameters.Add("@picture", SqlDbType.Image, bytes.Length).Value = bytes;
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
        private byte[] CreateCopy()
        {
            Image img = Image.FromFile(fileName);

            int maxWidth = 100;
            int maxHeight = 100;

            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);

            Image mi = new Bitmap(newWidth, newHeight);
            //рисунок в памяти
            Graphics g = Graphics.FromImage(mi);
            MemoryStream ms = new MemoryStream();
            BinaryReader br = new BinaryReader(ms);

            g.DrawImage(img, 0, 0, newWidth, newHeight);
            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();//выносим в поток все данные из буфера
            ms.Seek(0, SeekOrigin.Begin);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }
    }
}
