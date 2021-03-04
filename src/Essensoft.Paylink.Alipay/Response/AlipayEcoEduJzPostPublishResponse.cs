using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduJzPostPublishResponse.
    /// </summary>
    public class AlipayEcoEduJzPostPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        [JsonPropertyName("third_id")]
        public string ThirdId { get; set; }
    }
}
