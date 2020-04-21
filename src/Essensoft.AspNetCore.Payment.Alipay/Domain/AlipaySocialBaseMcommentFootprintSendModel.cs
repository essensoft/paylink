using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseMcommentFootprintSendModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseMcommentFootprintSendModel : AlipayObject
    {
        /// <summary>
        /// 足迹服务分配的业务码
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展字段，某些特殊业务需要传，JSON格式
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 足迹内容的模版号
        /// </summary>
        [JsonPropertyName("footprint_model_code")]
        public string FootprintModelCode { get; set; }

        /// <summary>
        /// 模板内容，JSON格式
        /// </summary>
        [JsonPropertyName("footprint_model_data")]
        public string FootprintModelData { get; set; }

        /// <summary>
        /// 产生足迹的unix毫秒时间戳
        /// </summary>
        [JsonPropertyName("footprint_time")]
        public long FootprintTime { get; set; }

        /// <summary>
        /// 业务场景下的唯一键，例如店铺id，访问对象的id
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
