using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderdeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [JsonPropertyName("device_infos")]
        public List<DeviceApplyOrderDeviceModel> DeviceInfos { get; set; }
    }
}
