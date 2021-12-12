#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c41e992d2d0418edaab146d69b546acfdd137a"
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
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
using FlightManagementBlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Flights</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
                                OpenAddFlightPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus\"></span>\r\n    Add Flight\r\n");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
 if(Flights == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div>Loading...</div>");
#nullable restore
#line 15 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Number</th>\r\n                <th>Date</th>\r\n                <th>Time</th>\r\n                <th>Carrier</th>\r\n                <th>Airport to</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 29 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
             foreach(var flight in Flights)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
#nullable restore
#line 32 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(11, flight.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 33 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(14, flight.FlightDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 34 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(17, flight.FlightTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 35 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(20, flight.Carrier);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 36 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(23, flight.AirportTo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                        () => DeleteFlight(flight.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                        () => ArchiveFlight(flight.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-transfer\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Bojan\Desktop\AirportSystem_Lecture5_Start\FlightManagementBlazorServer\Pages\FlightList.razor"
       
    private List<Flight> Flights;
    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetFlights();
    }

    private void OpenAddFlightPage()
    {
        _navigationManager.NavigateTo("/AddFlight");
    }

    private async Task DeleteFlight(int flightId)
    {
        await _flightService.DeleteFlight(flightId);
    }

    private async Task ArchiveFlight(int flightId)
    {
        await _flightService.ArchiveFlight(flightId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
    }
}
#pragma warning restore 1591
