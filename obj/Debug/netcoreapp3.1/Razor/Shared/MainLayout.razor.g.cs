#pragma checksum "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842a77835eb4461dd95867233e67ff51e5a92050"
// <auto-generated/>
#pragma warning disable 1591
namespace TareaIglesia.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using TareaIglesia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using TareaIglesia.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using TareaIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "top-row px-4 auth");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "font-weight-bolder dropleft");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "href", true);
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "href", "");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<img src=\"./images.png\" width=\"50\" height=\"50\">\r\n                    Inicio\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenComponent<TareaIglesia.Shared.LoginDisplay>(13);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddContent(17, 
#nullable restore
#line 20 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
