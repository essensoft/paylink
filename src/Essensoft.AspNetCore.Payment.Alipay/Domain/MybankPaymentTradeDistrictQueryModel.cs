using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeDistrictQueryModel : AlipayObject
    {
        /// <summary>
        /// 父级行政地区编码。 不填则默认查询省级行政地区编码，支持省市县三级查询。
        /// </summary>
        [JsonPropertyName("parent_code")]
        public string ParentCode { get; set; }
    }
}
