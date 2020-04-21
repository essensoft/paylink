using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeLawsuitDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditPeLawsuitDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 个人涉诉详情信息
        /// </summary>
        [JsonPropertyName("lawsuit_detail")]
        public EpInfo LawsuitDetail { get; set; }
    }
}
