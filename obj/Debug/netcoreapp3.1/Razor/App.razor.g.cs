#pragma checksum "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3dafde8af06030ef2f3c1b581e81bcfa000f33"
// <auto-generated/>
#pragma warning disable 1591
namespace EnQ_admin
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
using EnQ_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.ThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Theme>(
#nullable restore
#line 2 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
                                 theme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(4);
                __builder2.AddAttribute(5, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 3 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(8);
                    __builder3.AddAttribute(9, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
                                   routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
                                                              typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(12, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(14);
                    __builder3.AddAttribute(15, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "\r\n                ");
                        __builder4.AddMarkupContent(18, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\App.razor"
       
    private Theme theme = new Theme
    {
        
    };
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
