using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantStoreMiniappBindModel Data Structure.
    /// </summary>
    public class AlipayMerchantStoreMiniappBindModel : AlipayObject
    {
        /// <summary>
        /// 门店小程序绑定操作的类型，分为以下枚举类型： - STORE_DEFAULT_MINIAPP，门店默认小程序
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 门店和小程序绑定映射关系
        /// </summary>
        [JsonPropertyName("shop_app_relation")]
        public List<ShopAppRelation> ShopAppRelation { get; set; }
    }
}
