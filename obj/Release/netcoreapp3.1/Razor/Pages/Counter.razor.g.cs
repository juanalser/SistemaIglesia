#pragma checksum "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30581a3624420ecc9959f020f6e6f087e34d3904"
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
#line 11 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
using TareaIglesia.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
using TareaIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
using TareaIglesia.Componentes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Formulario")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<h2 id=\"header_3\" class=\"form-check card-header text-center\" data-component=\"header\">\r\n            Formulario\r\n        </h2>\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "text-center");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
                __builder2.AddAttribute(8, "href", "Form");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n                ");
                    __builder3.AddMarkupContent(11, "<button class=\"form-control\" type=\"button\"> Ingresar Hermano</button>\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(14, "<label class=\"text-black-50\"> Buscar</label>\r\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "search");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                    Filter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "table");
                __builder2.AddAttribute(21, "class", "table");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, @"<thead>
                <tr>
                    <th>Foto</th>
                    <th>Nombre</th>
                    <th>Apellido</th>

                    <th>Fecha</th>
                    <th>Editar</th>
                    <th>Eliminar</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(24, "tbody");
                __builder2.AddMarkupContent(25, "\r\n");
#nullable restore
#line 38 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                 if (iglesia.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                     foreach (Iglesia T in iglesia)
                    {
                        if (!IsVisible(T))
                            continue;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                         if (T.foto != null)
                        {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "                            ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __builder2.OpenElement(29, "td");
                __builder2.OpenElement(30, "img");
                __builder2.AddAttribute(31, "src", 
#nullable restore
#line 48 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                              string.Format("data:image/jpg;base64, {0}", Convert.ToBase64String(getImage(Convert.ToBase64String(T.foto))))

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "width", "80");
                __builder2.AddAttribute(33, "height", "90");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 49 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                     T.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 50 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                     T.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                                ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 52 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                     T.FechaDeNacimiento.Day

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(43, " / ");
                __builder2.AddContent(44, 
#nullable restore
#line 52 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                                                T.FechaDeNacimiento.Month

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(45, "/ ");
                __builder2.AddContent(46, 
#nullable restore
#line 52 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                                                                            T.FechaDeNacimiento.Year

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "td");
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "href", "/EdForm/" + (
#nullable restore
#line 53 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                                      T.HermanoID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                                                             (() => SetHermanoUpdate(T))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "<i>Editar</i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.OpenElement(54, "td");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "class", "bg-danger");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                                                                        (() => DeleteHermano(T))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "X");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 56 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                         

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n\r\n    ");
            }
            ));
            __builder.AddAttribute(64, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(66, "<h3 class=\"text-black-50 text-center\">Bienvenido</h3>\r\n        ");
                __builder2.AddMarkupContent(67, "<p class=\"text-center\">Para poder visualizar el contenido debe de<a href=\"Identity/Account/Login\"> iniciar sesion</a> o si no dispones de una cuenta puedes registrarte en <a href=\"Identity/Account/Register\"> este enlace</a></p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Counter.razor"
      
    public string Filter { get; set; }

    string NombrePersona = string.Empty;
    List<Iglesia> iglesia = new List<Iglesia>();

    public Iglesia iglesiahermano { get; set; } = new Iglesia();

    protected override async Task OnInitializedAsync()
    {

        await Refreshiglesia();
    }
    private async Task Refreshiglesia()
    {
        iglesia = await service.GetHermanoAsync();
    }

    Iglesia iglesiaupdt = new Iglesia();
    private void SetHermanoUpdate(Iglesia iglesia)
    {
        iglesiaupdt = iglesia;
    }
    private async Task UpdateProductData()
    {

        await service.UpdateHermanoAsync(iglesiaupdt);
        await Refreshiglesia();
    }
    private async Task DeleteHermano(Iglesia iglesia)
    {
        if (await JSruntime.InvokeAsync<bool>("confirm", "Seguro que desea eliminar este hermano"))
        {
            await service.DeleteHermanoAsync(iglesia);
            await Refreshiglesia();
        }

    }

    private async Task ListarHermano()
    {
        await service.ListarHermanosAsync(NombrePersona);
        await Refreshiglesia();
    }


    public byte[] getImage(string sBase64String)
    {
        byte[] bytes = null;
        if (sBase64String != null)
        {
            bytes = Convert.FromBase64String(sBase64String);
        }

        return bytes;
    }

    public bool IsVisible(Iglesia iglesia)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;



        if (iglesia.HermanoID.ToString().StartsWith(Filter) || iglesia.Nombre.ToString().StartsWith(Filter))
            return true;

        return false;
    }

    /*
        [Parameter]
        public Guid Uid { get; set; }
        [Parameter]
        public EventCallback ChangeRL { get; set; }



        Iglesia ModalT = new Iglesia();

        private string modalId = "CrudModal";


        private void SetModal(Iglesia t)
        {
            ModalT = t;
        }
        protected override async Task OnParametersSetAsync()
        {
            await Load();
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //if(firstRender)
            StateHasChanged();
            await Load();
        }

        private async Task Load()
        {
            if (Uid != null)
                iglesia = iglesia = await service.GetHermanoAsync();
        }
    */

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IglesiaServices service { get; set; }
    }
}
#pragma warning restore 1591