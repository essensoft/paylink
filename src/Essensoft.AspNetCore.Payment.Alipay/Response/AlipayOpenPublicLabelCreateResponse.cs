using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLabelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回的标签ID，开发者后续通过该ID进行标签的查询、修改、删除等操作
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 开发者传入name的值
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
