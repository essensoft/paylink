using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOutsideApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号(与入参调用外部业务号一致)
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
