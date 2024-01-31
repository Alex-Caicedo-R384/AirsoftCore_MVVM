using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftMAUI.MVVM.ViewModels
{
    
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
            
        }
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]
        string tittle;
        public bool IsNotBusy => !IsBusy;
    }
}
