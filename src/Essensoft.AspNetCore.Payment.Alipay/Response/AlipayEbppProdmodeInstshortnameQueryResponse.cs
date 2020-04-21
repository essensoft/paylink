using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProdmodeInstshortnameQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeInstshortnameQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonPropertyName("chargeinst_cn_name")]
        public string ChargeinstCnName { get; set; }

        /// <summary>
        /// 出账机构英文名称
        /// </summary>
        [JsonPropertyName("chargeinst_en_name")]
        public string ChargeinstEnName { get; set; }
    }
}
