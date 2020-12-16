using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicetypeBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicetypeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备类型列表
        /// </summary>
        [JsonPropertyName("device_type_list")]
        public List<AmpeDeviceTypeInfo> DeviceTypeList { get; set; }
    }
}
