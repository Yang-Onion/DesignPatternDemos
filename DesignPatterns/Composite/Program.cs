using Composite.Sample;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Composite root = new Sample.Composite("系统配置");

            Sample.Composite sysConfig = new Sample.Composite("系统设置");

            Sample.Composite menu = new Sample.Composite("菜单设置");
            sysConfig.Add(menu);

            sysConfig.Add(new Leaf("角色设置"));
            sysConfig.Add(new Leaf("用户管理"));
            sysConfig.Add(new Leaf("基础配置"));

            Sample.Composite businessData = new Sample.Composite("上线初始");
            businessData.Add(new Leaf("主数据导入"));
            businessData.Add(new Leaf("库存数据导入"));
            businessData.Add(new Leaf("未清订单导入"));

            Sample.Composite useData = new Sample.Composite("占用数据");
            useData.Add(new Leaf("库区占用"));
            useData.Add(new Leaf("库位占用"));

            menu.Add(businessData);
            menu.Add(useData);

            root.Add(sysConfig);

            Sample.Composite orgConfig = new Sample.Composite("机构配置");
            orgConfig.Add(new Leaf("组织机构"));
            orgConfig.Add(new Leaf("公司信息"));
            orgConfig.Add(new Leaf("人员信息"));

            root.Add(orgConfig);

            root.Add(new Leaf("接口管理"));

            root.Display(1);



            Console.Read();
        }
    }
}
