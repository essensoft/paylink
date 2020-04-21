using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAlideviceinfoOfflinecodeCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceAlideviceinfoOfflinecodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 绑定标识
        /// </summary>
        [JsonPropertyName("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 支付宝统一sdk获取的设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 业务场景，由支付宝定义
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机具物料id，由支付宝分配
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 绑定商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 离线支付协议版本，与支付sdk协议版本保持一致
        /// </summary>
        [JsonPropertyName("protocol_version")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商id，由支付宝分配
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
