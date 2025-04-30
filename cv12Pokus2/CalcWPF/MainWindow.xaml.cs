using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using CalcApi;

namespace CalcWPF
{

    public partial class MainWindow : Window
    {
        private static readonly HttpClient _client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            _client.BaseAddress = new Uri("https://localhost:7272/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {

                decimal operand1 = decimal.Parse(Operand1TextBox.Text);
                decimal operand2 = decimal.Parse(Operand2TextBox.Text);
                string operation = ((ComboBoxItem)OperationComboBox.SelectedItem).Content.ToString();


                CalcDTO calcDTO = new CalcDTO
                {
                    Operand1 = operand1,
                    Operand2 = operand2,
                    Operation = operation
                };

    
                HttpResponseMessage response = await _client.PostAsJsonAsync("api/calc", calcDTO);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();
                ResultTextBlock.Text = $"Výsledek: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba: {ex.Message}", "Chyba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}