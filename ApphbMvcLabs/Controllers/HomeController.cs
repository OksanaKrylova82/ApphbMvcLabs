using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApphbMvcLabs.Code;
using ApphbMvcLabs.Models.Home;

namespace ApphbMvcLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var markdownBuilder = new Markdown();
            const string markdownContent = @"
Lorem ipsum dolor sit amet
==========================

Lorem ipsum dolor sit amet
--------------------------

Сonsectetur *adipiscing* elit. Vestibulum semper, ante sed varius fringilla, tortor felis tempor eros, non dictum dolor ipsum non justo.
In hac [habitasse platea](http://www.google.com) dictumst. Curabitur libero sapien, commodo at felis quis, dictum imperdiet lorem.
Mauris id turpis eget odio malesuada tempus. Duis fringilla nec augue sit amet hendrerit. In hac habitasse platea dictumst.

Vestibulum semper:
* ante
* sed
* varius

Nulla quis **feugiat** tortor. Nunc cursus ante ac mi ultricies vulputate. Donec bibendum at ipsum vel facilisis.
Curabitur `adipiscing` nisi ac neque pulvinar consectetur. Nam vitae commodo dolor. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. 
Integer volutpat orci quis felis blandit, vitae faucibus est rutrum. In facilisis, odio in aliquam gravida, lacus elit molestie est, in venenatis eros eros eget odio.
Etiam congue consequat ipsum, eget vulputate velit hendrerit ut. Nam rutrum id ante ut mollis.

Pellentesque habitant:
1. morbi
2. tristique
3. senectus";

            var posts = new List<PostModel>
            {
                new PostModel
                {
                    Title = "Lorem ipsum dolor",
                    DateTime = new DateTime(2014, 1, 1),
                    UserEmail = "loremipsum@example.com",
                    Content = markdownBuilder.Transform(markdownContent)
                },

                new PostModel
                {
                    Title = "Aenean vulputate",
                    DateTime = new DateTime(2014, 2, 2),
                    UserEmail = "aeneanvulputate@example.com",
                    Content = markdownBuilder.Transform(markdownContent)
                },

                new PostModel
                {
                    Title = "Vestibulum justo nulla",
                    DateTime = new DateTime(2014, 3, 3),
                    UserEmail = "vestibulumjusto@example.com",
                    Content = markdownBuilder.Transform(markdownContent)
                },
            };
            return View(posts);
        }
    }
}