using System;
using System.ComponentModel.DataAnnotations;

namespace ApphbMvcLabs.Models.Home
{
    public class PostModel
    {
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime DateTime { get; set; }

        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }        

        [DataType(DataType.Html)]
        public string Content { get; set; }
    }
}