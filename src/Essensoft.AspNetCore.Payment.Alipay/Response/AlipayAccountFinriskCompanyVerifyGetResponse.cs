using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountFinriskCompanyVerifyGetResponse.
    /// </summary>
    public class AlipayAccountFinriskCompanyVerifyGetResponse : AlipayResponse
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

        /// <summary>
        /// 防伪结果信息
        /// </summary>
        [JsonPropertyName("verify_info")]
        public List<VerifyInfoVO> VerifyInfo { get; set; }

        /// <summary>
        /// 防伪结果码
        /// </summary>
        [JsonPropertyName("verify_result_code")]
        public string VerifyResultCode { get; set; }

        /// <summary>
        /// 防伪结果描述
        /// </summary>
        [JsonPropertyName("verify_result_desc")]
        public string VerifyResultDesc { get; set; }
    }
}
