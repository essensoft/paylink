using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityDeliveryQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前服务商所代理的商户信息. 在投放查询时，会使用商户信息来进行权限的判断. 如果代理商户信息中的businessType为ISV模式.则默认使用当前操作人的信息作为商户信息
        /// </summary>
        [JsonPropertyName("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 待查询的投放配置列表。 最大数量限制20个。
        /// </summary>
        [JsonPropertyName("delivery_config_list")]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }
    }
}
