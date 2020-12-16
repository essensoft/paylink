using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderDelayModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderDelayModel : AlipayObject
    {
        /// <summary>
        /// 非业务数据
        /// </summary>
        [JsonPropertyName("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求APP
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 续订系统码，用于标识订购花呗产品的系统
        /// </summary>
        [JsonPropertyName("renew_system_code")]
        public string RenewSystemCode { get; set; }

        /// <summary>
        /// 续订发生时间
        /// </summary>
        [JsonPropertyName("renewing_datetime")]
        public string RenewingDatetime { get; set; }
    }
}
