#pragma checksum "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Components\TopLeaders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70a449a24d95439cf721eb11920b507ade357a41"
// <auto-generated/>
#pragma warning disable 1591
namespace EnQ_Admin.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.API.Leaders;

#line default
#line hidden
#nullable disable
    public partial class TopLeaders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Tabs>(0);
            __builder.AddAttribute(1, "SelectedTab", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Components\TopLeaders.razor"
                    selectedTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "SelectedTabChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 1 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Components\TopLeaders.razor"
                                                      OnSelectedTabChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "w-100 d-flex justify-content-around align-items-center flex-row");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, "<div class=\"col-md-3\">\r\n                <a href=\"home\" class=\"badge badge-light\">Back to Home</a>\r\n            </div>\r\n            ");
                __builder2.AddMarkupContent(9, "<span class=\"col-md-6 text-center badge badge-light\">Top Public Contributors</span>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "d-flex justify-content-center align-items-center flex-row col-md-3");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Blazorise.Tab>(13);
                __builder2.AddAttribute(14, "Name", "today");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.AddMarkupContent(17, "<span class=\"badge badge-light\">Today</span>\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Blazorise.Tab>(19);
                __builder2.AddAttribute(20, "Name", "thisweek");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n                    ");
                    __builder3.AddMarkupContent(23, "<span class=\"badge badge-light\">This Week</span>\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
            }
            ));
            __builder.AddAttribute(27, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<Blazorise.TabPanel>(29);
                __builder2.AddAttribute(30, "Name", "today");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "d-flex justify-content-center align-items-center flex-column");
                    __builder3.AddMarkupContent(35, "\r\n                ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddMarkupContent(37, "\r\n                    ");
                    __builder3.OpenComponent<EnQ_Admin.Components.MainLeaders>(38);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n                ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "width: 100%");
                    __builder3.AddMarkupContent(43, "\r\n                    ");
                    __builder3.OpenComponent<EnQ_Admin.Components.BottomLeaders>(44);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenComponent<Blazorise.TabPanel>(49);
                __builder2.AddAttribute(50, "Name", "thisweek");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "d-flex justify-content-center align-items-center flex-column");
                    __builder3.AddMarkupContent(55, "\r\n                ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddMarkupContent(57, "\r\n                    ");
                    __builder3.OpenComponent<EnQ_Admin.Components.MainLeaders>(58);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "style", "width: 100%");
                    __builder3.AddMarkupContent(63, "\r\n                    ");
                    __builder3.OpenComponent<EnQ_Admin.Components.BottomLeaders>(64);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Components\TopLeaders.razor"
       
    string selectedTab = "today";

    private void OnSelectedTabChanged( string name )
    {
        selectedTab = name;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
