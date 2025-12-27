using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Viselitsa.View.Pages;

namespace Viselitsa.ViewModel
{
    internal partial class MainPageViewModel: ObservableObject
    {
        [RelayCommand]
        private void GoToGamePage()
        {
            Shell.Current.GoToAsync(nameof(GamePage));
        }
    }
}
