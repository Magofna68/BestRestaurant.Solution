#pragma checksum "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be7ec46bd4557661ab0e0203f01e2436517c13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be7ec46bd4557661ab0e0203f01e2436517c13d", @"/Views/Restaurants/Delete.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
#nullable restore
#line 13 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/Admin/Desktop/Epicodus/week-10/BestRestaurant.Solution/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
