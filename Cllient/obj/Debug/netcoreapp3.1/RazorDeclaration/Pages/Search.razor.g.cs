#pragma checksum "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf9c3075690e1f6099f555714a517174e72f1d0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\Search.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\Search.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\Search.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\Search.razor"
       
    private int minAge;
    private int maxAge;
    private string lastName;
    private string firstName;
    private string sex;
    List<Adult> result = new List<Adult>();
    private string message;
    private int count;
    
    public async Task search()
    {
        FileContext fileContext = new FileContext();
        IList<Adult> adults = fileContext.Adults;
        message = "";
        result.Clear();
        
        for (int i = 0; i < adults.Count; i++)
        {
            if (lastName ==null && firstName ==null)
            {
                if (adults[i].age >= minAge && adults[i].age <= maxAge && adults[i].sex == sex)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (lastName == null)
            {
                if (adults[i].age >= minAge && adults[i].age <= maxAge && adults[i].sex == sex && adults[i].firstName==firstName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (firstName == null)
            {
                if (adults[i].age >= minAge && adults[i].age <= maxAge && adults[i].sex == sex && adults[i].lastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else
            {
                if (adults[i].age >= minAge && adults[i].age <= maxAge && adults[i].sex == sex && adults[i].firstName==firstName && adults[i].lastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
           
        }
        Console.WriteLine("search!");
        if (result.Count == 0)
        {
            message = "No match!";
        }
        
       
        
    }
    
    public async Task clear()
    {
        result.Clear();
        message = "";
    }

   


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
