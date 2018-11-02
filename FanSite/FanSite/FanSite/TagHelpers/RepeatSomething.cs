using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace FanSite.TagHelpers
{
    [HtmlTargetElement(Attributes = "repeat-content")]
    public class RepeatSomething : TagHelper
    {
        [HtmlAttributeName("repeat-content")]
        public int NumRepeat { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (NumRepeat <= 0)
            {
                return;
            }
            for (int i =0; i < NumRepeat; i++)
            {
                return;

            }
        }


    }
}
