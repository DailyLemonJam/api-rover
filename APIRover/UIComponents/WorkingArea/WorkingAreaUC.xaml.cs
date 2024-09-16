using APIRover.Enums;
using System.Windows.Controls;

namespace APIRover.UIComponents.WorkingArea;

public partial class WorkingAreaUC : UserControl
{
    public WorkingAreaUC()
    {
        InitializeComponent();
        HttpMethodCB.ItemsSource = Enum.GetValues(typeof(HttpMethod)).Cast<HttpMethod>().ToList();
        HttpMethodCB.SelectedIndex = 0;
    }
}
