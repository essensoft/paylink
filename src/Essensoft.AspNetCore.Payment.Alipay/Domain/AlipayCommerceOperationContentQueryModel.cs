using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationContentQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [JsonPropertyName("booth")]
        public List<string> Booth { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 内容 ID 加密串
        /// </summary>
        [JsonPropertyName("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展参数 , json 串
        /// </summary>
        [JsonPropertyName("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [JsonPropertyName("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页查询每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 运营场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 运营阵地 : 比如一个页面
        /// </summary>
        [JsonPropertyName("touch_point")]
        public string TouchPoint { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
