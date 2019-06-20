using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAlideviceinfoOfflinecodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAlideviceinfoOfflinecodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 绑定标识
        /// </summary>
        [JsonProperty("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 支付宝统一sdk获取的设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 业务场景，由支付宝定义
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机具物料id，由支付宝分配
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 绑定商户pid
        /// </summary>
        [JsonProperty("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 离线支付协议版本，与支付sdk协议版本保持一致
        /// </summary>
        [JsonProperty("protocol_version")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonProperty("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商id，由支付宝分配
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }
    }
}
