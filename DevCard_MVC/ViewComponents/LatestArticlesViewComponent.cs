using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;


namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"پروژه آموزش ام وی سی به زبان فارسی","کاملترین پکیج آموزشی","blog-post-thumb-1.jpg"),
                new Article(2,"پروژه آموزش Git & GitHub","کاملترین پکیج آموزشی","blog-post-thumb-2.jpg"),
                new Article(3,"پروژه آموزش Photo Shop","کاملترین پکیج آموزشی","blog-post-thumb-3.jpg"),
                new Article(4,"پروژه آموزش C#.net","کاملترین پکیج آموزشی","blog-post-thumb-4.jpg")

            };
            return View("_latestArticles",articles);
        }
    }
}
