using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1,name:"تاکسی",description:"درخواست تاکسی آنلاین برای سفرهای درون شهری",image:"project-1.jpg" ,client:"Snapp"),
                new Project(id:1,name:"پروژه قیر",description:"اتوماسیون درخواست و تحویل قیر به پروژه ها",image:"project-2.jpg",client:"ghir"),
                new Project(id:1,name:"علوم پزشکی",description:"اتوماسیون درخواست و تعمیر دانشگاه علوم پزشکی",image:"project-3.jpg",client:"Request"),
                new Project(id:1,name:"دیکسنری",description:"دیکشنری آنلاین برای جملات برزگ",image:"project-4.jpg",client:"Dic"),

            };
            return View("_Projects",projects);
        }

    }
}
