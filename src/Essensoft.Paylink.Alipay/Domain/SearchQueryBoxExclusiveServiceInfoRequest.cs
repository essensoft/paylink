using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchQueryBoxExclusiveServiceInfoRequest Data Structure.
    /// </summary>
    public class SearchQueryBoxExclusiveServiceInfoRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 服务类型标识符：SP_MINI_APP/SP_PUBLIC_APP（小程序/生活号）
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }
    }
}
