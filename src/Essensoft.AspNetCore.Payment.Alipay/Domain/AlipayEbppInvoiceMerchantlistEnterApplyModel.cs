using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantlistEnterApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceMerchantlistEnterApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户品牌信息
        /// </summary>
        [JsonProperty("merchant_base")]
        [XmlElement("merchant_base")]
        public MerchantBaseEnterOpenModel MerchantBase { get; set; }

        /// <summary>
        /// 商户门店入驻产品公共信息
        /// </summary>
        [JsonProperty("sub_merchant_common_info")]
        [XmlElement("sub_merchant_common_info")]
        public SubMerchantCommonEnterOpenModel SubMerchantCommonInfo { get; set; }

        /// <summary>
        /// 商户门店列表信息，最多传入30个门店信息
        /// </summary>
        [JsonProperty("sub_merchant_list")]
        [XmlArray("sub_merchant_list")]
        [XmlArrayItem("sub_merchant_enter_open_model")]
        public List<SubMerchantEnterOpenModel> SubMerchantList { get; set; }
    }
}
