using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitBeneficialinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 相对于汇率的基准货币
        /// </summary>
        [JsonProperty("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款的金额
        /// </summary>
        [JsonProperty("receive_amount")]
        public string ReceiveAmount { get; set; }

        /// <summary>
        /// 收款的金额币种
        /// </summary>
        [JsonProperty("receive_currency")]
        public string ReceiveCurrency { get; set; }

        /// <summary>
        /// 接收端的ID
        /// </summary>
        [JsonProperty("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 汇款用途
        /// </summary>
        [JsonProperty("remit_purpose")]
        public string RemitPurpose { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [JsonProperty("send_amount")]
        public string SendAmount { get; set; }

        /// <summary>
        /// 汇款人国家
        /// </summary>
        [JsonProperty("send_country")]
        public string SendCountry { get; set; }

        /// <summary>
        /// 汇款币种
        /// </summary>
        [JsonProperty("send_currency")]
        public string SendCurrency { get; set; }

        /// <summary>
        /// 发端ID
        /// </summary>
        [JsonProperty("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// 汇款人姓名
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
