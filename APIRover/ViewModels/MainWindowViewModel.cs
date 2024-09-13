using APIRover.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace APIRover.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly MainWindowModel _model;

    public MainWindowViewModel(MainWindowModel model)
    {
        _model = model;
    }
}
