using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FanSite.TagHelpers
{

    // Custom Tag Helper
    public class EmailTagHelper : TagHelper
    {
        private const string Domain = "contoso.com";

        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var address = MailTo + "@" + Domain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(address);
        }


    }
}
