#pragma checksum "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf00b673b573d6e1d7de6e651307cbfb3f72a3f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorManagementCentral.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorManagementCentral.Shared.Navbar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.AddContent(2, 
#nullable restore
#line 4 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\MainLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
