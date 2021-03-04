using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayZdataassetsMetadataResponse.
    /// </summary>
    public class AlipayZdataassetsMetadataResponse : AlipayResponse
    {
        /// <summary>
        /// 用户标签集合
        /// </summary>
        [JsonPropertyName("result")]
        public List<CustomerEntity> Result { get; set; }
    }
}
