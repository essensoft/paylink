using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 相对于汇率的基准货币
        /// </summary>
        [JsonPropertyName("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款的金额
        /// </summary>
        [JsonPropertyName("receive_amount")]
        public string ReceiveAmount { get; set; }

        /// <summary>
        /// 收款的金额币种
        /// </summary>
        [JsonPropertyName("receive_currency")]
        public string ReceiveCurrency { get; set; }

        /// <summary>
        /// 接收端的ID
        /// </summary>
        [JsonPropertyName("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 汇款用途
        /// </summary>
        [JsonPropertyName("remit_purpose")]
        public string RemitPurpose { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [JsonPropertyName("send_amount")]
        public string SendAmount { get; set; }

        /// <summary>
        /// 汇款人国家，与sender_nationality不能同时为空
        /// </summary>
        [JsonPropertyName("send_country")]
        public string SendCountry { get; set; }

        /// <summary>
        /// 汇款币种
        /// </summary>
        [JsonPropertyName("send_currency")]
        public string SendCurrency { get; set; }

        /// <summary>
        /// 发端ID
        /// </summary>
        [JsonPropertyName("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// 汇款人姓名
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 汇款人国籍，与send_country不能同时为空
        /// </summary>
        [JsonPropertyName("sender_nationality")]
        public string SenderNationality { get; set; }
    }
}
