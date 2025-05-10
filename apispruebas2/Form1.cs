using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apispruebas2
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private HttpClient client = new HttpClient(); 
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string pokemonName = txtNombrePoke.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {

                client.DefaultRequestHeaders.Add("live_6tkTtWrEHBxo0s9ilABLnSlAwcNBrfQXH322FBsRC3tbgXcC5o4kkN8Ul7Q4NOor", "");

                string response = await client.GetStringAsync(url);
                JObject data = JObject.Parse(response);

                lblNombrePoke.Text = $"{data["name"].ToString()}";
                lblPesoPoke.Text = $"{data["weight"]}";
                lblAlturaPoke.Text = $"{data["height"]}";
                string imagenUrl = data["sprites"]["front_default"].ToString();
                pictureBox1.Load(imagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro encontar el pokemon que pides , revisa si existe y buscalo de nuevo, suerte (;!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            txtNombrePoke.Clear();
           
            lblNombrePoke.Text = string.Empty;
            lblPesoPoke.Text = string.Empty;
            lblAlturaPoke.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNombrePoke.Text) ||
               string.IsNullOrWhiteSpace(lblPesoPoke.Text) ||
               string.IsNullOrWhiteSpace(lblAlturaPoke.Text))
            {
                MessageBox.Show("No hay datos para exportar. Realiza una búsqueda primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string datos = $"Nombre: {lblNombrePoke.Text}\n" +
                           $"Peso: {lblPesoPoke.Text}\n" +
                           $"Altura: {lblAlturaPoke.Text}";

            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "datos_exportados.txt");
            File.WriteAllText(rutaArchivo, datos);
            MessageBox.Show($"Datos exportados correctamente a: {rutaArchivo}");


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
