using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDevicesBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店下设备列表
        /// </summary>
        [JsonProperty("device_info_list")]
        public List<DeviceInfo> DeviceInfoList { get; set; }
    }
}
