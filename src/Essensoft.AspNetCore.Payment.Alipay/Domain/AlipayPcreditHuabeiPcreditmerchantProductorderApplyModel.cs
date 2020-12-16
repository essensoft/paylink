using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderApplyModel : AlipayObject
    {
        /// <summary>
        /// 产品开始生效的时间
        /// </summary>
        [JsonPropertyName("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 合约订购业务场景
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 下游需要数据，纯透传
        /// </summary>
        [JsonPropertyName("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求来源应用
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 合约订购平台
        /// </summary>
        [JsonPropertyName("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 订购系统码，用于标识订购花呗产品的系统
        /// </summary>
        [JsonPropertyName("ordered_system_code")]
        public string OrderedSystemCode { get; set; }

        /// <summary>
        /// 订购产品的时间，用于标识用户下单动作的时间
        /// </summary>
        [JsonPropertyName("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }
    }
}
