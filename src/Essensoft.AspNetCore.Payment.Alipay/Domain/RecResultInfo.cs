using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecResultInfo Data Structure.
    /// </summary>
    public class RecResultInfo : AlipayObject
    {
        /// <summary>
        /// 错误码  NO_REC_ITEMS 无推荐服务  NO_ENOUGH_ITEMS 推荐数量不合法
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 推荐ITEM
        /// </summary>
        [JsonPropertyName("items")]
        public List<RecItemInfo> Items { get; set; }

        /// <summary>
        /// 错误消息，如果成功则为空
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 推荐结果
        /// </summary>
        [JsonPropertyName("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
