using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Viselitsa.View.Pages;

namespace Viselitsa.ViewModel
{
    internal partial class EndGameViewModel: ObservableObject
    {
        public EndGameViewModel() { }

        [RelayCommand]
        private void Exit()
        {
            Shell.Current.GoToAsync("//" + nameof(MainPage));
        }
    }
}
