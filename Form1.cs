using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace Covid_19
{
    public partial class Form1 : Form
    {
        private class CountryCode
        {
            public string Country { get; set; }
            public string Slug { get; set; }
            public string ISO2 { get; set; }
        }

        private class Covid19
        {
            public DateTime Date { get; set; }
            public int Confirmed { get; set; }
            public int Deaths { get; set; }
            public int Recovered { get; set; }
            public int Active { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listCountry();

            chart_Covid19.Series.Clear();
            chart_Covid19.Series.Add("Confirmed").YValueMembers = "Confirmed";
            chart_Covid19.Series.Add("Deaths").YValueMembers = "Deaths";
            chart_Covid19.Series.Add("Recovered").YValueMembers = "Recovered";
            chart_Covid19.Series.Add("Active").YValueMembers = "Active";

            chart_Covid19.ChartAreas["Covid-19Area"].AxisX.LabelStyle.Font = new Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular);
            chart_Covid19.ChartAreas["Covid-19Area"].AxisY.LabelStyle.Font = new Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular);
            chart_Covid19.Legends[0].Font = new Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular);

            chart_Covid19.ChartAreas["Covid-19Area"].AxisY.LabelStyle.Format = "#,###";            
        }
        private void listCountry()
        {
            string baseAddress = "https://api.covid19api.com/countries";
            var httpClient = new HttpClient() { BaseAddress = new Uri(baseAddress) };
            List<CountryCode> countries = Task.Run(() => httpClient.GetFromJsonAsync<List<CountryCode>>("")).Result;
            countries.Add(new CountryCode { Country = "", Slug = "", ISO2 = "" });

            comboBox_Country.DataSource = countries;
            comboBox_Country.ValueMember = "Slug";
            comboBox_Country.DisplayMember = "Country";

            comboBox_Country.SelectedIndex = 0;

        }
        private void listChart(string slug)
        {
            string baseAddress = String.Format("https://api.covid19api.com/total/country/{0}", slug);
            var httpClient = new HttpClient() { BaseAddress = new Uri(baseAddress) };
            List<Covid19> allStatus = Task.Run(() => httpClient.GetFromJsonAsync<List<Covid19>>("")).Result;

            chart_Covid19.DataSource = allStatus;

            foreach (Series series in chart_Covid19.Series)
            {
                series.ChartType = SeriesChartType.Line;
                series.YValueType = ChartValueType.Int32;
                
                series.XValueMember = "Date";
                series.XValueType = ChartValueType.DateTime;
            }
            
            chart_Covid19.DataBind();

            dataGridView_Covid19.DataSource = new BindingSource(allStatus, null);

            DataGridViewCellStyle numberCellStye = new DataGridViewCellStyle();
            numberCellStye.Format = "#,##0";
            numberCellStye.Alignment = DataGridViewContentAlignment.MiddleRight;

            for (int i = 1; i <= 4; i++)
            {
                dataGridView_Covid19.Columns[i].DefaultCellStyle = numberCellStye;
            }
        }

        private void comboBox_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string slug = ((CountryCode)comboBox_Country.SelectedItem).Slug.ToString();
            //string fromDate = "2020-01-01T00:00:00Z";
            //string toDate = String.Format("{0}T00:00:00Z", DateTime.UtcNow.ToString("yyyy-MM-dd"));
            Form1.ActiveForm.Text = String.Format("Covid-19 Status by Country - {0}", ((CountryCode)comboBox_Country.SelectedItem).Country.ToString());
            listChart(slug);
        }        
    }
}
