using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingFacetofaceDecodeUseModel Data Structure.
    /// </summary>
    public class AlipayMarketingFacetofaceDecodeUseModel : AlipayObject
    {
        /// <summary>
        /// 付款码码值
        /// </summary>
        [JsonPropertyName("dynamic_id")]
        public string DynamicId { get; set; }

        /// <summary>
        /// 外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.marketing.facetoface.decode.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致。
        /// </summary>
        [JsonPropertyName("sence_no")]
        public string SenceNo { get; set; }
    }
}
