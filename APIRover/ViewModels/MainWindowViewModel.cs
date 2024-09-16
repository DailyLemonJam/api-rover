using APIRover.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace APIRover.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    private readonly MainWindowModel _model;

    public MainWindowViewModel(MainWindowModel model)
    {
        _model = model;
    }

    [RelayCommand]
    public void SendHttpRequest()
    {
        // 1.Get params from CommandParameter in UC
        // or
        // 2. Write service that grabs everything needed by itself (from here)
        _model.HandleHttpRequest();
    }
}
