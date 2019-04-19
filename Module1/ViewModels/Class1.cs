using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.ViewModels
{
    public class Class1:Prism.Mvvm.BindableBase
    {
        private string _Test;
        /// <summary>
        /// 测试
        /// </summary>
        public string Test
        {
            get { return _Test; }
            set
            {
                _Test = value;
                RaisePropertyChanged();
            }
        }

        private DelegateCommand _TestCommand;
        public DelegateCommand TestCommand =>
            _TestCommand ?? (_TestCommand = new DelegateCommand(ExecuteTestCommand));
        /// <summary>
        /// 测试命令
        /// </summary>
        void ExecuteTestCommand()
        {
            Test += "123";
        }

    }
}
