using DataAccess.Models;
using MVP1.Entity;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace MVCApps.CustomTagHelpers
{
    public class ListGenerator : TagHelper
    {
            public IEnumerable<Category> Categories { get; set; }
            public override void Process(TagHelperContext context, TagHelperOutput output)
            {
                // Custom Tag NAme
                output.TagName = "List";
                // Start and End Tag
                // <list-generator></list-generator>
                output.TagMode = TagMode.StartTagAndEndTag;
                // Define an HTML that will be generated
                var table = "<table class='table table-bordered table-striped table-dark'>";
                foreach (var item in Categories)
                {
                    table += $"<tr><td>{item.CategoryName}</td><td>{item.CategoryName}</td><td>{item.BasePrice}</td></tr>";

               
            }
                table += "</table>";


                // Add the Generated HTML in the HTML Output Stream
                // so that i will be shown in Browser when the View is loaded
                output.PreContent.SetHtmlContent(table);
            }
        }
    }



