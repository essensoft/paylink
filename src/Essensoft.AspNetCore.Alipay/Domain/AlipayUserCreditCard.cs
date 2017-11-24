using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    public class AlipayUserCreditCard : AlipayObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [JsonProperty("inst_id")]
        public string InstId { get; set; }
    }
}
