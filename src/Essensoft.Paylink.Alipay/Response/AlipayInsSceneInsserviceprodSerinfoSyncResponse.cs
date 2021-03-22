using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerinfoSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝的单据编号 (就是请求中的ser_biz_no原封不动返回)
        /// </summary>
        [JsonPropertyName("ser_biz_no")]
        public string SerBizNo { get; set; }
    }
}
