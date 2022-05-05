using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public IhttpOpenservices httpOpenWeatherClient;
        public OpenWeather openWeather;
        public Iweatherservices weatherServices;
        List<OpenWeatherCities> cities;
        public Form1(IhttpOpenservices httpOpenWeatherClient, Iweatherservices weatherServices)
        {
            InitializeComponent();
            InitializeComponent();
            this.httpOpenWeatherClient = httpOpenWeatherClient;
            this.weatherServices = weatherServices;
            //cities = httpOpenWeatherClient.GetCities(Properties.Resources.);
            comboBox1.DataSource = cities.Select(x => x.Name).ToList();

            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();

            comboBox1.AutoCompleteCustomSource = cm;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
