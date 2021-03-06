#pragma checksum "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab6a480bc358fa8321591b50e427fdf0f21f231"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
using TareaIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
using TareaIglesia.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Form")]
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 794 "C:\Users\Juan Garcia\Tareaiglesia\Backup\TareaIglesia\Pages\Form.razor"
       
    bool cerrar = false;

    List<Content> Users = new List<Content>();
    private DateTime? selectedTime = DateTime.Now;
    public DateTime Min = new DateTime(1990, 1, 1, 8, 15, 0);
    public DateTime Max = new DateTime(2025, 1, 1, 19, 30, 45);

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
    string localDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace(' ', 'T');



    private async Task AddNewHermano()
    {
        {

            iglesiahermano.foto = _fileBytes;
            await service.AddHermanoAsync(iglesiahermano);
            iglesiahermano = new Iglesia();
            await Refreshiglesia();

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
    Iglesia i = new Iglesia();
    public Iglesia iglesiahermano { get; set; } = new Iglesia();
    string Expulsado;
    string Nivel;
    string Funcion;
    string disciplinado;
    string denominacion;
    string Sexo;
    string TpDocumento;
    string EstadoCiv;
    string Hijos;

    protected override async Task OnInitializedAsync()
    {
        await Refreshiglesia();
    }
    private async Task Refreshiglesia()
    {
        iglesia = await service.GetHermanoAsync();
    }




    IFileListEntry file = null;
    public byte[] _fileBytes = null;
    public int count = 0;

    public async Task HandleFileSelection(IFileListEntry[] files)
    {
        if (files.Count() > 0)
        {
            file = files.FirstOrDefault();
            using (var ms = new MemoryStream())
            {
                await file.Data.CopyToAsync(ms);
                _fileBytes = ms.ToArray();
            }
        }
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IglesiaServices service { get; set; }
    }
}
#pragma warning restore 1591
