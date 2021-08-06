using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建失败的投放信息列表  失败的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        [JsonPropertyName("error_delivery_config_list")]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// 创建成功的投放信息列表  成功的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        [JsonPropertyName("success_delivery_config_list")]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }
    }
}
