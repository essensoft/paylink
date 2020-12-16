using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverlevelQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverlevelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数据版本 YYYYMMDD格式
        /// </summary>
        [JsonPropertyName("date_version")]
        public string DateVersion { get; set; }

        /// <summary>
        /// 司机等级
        /// </summary>
        [JsonPropertyName("driver_level")]
        public string DriverLevel { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [JsonPropertyName("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 错误吗
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 两个状态，我们的库里有该司机：FOUND；我们的库里没有该司机或司机未授权：NOTFOUND。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
