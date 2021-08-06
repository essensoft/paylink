using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundTaxbillSigncodeCreateResponse.
    /// </summary>
    public class AlipayFundTaxbillSigncodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约吱口令，请求成功响应时存在
        /// </summary>
        [JsonPropertyName("sign_code")]
        public string SignCode { get; set; }
    }
}
