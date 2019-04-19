using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Client
{
    public class ShellViewModel : Prism.Mvvm.BindableBase
    {
        public ShellViewModel(IRegionManager rm,IEventAggregator ea)
        {
            _rm = rm;
            #region 加载列表
            ea.GetEvent<Models.Events.RegisterMenuEvent>().Subscribe(s =>
            {
                ModuleList.Add(new Menu_Module
                {
                    IconName = s.IconName,
                    ModuleNmae = s.MenuName,
                    PageName = s.PageName,
                });
            });
            #endregion

            #region 模块选择命令
            ModuleChangedCommand = new DelegateCommand<string>(p=>
            {
                if (p == null) return;
                rm.RequestNavigate("主tab", p);
                NaviIndex = -1;
            });
            #endregion

            #region 关闭tabItem命令
            CloseTabItemCommadn = new DelegateCommand<object>(P=>
            {
                _rm.Regions["主tab"].Remove(P);
            });
            #endregion
        }

        public class Menu_Module
        {
            public string IconName { get; set; }
            public string PageName { get; set; }
            public string ModuleNmae { get; set; }
        }
        #region 属性
        private ObservableCollection<Menu_Module> _ModuleList = new ObservableCollection<Menu_Module>();
        private IRegionManager _rm;

        /// <summary>
        /// 模块列表
        /// </summary>
        public ObservableCollection<Menu_Module> ModuleList
        {
            get { return _ModuleList; }
            set
            {
                _ModuleList = value;
                RaisePropertyChanged("ModuleList");
            }
        }

        private int _NaviIndex;
        /// <summary>
        /// 导航选中
        /// </summary>
        public int NaviIndex
        {
            get { return _NaviIndex; }
            set { this.SetProperty(ref _NaviIndex, value); }
        }


        #endregion

        #region 命令

        /// <summary>
        /// 模块选择命令
        /// </summary>
        public ICommand ModuleChangedCommand { get; set; }

        /// <summary>
        /// 关闭tabItem命令
        /// </summary>
        public ICommand CloseTabItemCommadn { get; set; }
        #endregion
    }
}
