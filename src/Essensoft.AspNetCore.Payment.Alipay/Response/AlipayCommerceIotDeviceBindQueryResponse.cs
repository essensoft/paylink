using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceBindQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceBindQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备绑定关系
        /// </summary>
        [JsonPropertyName("bind_info_list")]
        public List<IotDeviceBindInfo> BindInfoList { get; set; }
    }
}
