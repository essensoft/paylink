using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDataPutResponse.
    /// </summary>
    public class AlipayEcapiprodDataPutResponse : AlipayResponse
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [JsonProperty("data_version")]
        public string DataVersion { get; set; }
    }
}
