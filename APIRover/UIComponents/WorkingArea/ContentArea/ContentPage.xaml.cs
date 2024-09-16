using APIRover.Enums;
using System.Windows.Controls;

namespace APIRover.UIComponents.WorkingArea.ContentArea;

public partial class ContentPage : Page
{
    public ContentPage()
    {
        InitializeComponent();
        HttpMethodCB.ItemsSource = Enum.GetValues(typeof(HttpMethodType)).Cast<HttpMethodType>().ToList();
        HttpMethodCB.SelectedIndex = 0;
    }
}
