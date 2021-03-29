#pragma checksum "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13dac50ee134444b703cda03445349a3064d55ec"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class BookView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Books</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by Title: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                                                    (arg) => FilterByTitle(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Filter by First Name: ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                                                         (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "\r\n    Filter by Last Name: ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                                                        (arg) => FilterByLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "width:150px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
 if (bookListToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
}
else if (!bookListToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>No books exist. Please add some.</em></p>");
#nullable restore
#line 29 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table");
            __builder.AddMarkupContent(25, "<thead><tr><th>ISBN</th>\r\n                <th>Title</th>\r\n                <th>Publication Year</th>\r\n                <th>Pages</th>\r\n                <th>Genre</th></tr></thead>\r\n        ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 43 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
             foreach (var item in bookListToShow)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 46 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                     item.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 47 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 48 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                     item.PublicationYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 49 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                     item.NumOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 50 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                     item.Genre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
                                        () => RemoveBook(item.ISBN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Nick\source\repos\279190-Exam-A20\AuthorBlazor\Pages\BookView.razor"
           
        private IList<Book> bookListToShow;
        private IList<Book> bookListAll;

        private string? filterByTitle;
        private string? filterByFirstName;
        private string? filterByLastName;

        protected override async Task OnInitializedAsync()
        {
            bookListAll = await CloudService.GetBooks();
            bookListToShow = bookListAll;
        }

        private async Task RemoveBook(int isbn)
        {
            Book bookToRemove = bookListToShow.First(b => b.ISBN == isbn);
            await CloudService.DeleteBook(isbn);
            bookListToShow.Remove(bookToRemove);
        }

        private void FilterByTitle(ChangeEventArgs changeEventArgs)
        {
            filterByTitle = null;
            filterByTitle = changeEventArgs.Value.ToString();
            bookListToShow = bookListAll.Where(e => (filterByTitle != null && e.Title.Equals(filterByTitle))).ToList();
        }

        private void FilterByFirstName(ChangeEventArgs changeEventArgs)
        {
            filterByTitle = null;
            filterByTitle = changeEventArgs.Value.ToString();
            bookListToShow = bookListAll.Where(e => (filterByTitle != null && e.Title.Equals(filterByTitle))).ToList();
        }

        private void FilterByLastName(ChangeEventArgs changeEventArgs)
        {
            filterByTitle = null;
            filterByTitle = changeEventArgs.Value.ToString();
            bookListToShow = bookListAll.Where(e => (filterByTitle != null && e.Title.Equals(filterByTitle))).ToList();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService CloudService { get; set; }
    }
}
#pragma warning restore 1591