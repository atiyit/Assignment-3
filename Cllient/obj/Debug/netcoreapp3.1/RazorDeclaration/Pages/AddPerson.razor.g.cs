#pragma checksum "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c90245c6345fcf64a57326806e9f0cd7a03e1efd"
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
#line 2 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor"
using System.Data.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManagerPerson")]
    public partial class AddPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\yu\Desktop\Assignment2-main - 副本\Pages\AddPerson.razor"
       
    private string firstname;
    private string lastname;
    private string sex = "M";
    private int age;
    private string hairColor="Blond";
    private string eyeColor="Brown";
    private int height;
    private float weight;
    private string message;
    private string job;

    public void setHair(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        hairColor = result;
    }

    public void setEye(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        eyeColor = result;
    }

    public void setSex(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        sex = result;
    }

    public async Task addPerson()
    {
        message = "";
        try
        {
            Person person = new Person();
            Adult adult = new Adult();
            FileContext fileContext = new FileContext();
            person.id = fileContext.Adults.Count;
            person.firstName = firstname;
            person.lastName = lastname;
            person.sex = sex;
            person.age = age;
            person.eyeColor = eyeColor;
            person.hairColor = hairColor;
            person.height = height;
            person.weight = weight;
            adult.jobTitle = job;
            adult.Update(person);
            fileContext.Adults.Add(adult);
            ClientModel.getInstance().addAdult(adult);
            fileContext.SaveChanges();
            message = "Add succeed!";
        }
        catch (Exception e)
        {
            message = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
