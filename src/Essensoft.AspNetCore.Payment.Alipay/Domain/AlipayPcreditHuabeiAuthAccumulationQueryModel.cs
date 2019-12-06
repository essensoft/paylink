using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAccumulationQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthAccumulationQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 协议结算周期，使用支付宝端回传的周期信息。
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }
    }
}
