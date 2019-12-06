using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantlistEnterApplyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceMerchantlistEnterApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户品牌信息
        /// </summary>
        [JsonPropertyName("merchant_base")]
        public MerchantBaseEnterOpenModel MerchantBase { get; set; }

        /// <summary>
        /// 商户门店入驻产品公共信息
        /// </summary>
        [JsonPropertyName("sub_merchant_common_info")]
        public SubMerchantCommonEnterOpenModel SubMerchantCommonInfo { get; set; }

        /// <summary>
        /// 商户门店列表信息，最多传入30个门店信息
        /// </summary>
        [JsonPropertyName("sub_merchant_list")]
        public List<SubMerchantEnterOpenModel> SubMerchantList { get; set; }
    }
}
