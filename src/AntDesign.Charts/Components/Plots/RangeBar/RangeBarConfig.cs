using OneOf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AntDesign.Charts
{
    public class RangeBarConfig : IRangeBarViewConfig, IPlotConfig
    {
        [JsonPropertyName("label")]
        public RangeBarLabelConfig Label { get; set; }
        [JsonPropertyName("colorField")]
        public string ColorField { get; set; }
        [JsonPropertyName("barSize")]
        public int? BarSize { get; set; }
        [JsonPropertyName("barStyle")]
        public GraphicStyle BarStyle { get; set; }
        [JsonPropertyName("xAxis")]
        public ValueAxis XAxis { get; set; }
        [JsonPropertyName("yAxis")]
        public CatAxis YAxis { get; set; }
        [JsonPropertyName("conversionTag")]
        public ConversionTagOptions ConversionTag { get; set; }
        [JsonPropertyName("interactions")]
        public Interaction[] Interactions { get; set; }
        [JsonPropertyName("renderer")]
        public string Renderer { get; set; }
        [JsonPropertyName("data")]
        public object Data { get; set; }
        [JsonPropertyName("meta")]
        public object Meta { get; set; }//ILooseMap<Meta>
        [JsonPropertyName("padding")]
        public string Padding { get; set; }
        [JsonPropertyName("xField")]
        public string XField { get; set; }
        [JsonPropertyName("yField")]
        public string YField { get; set; }
        [JsonPropertyName("color")]
        public string[] Color { get; set; }
        [JsonPropertyName("tooltip")]
        public Tooltip Tooltip { get; set; }
        [JsonPropertyName("legend")]
        public Legend Legend { get; set; }
        /// <summary>
        ///OneOf<Animation, bool?> 
        /// </summary>
        [JsonPropertyName("animation")]
        public object Animation { get; set; }
        [JsonIgnore]
        public OneOf<string, object> Theme { get; set; }
        [JsonPropertyName("theme")]
        public object themeMapping => Theme.Value;
        [JsonPropertyName("responsiveTheme")]
        public object ResponsiveTheme { get; set; }
        [JsonPropertyName("responsive")]
        public bool? Responsive { get; set; }
        [JsonPropertyName("title")]
        public Title Title { get; set; }
        [JsonPropertyName("description")]
        public Description Description { get; set; }
        [JsonPropertyName("guideLine")]
        public GuideLineConfig[] GuideLine { get; set; }
        [JsonPropertyName("defaultState")]
        public ViewConfigDefaultState DefaultState { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("forceFit")]
        public bool? ForceFit { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("pixelRatio")]
        public int? PixelRatio { get; set; }
        [JsonPropertyName("localRefresh")]
        public bool? LocalRefresh { get; set; }
        [JsonPropertyName("columnStyle")]
        public object ColumnStyle { get; set; }
        BarViewConfigLabel IBarViewConfig.Label { get; set; }
        Label IViewConfig.Label { get; set; }
        Axis IViewConfig.XAxis { get; set; }
        Axis IViewConfig.YAxis { get; set; }
    }

    public interface IRangeBarViewConfig : IBarViewConfig
    {
        [JsonPropertyName("label")]
        public RangeBarLabelConfig Label { get; set; }

        [JsonPropertyName("columnStyle")]
        public object ColumnStyle { get; set; }//TODO:源码中缺失，Demo中存在
    }
}

