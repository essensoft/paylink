using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderCancelModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderCancelModel : AlipayObject
    {
        /// <summary>
        /// 合约退订业务场景
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 退订系统码，标志退订业务来源，用于确定退订流程
        /// </summary>
        [JsonPropertyName("cancel_system_code")]
        public string CancelSystemCode { get; set; }

        /// <summary>
        /// 退订类型
        /// </summary>
        [JsonPropertyName("cancel_type")]
        public string CancelType { get; set; }

        /// <summary>
        /// 纯透传风控数据，由调用上游与AGDS约定好
        /// </summary>
        [JsonPropertyName("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求APP
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 退订备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

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
    }
}
