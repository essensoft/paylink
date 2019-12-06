using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    public class AlipayUserCreditCard : AlipayObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }
    }
}
