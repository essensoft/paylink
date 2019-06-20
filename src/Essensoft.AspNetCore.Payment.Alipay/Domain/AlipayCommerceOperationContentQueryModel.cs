using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [JsonProperty("booth")]
        public List<string> Booth { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 内容 ID 加密串
        /// </summary>
        [JsonProperty("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展参数 , json 串
        /// </summary>
        [JsonProperty("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [JsonProperty("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页查询每页记录数
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 运营场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 运营阵地 : 比如一个页面
        /// </summary>
        [JsonProperty("touch_point")]
        public string TouchPoint { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
