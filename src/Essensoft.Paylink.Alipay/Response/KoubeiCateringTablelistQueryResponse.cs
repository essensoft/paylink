using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [JsonPropertyName("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
