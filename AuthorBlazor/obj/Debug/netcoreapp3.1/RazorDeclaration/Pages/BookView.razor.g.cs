// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
