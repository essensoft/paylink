using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAboardApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAboardApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 上架成功后返回的提示
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
