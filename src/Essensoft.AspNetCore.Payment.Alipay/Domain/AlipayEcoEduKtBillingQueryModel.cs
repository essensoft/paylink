using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtBillingQueryModel : AlipayObject
    {
        /// <summary>
        /// Isv pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// ISV调用发送账单接口，返回给商户的order_no
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 学校支付宝pid
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }
    }
}
