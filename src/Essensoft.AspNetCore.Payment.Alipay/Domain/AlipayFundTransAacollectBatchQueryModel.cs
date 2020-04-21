using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchQueryModel Data Structure.
    /// </summary>
    public class AlipayFundTransAacollectBatchQueryModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 防止接口被遍历所设置的查询token，在调用创建批次时生成，随批次号下发
        /// </summary>
        [JsonPropertyName("batch_token")]
        public string BatchToken { get; set; }
    }
}
