#pragma checksum "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e99821cc28d945c6113c5a70a9011984ee0685"
// <auto-generated/>
#pragma warning disable 1591
namespace TareaIglesia.Componentes
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
#nullable restore
#line 1 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
using TareaIglesia.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class DatosPersonales : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "<h2 id=\"header_3\" class=\"form-header\" data-component=\"header\">\r\n            Datos Personales\r\n        </h2>\r\n        ");
            __builder.OpenElement(2, "label");
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "form-line");
            __builder.AddAttribute(5, "data-type", "control_dropdown");
            __builder.AddMarkupContent(6, "<label>Apellidos</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "name", "Apellido");
            __builder.AddAttribute(10, "id", "Apellido");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                                        iglesiahermano.Apellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Apellido = __value, iglesiahermano.Apellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "form-line");
            __builder.AddAttribute(17, "data-type", "control_dropdown");
            __builder.AddMarkupContent(18, "<label>Nombres</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "name", "Nombre");
            __builder.AddAttribute(22, "id", "Nombre");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                                    iglesiahermano.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Nombre = __value, iglesiahermano.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "form-line");
            __builder.AddAttribute(29, "data-type", "control_dropdown");
            __builder.AddMarkupContent(30, "<label>Sexo</label>\r\n            ");
            __builder.OpenElement(31, "label");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "radio");
            __builder.AddAttribute(34, "value", "Si");
            __builder.AddAttribute(35, "name", "group");
            __builder.AddAttribute(36, "checked", 
#nullable restore
#line 28 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                  Sexo == "Hombre"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                   () => Sexo = "Hombre"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "Hombre\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "label");
            __builder.OpenElement(41, "label");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "radio");
            __builder.AddAttribute(44, "value", "Si");
            __builder.AddAttribute(45, "name", "group");
            __builder.AddAttribute(46, "checked", 
#nullable restore
#line 34 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                      Sexo == "Mujer"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                       () => Sexo = "Mujer"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "Mujer\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                 if (Sexo == "Hombre")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "style", "visibility:hidden");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                  iglesiahermano.Sexo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Sexo = __value, iglesiahermano.Sexo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                    iglesiahermano.Sexo = "Hombre";
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                 if (Sexo == "Mujer")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "style", "visibility:hidden");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                  iglesiahermano.Sexo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Sexo = __value, iglesiahermano.Sexo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                    iglesiahermano.Sexo = "Hombre";
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "form-line");
            __builder.AddAttribute(60, "data-type", "control_dropdown");
            __builder.AddMarkupContent(61, "<label>Fecha de Nacimiento</label>\r\n            ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "required", true);
            __builder.AddAttribute(64, "type", "date");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                                                           GetUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "name", "fecha");
            __builder.AddAttribute(67, "id", "fecha");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                               iglesiahermano.FechaDeNacimiento

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.FechaDeNacimiento = __value, iglesiahermano.FechaDeNacimiento, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "form-line");
            __builder.AddAttribute(74, "data-type", "control_dropdown");
            __builder.AddMarkupContent(75, "<br>\r\n            ");
            __builder.AddMarkupContent(76, "<label>Pais de Nacimiento</label>\r\n            <br>\r\n            ");
            __builder.OpenElement(77, "select");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                iglesiahermano.PaisNacimiento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.PaisNacimiento = __value, iglesiahermano.PaisNacimiento));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(81, "option");
            __builder.AddContent(82, " --Selecciona--");
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                 foreach (var user in Users)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", 
#nullable restore
#line 63 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                    user.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, 
#nullable restore
#line 63 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                user.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "form-line");
            __builder.AddAttribute(89, "data-type", "control_dropdown");
            __builder.AddMarkupContent(90, "<label> Ciudad de Nacimiento </label>\r\n            <br>\r\n            ");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "required", true);
            __builder.AddAttribute(93, "type", "text");
            __builder.AddAttribute(94, "id", "input_8");
            __builder.AddAttribute(95, "name", "q8_ciudadDe");
            __builder.AddAttribute(96, "data-type", "input-textbox");
            __builder.AddAttribute(97, "class", "form-textbox");
            __builder.AddAttribute(98, "style", "width:310px");
            __builder.AddAttribute(99, "size", "310");
            __builder.AddAttribute(100, "data-component", "textbox");
            __builder.AddAttribute(101, "aria-labelledby", "label_8");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                               iglesiahermano.CiudadNacimiento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.CiudadNacimiento = __value, iglesiahermano.CiudadNacimiento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.OpenElement(105, "li");
            __builder.AddAttribute(106, "class", "form-line");
            __builder.AddAttribute(107, "data-type", "control_dropdown");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "id", "cid_9");
            __builder.AddAttribute(110, "class", "form-input");
            __builder.AddAttribute(111, "data-layout", "half");
            __builder.AddMarkupContent(112, "<label>Pais de residencia actual</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(113, "select");
            __builder.AddAttribute(114, "class", "form-control");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                    iglesiahermano.PaisActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.PaisActual = __value, iglesiahermano.PaisActual));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(117, "option");
            __builder.AddContent(118, " --Selecciona--");
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                     foreach (var user in Users)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(119, "option");
            __builder.AddAttribute(120, "value", 
#nullable restore
#line 80 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                        user.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(121, 
#nullable restore
#line 80 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                    user.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "li");
            __builder.AddAttribute(124, "class", "form-line");
            __builder.AddAttribute(125, "data-type", "control_textbox");
            __builder.AddMarkupContent(126, "<label class=\"form-label form-label-right form-label-auto\" id=\"label_10\" for=\"input_10\"> Ciudad de residencia actual </label>\r\n            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "id", "cid_10");
            __builder.AddAttribute(129, "class", "form-input");
            __builder.AddAttribute(130, "data-layout", "half");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "type", "text");
            __builder.AddAttribute(133, "id", "input_10");
            __builder.AddAttribute(134, "name", "q10_ciudadDe10");
            __builder.AddAttribute(135, "data-type", "input-textbox");
            __builder.AddAttribute(136, "class", "form-textbox");
            __builder.AddAttribute(137, "style", "width:310px");
            __builder.AddAttribute(138, "size", "310");
            __builder.AddAttribute(139, "data-component", "textbox");
            __builder.AddAttribute(140, "aria-labelledby", "label_10");
            __builder.AddAttribute(141, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                        iglesiahermano.CiudadActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.CiudadActual = __value, iglesiahermano.CiudadActual));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n        ");
            __builder.OpenElement(144, "li");
            __builder.AddAttribute(145, "class", "form-line");
            __builder.AddAttribute(146, "data-type", "control_textarea");
            __builder.AddMarkupContent(147, "<label> Dirección (Provincia / sector / calle / No. de vivienda) </label>\r\n            ");
            __builder.OpenElement(148, "div");
            __builder.AddAttribute(149, "id", "cid_11");
            __builder.AddAttribute(150, "class", "form-input");
            __builder.AddAttribute(151, "data-layout", "full");
            __builder.OpenElement(152, "textarea");
            __builder.AddAttribute(153, "class", "form-textarea");
            __builder.AddAttribute(154, "style", "width:648px;height:163px");
            __builder.AddAttribute(155, "data-component", "textarea");
            __builder.AddAttribute(156, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                       iglesiahermano.Direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Direccion = __value, iglesiahermano.Direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "li");
            __builder.AddAttribute(160, "class", "form-line");
            __builder.AddAttribute(161, "data-type", "control_textbox");
            __builder.AddMarkupContent(162, "<label> Teléfono: </label>\r\n            ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "form-input");
            __builder.AddAttribute(165, "data-layout", "half");
            __builder.OpenElement(166, "input");
            __builder.AddAttribute(167, "type", "text");
            __builder.AddAttribute(168, "class", "form-textbox");
            __builder.AddAttribute(169, "style", "width:310px");
            __builder.AddAttribute(170, "size", "310");
            __builder.AddAttribute(171, "data-component", "textbox");
            __builder.AddAttribute(172, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          iglesiahermano.Telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(173, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Telefono = __value, iglesiahermano.Telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n        ");
            __builder.OpenElement(175, "li");
            __builder.AddAttribute(176, "class", "form-line");
            __builder.AddAttribute(177, "data-type", "control_textbox");
            __builder.AddMarkupContent(178, "<label class=\"form-label form-label-right form-label-auto\"> Celular: </label>\r\n            ");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "form-input");
            __builder.AddAttribute(181, "data-layout", "half");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "text");
            __builder.AddAttribute(184, "data-type", "input-textbox");
            __builder.AddAttribute(185, "class", "form-textbox");
            __builder.AddAttribute(186, "style", "width:310px");
            __builder.AddAttribute(187, "size", "310");
            __builder.AddAttribute(188, "data-component", "textbox");
            __builder.AddAttribute(189, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          iglesiahermano.Celular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(190, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Celular = __value, iglesiahermano.Celular));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n        ");
            __builder.OpenElement(192, "li");
            __builder.AddAttribute(193, "class", "form-line");
            __builder.AddAttribute(194, "data-type", "control_textbox");
            __builder.AddMarkupContent(195, "<label class=\"form-label form-label-right form-label-auto\"> Correo electrónico: </label>\r\n            ");
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "form-input");
            __builder.AddAttribute(198, "data-layout", "half");
            __builder.OpenElement(199, "input");
            __builder.AddAttribute(200, "type", "text");
            __builder.AddAttribute(201, "data-type", "input-textbox");
            __builder.AddAttribute(202, "class", "form-textbox");
            __builder.AddAttribute(203, "style", "width:310px");
            __builder.AddAttribute(204, "size", "310");
            __builder.AddAttribute(205, "data-component", "textbox");
            __builder.AddAttribute(206, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          iglesiahermano.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(207, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => iglesiahermano.Email = __value, iglesiahermano.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n        ");
            __builder.OpenElement(209, "li");
            __builder.AddAttribute(210, "class", "form-line");
            __builder.AddAttribute(211, "data-type", "control_radio");
            __builder.AddMarkupContent(212, "<label class=\"form-label form-label-right form-label-auto\"> Tipo de Documento de identidad: </label>\r\n            ");
            __builder.OpenElement(213, "div");
            __builder.AddAttribute(214, "class", "form-input");
            __builder.AddAttribute(215, "data-layout", "full");
            __builder.OpenElement(216, "div");
            __builder.AddAttribute(217, "class", "form-single-column");
            __builder.AddAttribute(218, "role", "group");
            __builder.AddAttribute(219, "data-component", "radio");
            __builder.OpenElement(220, "label");
            __builder.OpenElement(221, "input");
            __builder.AddAttribute(222, "type", "radio");
            __builder.AddAttribute(223, "value", "Si");
            __builder.AddAttribute(224, "name", "group");
            __builder.AddAttribute(225, "checked", 
#nullable restore
#line 121 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          TpDocumento == "Cédula"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(226, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                           () => TpDocumento = "Cédula"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "Cédula\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n                    ");
            __builder.OpenElement(229, "label");
            __builder.OpenElement(230, "input");
            __builder.AddAttribute(231, "type", "radio");
            __builder.AddAttribute(232, "value", "Si");
            __builder.AddAttribute(233, "name", "group");
            __builder.AddAttribute(234, "checked", 
#nullable restore
#line 126 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          TpDocumento == "Pasaporte"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(235, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                           () => TpDocumento = "Pasaporte"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "Pasaporte\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n                    ");
            __builder.OpenElement(238, "label");
            __builder.OpenElement(239, "input");
            __builder.AddAttribute(240, "type", "radio");
            __builder.AddAttribute(241, "value", "Si");
            __builder.AddAttribute(242, "name", "group");
            __builder.AddAttribute(243, "checked", 
#nullable restore
#line 131 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                          TpDocumento == "DNI"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(244, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 132 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                           () => TpDocumento = "DNI"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(245, "DNI\r\n\r\n");
#nullable restore
#line 134 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                         if (TpDocumento == "Cédula")
                        {
                            iglesiahermano.TipoDocumentoIDentidad = "Cédula";
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                         if (TpDocumento == "Pasaporte")
                        {
                            iglesiahermano.Sexo = "Pasaporte";
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                         if (TpDocumento == "DNI")
                        {
                            iglesiahermano.Sexo = "DNI";
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\r\n\r\n        ");
            __builder.OpenElement(247, "div");
            __builder.AddAttribute(248, "class", "text-center p-3 mb-3");
            __builder.OpenElement(249, "button");
            __builder.AddAttribute(250, "class", "btn btn-info");
            __builder.AddAttribute(251, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 152 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
                                                   AddNewHermano

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(252, " Agregar Persona");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Componentes\DatosPersonales.razor"
       

    //Llenar select
    List<Content> Users = new List<Content>();

    private async void GetUser()
    {
        var apiName = "https://raw.githubusercontent.com/millan2993/countries/master/json/countries.json";
        var httpResponse = await client.GetAsync(apiName);
        if (httpResponse.IsSuccessStatusCode)
        {
            Response responseData = JsonConvert.DeserializeObject<Response>(await httpResponse.Content.ReadAsStringAsync());
            Users = responseData.countries;
            StateHasChanged();
        }
    }

    public class Content
    {
        [JsonProperty("id")]
        public string id { get; set; } = "";
        [JsonProperty("name")]
        public string name { get; set; } = "";
    }
    public class Response
    {
        [JsonProperty("countries")]
        public List<Content> countries { get; set; }


    }
//
    List<Iglesia> iglesia = new List<Iglesia>();
     public Iglesia iglesiahermano { get; set; } = new Iglesia();

    string Sexo;
    string TpDocumento;

    protected override async Task OnInitializedAsync()
    {
        await Refreshiglesia();
    }
    private async Task Refreshiglesia()
    {
        iglesia = await service.GetHermanoAsync();
    }
   
    private async Task AddNewHermano()
    {
        await service.AddHermanoAsync(iglesiahermano);
        iglesiahermano = new Iglesia();
        await Refreshiglesia();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IglesiaServices service { get; set; }
    }
}
#pragma warning restore 1591