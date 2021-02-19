using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
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
