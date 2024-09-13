using APIRover.ViewModels;
using System.Windows;

namespace APIRover.Views;

public partial class MainWindowView : Window
{
    public MainWindowView(MainWindowViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
