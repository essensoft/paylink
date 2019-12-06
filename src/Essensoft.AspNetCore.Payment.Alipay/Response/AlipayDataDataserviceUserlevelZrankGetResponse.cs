using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [JsonPropertyName("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
