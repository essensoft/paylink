using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseMcommentFootprintUploadModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseMcommentFootprintUploadModel : AlipayObject
    {
        /// <summary>
        /// 足迹服务分配的业务码
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展字段,某些特殊业务需要传的指
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 足迹内容的模版号
        /// </summary>
        [JsonPropertyName("footprint_model_code")]
        public string FootprintModelCode { get; set; }

        /// <summary>
        /// 模版的内容
        /// </summary>
        [JsonPropertyName("footprint_model_data")]
        public string FootprintModelData { get; set; }

        /// <summary>
        /// 产生足迹的unix毫秒时间戳
        /// </summary>
        [JsonPropertyName("footprint_time")]
        public long FootprintTime { get; set; }

        /// <summary>
        /// 在某个场景下的唯一键,比如appId/shopId
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 上报数据来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
