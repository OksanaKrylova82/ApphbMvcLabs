using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApphbMvcLabs.Models.Home;

namespace ApphbMvcLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var posts = new List<PostModel>
            {
                new PostModel
                {
                    Title = "Lorem ipsum dolor",
                    DateTime = new DateTime(2014, 1, 1),
                    UserEmail = "loremipsum@example.com",
                    Content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum semper, ante sed varius fringilla, tortor felis tempor eros, non dictum dolor ipsum non justo. In hac habitasse platea dictumst. Curabitur libero sapien, commodo at felis quis, dictum imperdiet lorem. Mauris id turpis eget odio malesuada tempus. Duis fringilla nec augue sit amet hendrerit. In hac habitasse platea dictumst. Nulla quis feugiat tortor. Nunc cursus ante ac mi ultricies vulputate. Donec bibendum at ipsum vel facilisis. Curabitur adipiscing nisi ac neque pulvinar consectetur. Nam vitae commodo dolor. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer volutpat orci quis felis blandit, vitae faucibus est rutrum. In facilisis, odio in aliquam gravida, lacus elit molestie est, in venenatis eros eros eget odio. Etiam congue consequat ipsum, eget vulputate velit hendrerit ut. Nam rutrum id ante ut mollis.</p>"
                },

                new PostModel
                {
                    Title = "Aenean vulputate",
                    DateTime = new DateTime(2014, 2, 2),
                    UserEmail = "aeneanvulputate@example.com",
                    Content = "<p>Aenean vulputate, diam eget condimentum feugiat, lectus eros fringilla orci, nec fermentum nisl orci id libero. Fusce purus elit, lacinia vel pulvinar et, volutpat id nunc. Maecenas lacus sem, commodo eget purus ut, interdum ultricies metus. Fusce lacinia urna tortor, in sollicitudin neque pharetra bibendum. Aenean viverra sit amet tortor eget vestibulum. Integer id dui pulvinar, pretium mi id, sodales nisi. Suspendisse consectetur est sed convallis egestas. In pretium lorem sed quam tristique, ac blandit tortor condimentum. Phasellus tempor mauris eros, vitae faucibus tellus ornare dapibus. Etiam hendrerit mi in nisl congue, ut tristique quam euismod. Nam ac lorem sapien. Fusce sit amet mi in dui dignissim auctor. Nulla id augue id velit auctor cursus id eget libero.</p>"
                },

                new PostModel
                {
                    Title = "Vestibulum justo nulla",
                    DateTime = new DateTime(2014, 3, 3),
                    UserEmail = "vestibulumjusto@example.com",
                    Content = "<p>Vestibulum justo nulla, ornare vitae placerat eget, posuere ut augue. Curabitur luctus cursus nisi ornare tincidunt. Aenean consequat urna non neque rhoncus, sed rutrum metus mattis. Nam mollis nibh sed malesuada vulputate. Donec nec consequat diam, non condimentum quam. Mauris pretium ante quis vestibulum sodales. Ut sodales nisl non libero blandit dapibus.</p>"
                },
            };
            return View(posts);
        }
    }
}