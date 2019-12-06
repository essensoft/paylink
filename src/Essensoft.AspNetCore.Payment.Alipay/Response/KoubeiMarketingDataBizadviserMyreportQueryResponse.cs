using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataBizadviserMyreportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataBizadviserMyreportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 不同uniq_key 返回不同参数，详细请看：https://doc.open.alipay.com/docs/doc.htm?spm=0.0.0.0.1Zq3by&docType=1&articleId=107061&previewCode=F30AA2D06B7CC0817AC7221A8CE288A4
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
