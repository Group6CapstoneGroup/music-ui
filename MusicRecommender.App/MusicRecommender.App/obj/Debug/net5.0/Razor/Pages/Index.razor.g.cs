#pragma checksum "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "342e9240d287c4b3fb8fd49661a1af74f6a6ab87"
// <auto-generated/>
#pragma warning disable 1591
namespace MusicRecommender.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using MusicRecommender.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\_Imports.razor"
using MusicRecommender.App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "<head><style>\r\n        button {\r\n            border-radius: 12px;\r\n            background-color: #C2248B;\r\n            border: none;\r\n            padding: 10px;\r\n            color: white;\r\n        }\r\n    </style></head>\r\n");
            __builder.OpenElement(2, "body");
            __builder.AddMarkupContent(3, "<div><img src=\"./sample-data/Soundwave.PNG\" height=\"125\" width=\"650\"></div>\r\n    ");
            __builder.AddMarkupContent(4, @"<div><h4>Find new music instantly!</h4>
        <p>
            With hundreds of thousands of song to browse from update your library today!
            Whether it's to keep you motivated during a workout or just to freshen up your
            playlist we are here to help!
        </p></div>
    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\Pages\Index.razor"
                       LoginNavigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Log in");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\Pages\Index.razor"
                       SignUpNavigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Sign up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\MiMcGraw\source\repos\music-ui\MusicRecommender.App\MusicRecommender.App\Pages\Index.razor"
      
    void LoginNavigate()
    {
        UriHelper.NavigateTo("/login");
    }
    void SignUpNavigate()
    {
        UriHelper.NavigateTo("/signup");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
