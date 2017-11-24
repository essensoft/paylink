using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [JsonProperty("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
