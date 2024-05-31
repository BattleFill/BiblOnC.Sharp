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
using LibDataClean;

namespace BiblOnC.Sharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SerializeToJson_Click(object sender, RoutedEventArgs e)
        {
            var data = new Person { Name = "John", Age = 30 };
            var filePath = "data.json";

            DataClean.SerializeToJson(data, filePath);
            MessageBox.Show("Data serialized to JSON");
        }

        private void DeserializeFromJson_Click(object sender, RoutedEventArgs e)
        {
            var filePath = "data.json";

            var data = DataClean.DeserializeFromJson<Person>(filePath);
            MessageBox.Show($"Deserialized from JSON: Name = {data.Name}, Age = {data.Age}");
        }

        private void SerializeToXml_Click(object sender, RoutedEventArgs e)
        {
            var data = new Person { Name = "John", Age = 30 };
            var filePath = "data.xml";

            DataClean.SerializeToXml(data, filePath);
            MessageBox.Show("Data serialized to XML");
        }

        private void DeserializeFromXml_Click(object sender, RoutedEventArgs e)
        {
            var filePath = "data.xml";

            var data = DataClean.DeserializeFromXml<Person>(filePath);
            MessageBox.Show($"Deserialized from XML: Name = {data.Name}, Age = {data.Age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
