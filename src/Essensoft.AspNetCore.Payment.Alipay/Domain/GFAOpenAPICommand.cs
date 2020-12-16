using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPICommand Data Structure.
    /// </summary>
    public class GFAOpenAPICommand : AlipayObject
    {
        /// <summary>
        /// 业财受理单id
        /// </summary>
        [JsonPropertyName("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 摊销回执信息
        /// </summary>
        [JsonPropertyName("amortize_receipt")]
        public GFAOpenAPICommandReceipt AmortizeReceipt { get; set; }

        /// <summary>
        /// 指令消费方
        /// </summary>
        [JsonPropertyName("command_consumer")]
        public string CommandConsumer { get; set; }

        /// <summary>
        /// 业财受理指令id
        /// </summary>
        [JsonPropertyName("command_id")]
        public string CommandId { get; set; }

        /// <summary>
        /// 解决方案实例id
        /// </summary>
        [JsonPropertyName("config_instance_id")]
        public string ConfigInstanceId { get; set; }

        /// <summary>
        /// 指令方向（正向、逆向）
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 平台产品标识
        /// </summary>
        [JsonPropertyName("platform_product_code")]
        public string PlatformProductCode { get; set; }

        /// <summary>
        /// 结算回执信息
        /// </summary>
        [JsonPropertyName("settle_receipt")]
        public GFAOpenAPICommandReceipt SettleReceipt { get; set; }

        /// <summary>
        /// 指令状态（如初始、已发送）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 指令类型（如计费、结算、摊销等）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
