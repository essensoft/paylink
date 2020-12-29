using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionCreateModel : AlipayObject
    {
        /// <summary>
        /// 服务区域编码；默认值为1，表示全国范围；编码参考高德地图JS API相关下载中的行政区编码与城市编码表：https://lbs.amap.com/api/javascript-api/download/
        /// </summary>
        [JsonPropertyName("area_codes")]
        public List<string> AreaCodes { get; set; }

        /// <summary>
        /// 类目属性列表
        /// </summary>
        [JsonPropertyName("category_attributes")]
        public List<AppAttribute> CategoryAttributes { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [JsonPropertyName("category_ids")]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// 服务icon
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 关键字列表；关键词数量最多5个，每个关键词长度在5个字符以内
        /// </summary>
        [JsonPropertyName("key_words")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 服务名称；长度范围在2到10个字符以内
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务结束时间；默认值：23:59:59
        /// </summary>
        [JsonPropertyName("service_time_end")]
        public string ServiceTimeEnd { get; set; }

        /// <summary>
        /// 服务开始时间；默认值：00:00:00
        /// </summary>
        [JsonPropertyName("service_time_start")]
        public string ServiceTimeStart { get; set; }

        /// <summary>
        /// 服务地址列表
        /// </summary>
        [JsonPropertyName("service_urls")]
        public List<ServiceUrl> ServiceUrls { get; set; }

        /// <summary>
        /// 短描述；长度范围在5到16个字符以内
        /// </summary>
        [JsonPropertyName("short_desc")]
        public string ShortDesc { get; set; }
    }
}
