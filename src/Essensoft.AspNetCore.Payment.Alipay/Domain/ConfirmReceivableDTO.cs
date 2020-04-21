using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConfirmReceivableDTO Data Structure.
    /// </summary>
    public class ConfirmReceivableDTO : AlipayObject
    {
        /// <summary>
        /// 确认模式，支持ONE_TIME和BY_STRATEGY
        /// </summary>
        [JsonPropertyName("confirm_model")]
        public string ConfirmModel { get; set; }

        /// <summary>
        /// 请求时的业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 应收确认单号
        /// </summary>
        [JsonPropertyName("receivable_no")]
        public string ReceivableNo { get; set; }
    }
}
