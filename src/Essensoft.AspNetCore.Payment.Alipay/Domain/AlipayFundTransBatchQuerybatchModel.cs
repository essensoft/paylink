using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransBatchQuerybatchModel Data Structure.
    /// </summary>
    public class AlipayFundTransBatchQuerybatchModel : AlipayObject
    {
        /// <summary>
        /// 批次编号，创建批次时返回的批次编号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// token，创建批次时和批次编号一起返回。注：在使用批次号查询批次信息时需要带上
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
