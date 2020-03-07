using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePeerpayprodRelationCreateResponse.
    /// </summary>
    public class AlipayTradePeerpayprodRelationCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 亲情号关系是否添加成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
