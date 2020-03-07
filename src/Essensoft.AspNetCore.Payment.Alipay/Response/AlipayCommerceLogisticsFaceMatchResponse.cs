using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFaceMatchResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFaceMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 返回业务唯一标识 , 用于在人脸匹配到目标后，根据这个业务唯一标识做后续业务j校验以及操作.比如针对刷脸开柜场景，商户需要根据返回的这个业务唯一标识来判断当前业务单的状态，来决定是否进行开柜操作 .
        /// </summary>
        [JsonPropertyName("biz_unique_no")]
        public string BizUniqueNo { get; set; }
    }
}
