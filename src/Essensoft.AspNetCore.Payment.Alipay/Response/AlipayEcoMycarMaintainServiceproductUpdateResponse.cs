using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainServiceproductUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainServiceproductUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 车主平台生成的产品编号  新增：必填
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
