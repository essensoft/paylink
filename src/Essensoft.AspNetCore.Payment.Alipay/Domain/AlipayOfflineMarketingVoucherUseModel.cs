using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherUseModel : AlipayObject
    {
        /// <summary>
        /// 约定的扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部活动id
        /// </summary>
        [JsonProperty("external_id")]
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部交易信息
        /// </summary>
        [JsonProperty("external_trade_info")]
        [XmlElement("external_trade_info")]
        public VoucherUserExternalTradeInfo ExternalTradeInfo { get; set; }

        /// <summary>
        /// 外部券码
        /// </summary>
        [JsonProperty("external_voucher_code")]
        [XmlElement("external_voucher_code")]
        public string ExternalVoucherCode { get; set; }
    }
}
