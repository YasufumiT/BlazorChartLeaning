// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorLeaning.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using BlazorLeaning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using BlazorLeaning.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/Pages/Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/Pages/Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/Pages/Index.razor"
using System.Web.Http.Cors;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/user/Projects/BlazorLeaning/BlazorLeaning/Pages/Index.razor"
      

    string updatetext;
    RadarChart<double> radarChart;
    string[] radarLabels = { "うまさ", "サービス", "清潔さ", "雰囲気", "価格", "明るさ", "GMB" };

    List<string> radarbackgroundColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 0.2f), ChartColor.FromRgba(54, 162, 235, 0.2f), ChartColor.FromRgba(255, 206, 86, 0.2f), ChartColor.FromRgba(75, 192, 192, 0.2f), ChartColor.FromRgba(153, 102, 255, 0.2f), ChartColor.FromRgba(255, 159, 64, 0.2f) };
    List<string> radarborderColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 1f), ChartColor.FromRgba(54, 162, 235, 1f), ChartColor.FromRgba(255, 206, 86, 1f), ChartColor.FromRgba(75, 192, 192, 1f), ChartColor.FromRgba(153, 102, 255, 1f), ChartColor.FromRgba(255, 159, 64, 1f) };

    List<string> radarbackgroundColors2 = new List<string> { ChartColor.FromRgba(99, 99, 132, 0.2f), ChartColor.FromRgba(99, 162, 235, 0.2f), ChartColor.FromRgba(99, 206, 86, 0.2f), ChartColor.FromRgba(99, 192, 192, 0.2f), ChartColor.FromRgba(99, 102, 255, 0.2f), ChartColor.FromRgba(99, 159, 64, 0.2f) };
    List<string> radarborderColors2 = new List<string> { ChartColor.FromRgba(99, 99, 132, 1f), ChartColor.FromRgba(99, 162, 235, 1f), ChartColor.FromRgba(99, 206, 86, 1f), ChartColor.FromRgba(99, 192, 192, 1f), ChartColor.FromRgba(99, 102, 255, 1f), ChartColor.FromRgba(99, 159, 64, 1f) };

    List<string> radarbackgroundColors3 = new List<string> { ChartColor.FromRgba(99, 132, 132, 0.2f), ChartColor.FromRgba(99, 132, 235, 0.2f), ChartColor.FromRgba(99, 132, 86, 0.2f), ChartColor.FromRgba(99, 132, 192, 0.2f), ChartColor.FromRgba(99, 132, 255, 0.2f), ChartColor.FromRgba(99, 132, 132, 0.2f) };
    List<string> radarborderColors3 = new List<string> { ChartColor.FromRgba(99, 132, 132, 1f), ChartColor.FromRgba(99, 132, 235, 1f), ChartColor.FromRgba(99, 132, 86, 1f), ChartColor.FromRgba(99, 132, 192, 1f), ChartColor.FromRgba(99, 132, 255, 1f), ChartColor.FromRgba(99, 132, 132, 1f) };

    double data1 = 0;
    double data2 = 0;
    double data3 = 0;
    double data4 = 0;
    double data5 = 0;
    double data6 = 0;
    double data7 = 0;

    private ResponceData[] responceDatas;

    string shop = "shop";
    string num = "1.0.0";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await HandleRedraw();
        }
    }

    //グラフ描画
    async Task HandleRedraw()
    {

        var responses = await Http.GetFromJsonAsync<ResponceData[]>($"https://virtserver.swaggerhub.com/Qitz5/karute/{num}/{shop}");
        await radarChart.Clear();
        await radarChart.AddLabelsDatasetsAndUpdate(radarLabels, GetRadarChartDataset());
        Console.Write($"test{shop}");
    }

    //更新
    async void OnInitializedAsync()
    {
        updatetext = "：データが更新されました。";
        var responses = await Http.GetFromJsonAsync<ResponceData[]>("https://virtserver.swaggerhub.com/Qitz5/karute/1.0.0/shop");

        foreach (var r in responses)
        {
            data1 = r.ID * 0.5;
            data2 = r.ID * 0.25;
            data3 = r.ID * 0.35;
            data4 = r.ID * 0.45;
            data5 = r.ID * 0.21;
            data6 = r.ID * 0.43;
            data7 = r.ID * 0.37;
        }

    }

    //チャートのデータを設定
    RadarChartDataset<double>[] GetRadarChartDataset()
    {
        RadarChartDataset<double> dataset1 = null;
        dataset1 = new RadarChartDataset<double>
        {
            Label = "サンプルデータA",
            Data = new List<double> { data1, data2, data3, data4, data5, data6, data7 },
            BackgroundColor = radarbackgroundColors,
            BorderColor = radarborderColors,
            Fill = true,
            BorderWidth = 2,
            LineTension = 0,
        };

        RadarChartDataset<double> dataset2 = new RadarChartDataset<double>
        {
            Label = "#サンプルデータB",
            Data = new List<double> { data7, data6, data5, data4, data3, data2, data1 },
            BackgroundColor = radarbackgroundColors2,
            BorderColor = radarborderColors2,
            Fill = true,
            BorderWidth = 2,
            LineTension = 0,
        };

        RadarChartDataset<double> dataset3 = new RadarChartDataset<double>
        {
            Label = "#サンプルデータC",
            Data = new List<double> { data4, data2, data3, data1, data5, data7, data6 },
            BackgroundColor = radarbackgroundColors3,
            BorderColor = radarborderColors3,
            Fill = true,
            BorderWidth = 2,
            LineTension = 0,
        };

        //複数のRadarChartをリストで返す
        return new RadarChartDataset<double>[]
        {
            dataset1,dataset2,dataset3
        };
    }

    public class ResponceData
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string NAME { get; set; }

        [JsonPropertyName("comment")]
        public string COMMENT { get; set; }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
