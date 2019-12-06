using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditScoreBriefGetResponse.
    /// </summary>
    public class ZhimaCreditScoreBriefGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 准入判断结果  Y(用户的芝麻分大于等于准入分数)，N（用户的芝麻分小于准入分数），N/A（无法评估，例如用户未开通芝麻信用,或芝麻采集的信息不足以评估该用户的信用）
        /// </summary>
        [JsonPropertyName("is_admittance")]
        public string IsAdmittance { get; set; }
    }
}
