using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeSignQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeSignQueryModel : AlipayObject
    {
        /// <summary>
        /// 出账/销账机构支付宝账号
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }
    }
}
