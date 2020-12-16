using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementUserverifyApplyResponse.
    /// </summary>
    public class AlipayUserAgreementUserverifyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 用户验证申请token，其格式和内容，由支付宝定义。在鉴权确认的过程中，商户可根据申请操作成功时返回的申请token，获取后续的买家结果
        /// </summary>
        [JsonPropertyName("apply_token")]
        public string ApplyToken { get; set; }
    }
}
