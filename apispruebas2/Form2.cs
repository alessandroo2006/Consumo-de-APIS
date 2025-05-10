using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apispruebas2
{
    public partial class Form2: Form
    {

        private const string apiKey = "TU_API_KEY"; // Reemplaza con tu clave de TheDogAPI
        private static readonly HttpClient httpClient = new HttpClient();
        public Form2()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string razaBuscar = txtRaza.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(razaBuscar))
            {
                MessageBox.Show("Por favor ingresa una raza de perro.");
                return;
            }

            try
            {
                string url = "https://api.thedogapi.com/v1/breeds";
                string json = await httpClient.GetStringAsync(url);
                var razas = JsonConvert.DeserializeObject<List<Raza>>(json);

                var raza = razas.FirstOrDefault(r => r.name.ToLower().Contains(razaBuscar));

                if (raza != null && !string.IsNullOrEmpty(raza.reference_image_id))
                {
                    string imgUrl = $"https://api.thedogapi.com/v1/images/{raza.reference_image_id}";
                    string imgJson = await httpClient.GetStringAsync(imgUrl);
                    var imagen = JsonConvert.DeserializeObject<Imagen>(imgJson);

                    picPerro.Load(imagen.url);
                }
                else
                {
                    MessageBox.Show("No se encontró esa raza.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        public class Raza
        {
            public string name { get; set; }
            public string reference_image_id { get; set; }
        }

        public class Imagen
        {
            public string url { get; set; }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRaza.Clear();
            picPerro.Image = null;
        }

        private void picPerro_Click(object sender, EventArgs e)
        {
            picPerro.Width = 300;
            picPerro.Height = 300;

        }
    }
    
}
