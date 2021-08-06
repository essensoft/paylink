using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPayAppSmartwearStatusQueryResponse.
    /// </summary>
    public class AlipayPayAppSmartwearStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 支持的产品类型
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 使用的安全方案
        /// </summary>
        [JsonPropertyName("security_solution")]
        public string SecuritySolution { get; set; }

        /// <summary>
        /// 该设备的状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
