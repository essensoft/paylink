using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 获取商户下设备列表
        /// </summary>
        [JsonPropertyName("device_sn_list")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
