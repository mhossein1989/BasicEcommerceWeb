#pragma checksum "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde6ea024958dd4fc2215eafb44f0496108ab31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
using SadeghiBasicMarket.Application.Services.Queries.GetCategories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde6ea024958dd4fc2215eafb44f0496108ab31a", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriesDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/categories/addnewcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminThemeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Zero configuration table -->
        <section id=""configuration"">

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""card-title-wrap bar-success"">
                                <h4 class=""card-title"">لیست دسته بندی ها</h4>
                            </div>
                        </div>
                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">دسته بندی محصولات فروشگاه</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde6ea024958dd4fc2215eafb44f0496108ab31a5105", async() => {
                WriteLiteral("افزودن دسته بندی جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""دسته بندی: activate to sort column descending"" style=""width: 222px;"">دسته بندی</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""پدر: activate to sort column descending"" style=""width: 222px;"">پ");
            WriteLiteral(@"در</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label="": activate to sort column descending"" style=""width: 222px;""></th>

                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 39 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td class=\"sorting_1\">");
#nullable restore
#line 42 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n");
#nullable restore
#line 44 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                              
                                                                string parent = item.Parent != null ? item.Parent.name : "-";
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <text> ");
#nullable restore
#line 48 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                          Write(parent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </text>\r\n                                                    </td>\r\n");
#nullable restore
#line 50 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                      if (item.HasChild == true)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n");
            WriteLiteral("\r\n                                                       \r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde6ea024958dd4fc2215eafb44f0496108ab31a10203", async() => {
                WriteLiteral("مشاهده لیست فرزند ها ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3981, "~/admin/categories/index?ParentId=", 3981, 34, true);
#nullable restore
#line 59 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 4015, item.Id, 4015, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        \r\n\r\n                                                    </td>\r\n");
#nullable restore
#line 63 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde6ea024958dd4fc2215eafb44f0496108ab31a12392", async() => {
                WriteLiteral("افزودن فرزند");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4367, "~/admin/categories/addnewcategory?ParentId=", 4367, 43, true);
#nullable restore
#line 65 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 4410, item.Id, 4410, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                 foreach(var subItem in item.SubCategories){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                    <td> ");
#nullable restore
#line 70 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                    Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                                     <td>                                                      \r\n                                                         ");
#nullable restore
#line 72 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                    Write(subItem.Parent.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";                                                      
                                                   </td>
                                                                         <td>                                                       
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde6ea024958dd4fc2215eafb44f0496108ab31a15710", async() => {
                WriteLiteral("مشاهده لیست فرزند ها ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5318, "~/admin/categories/index?ParentId=", 5318, 34, true);
#nullable restore
#line 75 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 5352, subItem.Id, 5352, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                                                        \r\n                                                    </td>\r\n                                                   <td>\r\n                                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde6ea024958dd4fc2215eafb44f0496108ab31a17618", async() => {
                WriteLiteral("افزودن فرزند");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5647, "~/admin/categories/addnewcategory?ParentId=", 5647, 43, true);
#nullable restore
#line 78 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 5690, subItem.Id, 5690, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Categories\Index.cshtml"
                                                 
                                            
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
    </div>
</div>

<script>
    $(document).ready(function() {
    $(""td"").click(function() {
        alert(""You clicked my <td>!"");
        //get <td> element values here!!??
    });
});​


</script>

    
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriesDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
