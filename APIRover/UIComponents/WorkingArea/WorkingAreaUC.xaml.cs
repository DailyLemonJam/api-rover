using APIRover.UIComponents.WorkingArea.ContentArea;
using System.Windows.Controls;

namespace APIRover.UIComponents.WorkingArea;

public partial class WorkingAreaUC : UserControl
{
    public WorkingAreaUC()
    {
        InitializeComponent();
        Loaded += (s, e) =>
        {
            // TODO load page info from Requests List (in ViewModel??)
            var page = new ContentPage
            {
                DataContext = ThisUC.DataContext
            };
            FrameContentArea.Content = page;
        };
    }
}
