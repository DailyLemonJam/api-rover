using APIRover.UIComponents.WorkingArea.ContentArea;
using System.Windows.Controls;

namespace APIRover.UIComponents.WorkingArea;

public partial class WorkingAreaUC : UserControl
{
    public WorkingAreaUC()
    {
        InitializeComponent();
        FrameContentArea.Content = new ContentPage();
    }
}
