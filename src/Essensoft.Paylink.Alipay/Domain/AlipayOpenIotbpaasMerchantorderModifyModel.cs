using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderModifyModel : AlipayObject
    {
        /// <summary>
        /// 设备订单状态列表
        /// </summary>
        [JsonPropertyName("device_order_status_list")]
        public List<DeviceOrderStatus> DeviceOrderStatusList { get; set; }
    }
}
