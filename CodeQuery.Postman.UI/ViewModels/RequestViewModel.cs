using CodeQuery.Postman.UI.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CodeQuery.Postman.UI.ViewModels;

public partial class RequestViewModel: ViewModelBase
{
    private Request _request = null!;

    public RequestViewModel()
    {
    }

    public RequestViewModel(Request request)
    {
        _request = request;

        _name = request.Name;
        _method = request.Method.ToString();
        // TODO: Mapper for url.
        _url = request.Url.Raw;
    }

    [ObservableProperty]
    private string _name = null!;

    [ObservableProperty]
    private string _method = null!;

    [ObservableProperty]
    private string _url = null!;

    [ObservableProperty]
    private bool _isChecked;
}