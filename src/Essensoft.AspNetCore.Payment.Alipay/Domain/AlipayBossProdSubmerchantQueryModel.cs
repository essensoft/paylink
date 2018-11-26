using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubmerchantQueryModel : AlipayObject
    {
        /// <summary>
        /// 受理商户在受理机构下的唯一标识，与sub_merchant_id二选一必传
        /// </summary>
        [JsonProperty("external_id")]
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户在支付宝入驻后的识别号，商户入驻后由支付宝返回，与external_id二选一必传
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
