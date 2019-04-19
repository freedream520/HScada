using Module1.Views;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using HScada.PLCModule.Helper;
using HScada.PLCModule.Views;
using System.Collections.Generic;
using HScada.SystemElement.Model;

namespace Module1
{
    public class Module1Module : IModule
    {
        HBBFrameWorkHelper frameWorkHelper;
        public Module1Module(IContainerExtension ce)
        {
            frameWorkHelper = ce.Resolve<HBBFrameWorkHelper>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            List<MenuMes> menus = new List<MenuMes>();
            menus.Add(new MenuMes
            {
                IconName = "Entypo_Home",
                MenuName = "主控",
                PageName = "_01_Main",
                PageType = typeof(Views._01_Main)
            });

            menus.Add(new MenuMes
            {
                IconName = "Octicons_Tools",
                MenuName = "手动",
                PageName = "_02_Manual",
                PageType = typeof(Views._02_Manual)
            });

            menus.Add(new MenuMes
            {
                IconName = "Material_Settings",
                MenuName = "参数管理",
                PageName = "_03_parameter",
                PageType = typeof(Views._03_parameter)
            });

            menus.Add(new MenuMes
            {
                IconName = "Material_ChartAreaspline",
                MenuName = "趋势曲线",
                PageName = "_04_Chart",
                PageType = typeof(Views._04_Chart)
            });

            menus.Add(new MenuMes
            {
                IconName = "Material_History",
                MenuName = "历史数据",
                PageName = "_05_History",
                PageType = typeof(Views._05_History)
            });

            menus.Add(new MenuMes
            {
                IconName = "Material_VideoInputComponent",
                MenuName = "配方管理",
                PageName = "_06_recipt",
                PageType = typeof(Views._06_recipt)
            });

            menus.Add(new MenuMes
            {
                IconName = "Octicons_RepoClone",
                MenuName = "日志查看",
                PageName = "_07_log",
                PageType = typeof(Views._07_log)
            });

            menus.Add(new MenuMes
            {
                IconName = "Material_AlarmLight",
                MenuName = "报警记录",
                PageName = "_08_Alarm",
                PageType = typeof(Views._08_Alarm)
            });


            menus.Add(new MenuMes
            {
                IconName = "Material_TableEdit",
                MenuName = "PLC\n变量配置",
                PageName = "PlcConfigView",
                PageType = typeof(PlcConfigView)
            });

            frameWorkHelper.RegisterMenu(menus,typeof(Views._00_login));

        }


    }
}