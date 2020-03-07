using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoSecuritydataQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoSecuritydataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果,  结果为json格式  返回值的key, 为入参查询值的主体.  返回值的value, 为入参查询值的结果.以风控黑名单为例,在黑名单中返回"hasRisk",不在黑名单中返回"noRisk".
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
