using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsFixdataCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsFixdataCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 补数据操作是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
