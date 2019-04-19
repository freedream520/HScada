using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HScada.SystemElement.MVVM;

namespace Module1.ViewModels
{
    public class _01_MainViewModel : ViewModelBase
    {
        public _01_MainViewModel(IContainerExtension ce) : base(ce)
        {
        }
    }
}
