using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CodeQuery.Postman.UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<RequestViewModel> Requests { get; } = [];

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
    private string? _newRequestUrl;

    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewRequestUrl);

    [RelayCommand(CanExecute = nameof(CanAddItem))]
    private void AddItem()
    {
        Requests.Add(new RequestViewModel { Name = NewRequestUrl! });
        NewRequestUrl = null;
    }

    [RelayCommand]
    private void RemoveItem(RequestViewModel item)
    {
        Requests.Remove(item);
    }
}