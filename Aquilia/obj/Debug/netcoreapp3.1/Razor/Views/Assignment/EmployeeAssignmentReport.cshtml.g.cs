#pragma checksum "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76312b2ccdd0a8dc9f44c566520c5504ca98185a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignment_EmployeeAssignmentReport), @"mvc.1.0.view", @"/Views/Assignment/EmployeeAssignmentReport.cshtml")]
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
#line 1 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/_ViewImports.cshtml"
using Aquilia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/_ViewImports.cshtml"
using Aquilia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76312b2ccdd0a8dc9f44c566520c5504ca98185a", @"/Views/Assignment/EmployeeAssignmentReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cec2b7ae67ca9125b69c606d9b068cbed3d3938", @"/Views/_ViewImports.cshtml")]
    public class Views_Assignment_EmployeeAssignmentReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aquilia.Models.Assignment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectedAssignmentID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 500px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76312b2ccdd0a8dc9f44c566520c5504ca98185a4486", async() => {
                WriteLiteral(@"
    <link href=""Content/css/bootstrap.css"" rel=""stylesheet"" />
    <link href=""Content/css/bootstrap-theme.css"" rel=""stylesheet"" />

    <script type=""text/javascript"" src=""Content/js/jquery-3.2.1.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js""></script>
    <script type=""text/javascript"" src=""Content/js/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""Content/js/script.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76312b2ccdd0a8dc9f44c566520c5504ca98185a5956", async() => {
                WriteLiteral("\r\n    <div class=\"row\" style=\"margin-left:10px;\">\r\n        <div class=\"col-md-5\">\r\n            <h6>All Active Assignments:</h6>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76312b2ccdd0a8dc9f44c566520c5504ca98185a6363", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 19 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AssignmentID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 21 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.listofactiveassignments,"AssignmentID", "AssignmentName"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
           
            <br>
            <br> <label style=""margin-top:10px;"">Assignment Date: </label>
        </div>
      
        <div class=""col-md-1""> <input type=""button"" class=""btn btn-success"" value=""Search"" onclick=""EmployeeAssignments()"" style=""margin-top:25px;""></div>
        <div class=""col-md-1""> <button type=""reset"" class=""btn btn-danger"" style=""margin-top:25px;"">Cancel</button></div>

");
                WriteLiteral(@"    </div>
    <table id=""example"" class=""table table-striped table-bordered"" style=""width:97%; background-color:white; margin:20px;"">
        <thead>

            <tr>
                <th>Assigned Date</th>
                <th>Employee Name</th>
                <th>Final Product Name</th>
                <th>Assigned Product Name</th>
                <th>Assigned Product Code</th>
                <th>Assigned State</th>

            </tr>
        </thead>
        <tbody>


            <tfoot>
");
#nullable restore
#line 50 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                 if (Model != null)
                {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                                 foreach (var assignedemployees in Model.EmployeeAssignmentsViewModel)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.AssignedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.FinalProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.AssignedProductPart);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.ProductPartCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 60 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                       Write(assignedemployees.AssignmentState);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                                 
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tfoot>
    </table>
    <script>

        function EmployeeAssignments() {
            var transDate = $('#transactionDate').val();
            var As_ID = $('#selectedAssignmentID').val();
            window.location.href = '");
#nullable restore
#line 71 "/Users/Nischal/Desktop/AquiliaOriginal/Aquilia/Views/Assignment/EmployeeAssignmentReport.cshtml"
                               Write(Url.Action("DisplayAssignmentForEmployeeReport", "Assignment"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?As_ID=' + As_ID;
        }

        $(document).ready(function () {

    $('#example').DataTable();
    $(""#datepicker"").datepicker();
        });</script>

    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
    <script src=""js/scripts.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js"" crossorigin=""anonymous""></script>
    <script src=""assets/demo/chart-area-demo.js""></script>
    <script src=""assets/demo/chart-bar-demo.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js"" crossorigin=""anonymous""></script>
    <script src=""assets/demo/datatables-demo.js""></script>
    <script src=""js/bootstrap.min.js""></script>");
                WriteLiteral(@"

    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aquilia.Models.Assignment> Html { get; private set; }
    }
}
#pragma warning restore 1591
