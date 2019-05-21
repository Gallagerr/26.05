using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace GameOfThrones
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ObservableCollection<Character> characters = new ObservableCollection<Character>();

    public MainWindow()
    {
      InitializeComponent();
      Map.Source = new Uri("https://2gis.ru/game_of_thrones?queryState=center%2F64.645615%2C17.368702%2Fzoom%2F14");
      string result;
      using (var client = new WebClient())
      {
        result = client.DownloadString("https://api.got.show/api/book/characters");
      }
      characters = JsonConvert.DeserializeObject<ObservableCollection<Character>>(result);
      listbox.ItemsSource = characters;
    }
     
    private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      Window1 window = new Window1();
      window.Show();
    }
  }
}
