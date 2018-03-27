using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankCardInfo Data Structure.
    /// </summary>
    public class BankCardInfo : AlipayObject
    {
        /// <summary>
        /// 银行卡持卡人姓名
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
    }
}
