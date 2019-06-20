using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaAuthInfoAuthqueryResponse.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否已经授权； authorized＝true 表示已授权, authorized＝false表示未授权
        /// </summary>
        [JsonProperty("authorized")]
        public bool Authorized { get; set; }

        /// <summary>
        /// 当前授权业务查询标识
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }
    }
}
