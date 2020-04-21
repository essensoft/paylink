using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryLogisticsSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryLogisticsSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 配送指令
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
        /// 业务处理结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
