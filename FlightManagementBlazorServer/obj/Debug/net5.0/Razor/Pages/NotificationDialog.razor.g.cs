#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef63cc6562cf252a8c89a2a845a3bfd1f9ca8b59"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
    public partial class NotificationDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"
 if(ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddAttribute(5, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.AddMarkupContent(14, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Confirmation</h5>\r\n              ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"
                                              CloseDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "data-dismiss", "modal");
            __builder.AddAttribute(20, "aria-label", "Close");
            __builder.AddMarkupContent(21, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "modal-body");
#nullable restore
#line 13 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"
__builder.AddContent(25, Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-footer");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"
                                              CloseDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddContent(33, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Bojan\Desktop\AirportSystem_Lecture9_Start\FlightManagementBlazorServer\Pages\NotificationDialog.razor"
       

    public bool ShowDialog{ get; set; }

    [Parameter]
    public string Description{ get; set; }

    public void Show()
    {
        ShowDialog = true;
        StateHasChanged();
    }

    private void CloseDialog()
    {
        ShowDialog = false;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
