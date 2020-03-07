using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransBatchCreatesinglebatchResponse.
    /// </summary>
    public class AlipayFundTransBatchCreatesinglebatchResponse : AlipayResponse
    {
        /// <summary>
        /// 所创建成功后的批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 调用方传入的ext_param，透传回去
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// token，每个批次对应一个token，每次调用方进行查询的时候都要使用批次号和token进行组合查询
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
