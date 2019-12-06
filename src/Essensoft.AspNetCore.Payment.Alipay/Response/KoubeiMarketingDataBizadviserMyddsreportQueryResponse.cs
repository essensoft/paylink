using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataBizadviserMyddsreportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataBizadviserMyddsreportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// result是一个所有结果集合的json串。  result结果集是一个json格式数组， 是门店热力图信息  lng: 位置经度 lat:位置维度 cnt：会员数量
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
