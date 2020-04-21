using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountFinriskCompanyVerifyCreateResponse.
    /// </summary>
    public class AlipayAccountFinriskCompanyVerifyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二代结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 三代结果码
        /// </summary>
        [JsonPropertyName("result_code_third")]
        public string ResultCodeThird { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否业务处理成功。 true：处理成功；false：处理失败。 默认：false
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
