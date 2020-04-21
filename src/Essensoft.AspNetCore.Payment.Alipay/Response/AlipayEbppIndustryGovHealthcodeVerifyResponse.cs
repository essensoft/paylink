using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeVerifyResponse.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 码的颜色，红/黄/绿/审核中，分别对应如下: red/yellow/green/init
        /// </summary>
        [JsonPropertyName("code_color")]
        public string CodeColor { get; set; }

        /// <summary>
        /// 生成的健康码码值
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 码值刷新的时间，可能为空
        /// </summary>
        [JsonPropertyName("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
