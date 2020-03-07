using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板识别精确度(单位 %)
        /// </summary>
        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 模板识别精确度是否通过
        /// </summary>
        [JsonPropertyName("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
