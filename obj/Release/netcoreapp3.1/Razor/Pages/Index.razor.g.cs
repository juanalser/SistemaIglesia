#pragma checksum "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4226429114b866034001fa2d2e337012c44db454"
// <auto-generated/>
#pragma warning disable 1591
namespace TareaIglesia.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"text-black-50 text-center\"> Bienvenido al registro de hermanos</h2>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n<img src=\"./depositphotos_87264650-stock-illustration-church-logo-cross-and-bible.jpg\" style=\"margin:0 auto;\" class=\"embed-responsive\">\r\n\r\n\r\n\r\n</div>\r\n");
            __builder.OpenElement(2, "footer");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "href", "/Formulario");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<button href=\"/Formulario\" type=\"button\" style=\"font:bold\" class=\" form-control\">Pasar al formulario</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591