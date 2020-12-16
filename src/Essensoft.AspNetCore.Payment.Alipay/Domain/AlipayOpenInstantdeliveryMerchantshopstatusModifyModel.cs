using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopstatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 要更新的商家门店列表
        /// </summary>
        [JsonPropertyName("merchant_shop_infos")]
        public List<MerchantShopInfo> MerchantShopInfos { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
