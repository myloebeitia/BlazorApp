// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Schiavello.Pages
{
    #line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Schiavello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\_Imports.razor"
using Schiavello.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\Pages\ToDo.razor"
using Schiavello.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\Pages\ToDo.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\Pages\ToDo.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Xceler8\source\repos\Schiavello\Schiavello\Pages\ToDo.razor"
       

    List<List> Lists = new List<List>();

    Boolean Sort;

    protected override async Task OnInitializedAsync()
    {
        await RefreshLists();
    }

    private async Task RefreshLists()
    {
        Lists = await service.GetListAsync();
    }

    private async Task RefreshListsSorted(Boolean Sort)
    {
        Lists = await service.SortListAsync(Sort);

    }

    private async Task SortList()
    {
        //await service.RefreshListsSorted(Sort);

        await RefreshListsSorted(Sort);
        Sort = Sort == true ? false : true;
    }


    public List NewList { get; set; } = new List();

    private async Task AddNewList()
    {
        await service.AddListAsync(NewList);
        NewList = new List();
        await RefreshLists();
    }

    List UpdateList = new List();
    private void SetListForUpdate(List List)
    {
        UpdateList = List;
    }

    private async Task UpdateListData()
    {
        await service.UpdateListAsync(UpdateList);
        await RefreshLists();
    }

    private async Task DeleteList(List List)
    {
        await service.DeleteListAsync(List);
        await RefreshLists();
    }

    private async Task CompleteList(List List)
    {
        await service.CompleteListAsync(List);
        await RefreshLists();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ListServices service { get; set; }
    }
}
#pragma warning restore 1591
