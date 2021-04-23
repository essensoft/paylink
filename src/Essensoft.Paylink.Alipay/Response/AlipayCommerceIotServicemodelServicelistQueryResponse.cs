using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotServicemodelServicelistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotServicemodelServicelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备服务列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<DeviceServiceVO> List { get; set; }
    }
}
