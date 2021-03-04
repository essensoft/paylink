using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDeveloppackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeveloppackageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单个小程序的启动结果VO
        /// </summary>
        [JsonPropertyName("single_start_app_vo")]
        public SingleStartAppVO SingleStartAppVo { get; set; }
    }
}
