using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductConfirmResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// alipay_sign代表支付宝侧签约成功 enable代表协议生效 alipay_unsign代表支付宝侧解约成功 disable代表协议失效 如果机构未提供签约接口，则只关注协议是否生效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
