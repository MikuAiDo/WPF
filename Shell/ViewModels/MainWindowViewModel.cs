using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.ViewModels
{
    internal class MainWindowViewModel:BindableBase
    {
        private string title="上位机开发";
        public string Title
        { 
            get { return title; } 
            set {  title = value;RaisePropertyChanged(); } 
        
        }
    }
}
