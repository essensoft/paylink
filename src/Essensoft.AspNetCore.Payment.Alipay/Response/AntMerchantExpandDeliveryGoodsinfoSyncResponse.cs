using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryGoodsinfoSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryGoodsinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 配送指令id，参考已有获取配送指令接口。
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
