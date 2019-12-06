using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpLawsuitDetailGetResponse.
    /// </summary>
    public class ZhimaCreditEpLawsuitDetailGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业涉诉详情
        /// </summary>
        [JsonPropertyName("lawsuit_detail")]
        public EpInfo LawsuitDetail { get; set; }
    }
}
