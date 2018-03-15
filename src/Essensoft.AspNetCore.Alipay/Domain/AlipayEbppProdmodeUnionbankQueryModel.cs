using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeUnionbankQueryModel : AlipayObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }
    }
}
