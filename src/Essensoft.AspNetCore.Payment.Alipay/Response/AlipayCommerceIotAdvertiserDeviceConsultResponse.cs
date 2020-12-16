using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceConsultResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 设备关联数据
        /// </summary>
        [JsonPropertyName("result")]
        public List<DeviceRelationData> Result { get; set; }
    }
}
