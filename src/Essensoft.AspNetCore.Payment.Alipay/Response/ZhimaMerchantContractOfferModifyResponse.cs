using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantContractOfferModifyResponse.
    /// </summary>
    public class ZhimaMerchantContractOfferModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务操作结果，成功或失败
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }
    }
}
