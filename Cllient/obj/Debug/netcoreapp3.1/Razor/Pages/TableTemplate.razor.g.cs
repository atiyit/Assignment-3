#pragma checksum "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29ca25c663ca6a5f56cae7cbe46416c77addcd4"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yu\Desktop\Assignment2-main - 副本\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
    public partial class TableTemplate<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor"
             TableHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 8 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor"
         foreach (var item in Items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor"
                 RowTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 11 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\TableTemplate.razor"
       
    [Parameter]
    public RenderFragment TableHeader { get; set; }

    [Parameter]
    public RenderFragment<TItem> RowTemplate { get; set; }

    [Parameter]
    public IReadOnlyList<TItem> Items { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
