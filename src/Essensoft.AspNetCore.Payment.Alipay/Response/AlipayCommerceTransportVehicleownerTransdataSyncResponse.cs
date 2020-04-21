using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerTransdataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerTransdataSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 数据执行行数
        /// </summary>
        [JsonPropertyName("excute_lines")]
        public string ExcuteLines { get; set; }

        /// <summary>
        /// 执行结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
