using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [JsonProperty("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
