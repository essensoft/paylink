using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeInstshortnameQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeInstshortnameQueryModel : AlipayObject
    {
        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonProperty("chargeinst_cn_name")]
        public string ChargeinstCnName { get; set; }
    }
}
