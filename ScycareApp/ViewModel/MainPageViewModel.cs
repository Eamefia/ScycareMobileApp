using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScycareApp.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ICommand]
    async Task CreateAccount()
    {
        await Shell.Current.GoToAsync(nameof(VerifyCode));
    }
}
