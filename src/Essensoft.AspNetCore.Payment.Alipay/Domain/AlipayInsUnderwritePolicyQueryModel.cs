using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryModel Data Structure.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户生成的外部投保业务号;当保单凭证号不传时则必传.
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单凭证号;商户生成的外部投保业务号不传时则必传.
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品编码;当保单凭证号不传时则必传.
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }
    }
}
