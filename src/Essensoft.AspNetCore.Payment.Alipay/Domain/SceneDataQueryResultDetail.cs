using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDataQueryResultDetail Data Structure.
    /// </summary>
    public class SceneDataQueryResultDetail : AlipayObject
    {
        /// <summary>
        /// 网商银行申请单号
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 机构需要查询的订单数据，
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
