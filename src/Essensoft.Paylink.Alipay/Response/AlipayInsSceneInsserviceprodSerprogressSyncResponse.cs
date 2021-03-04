using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerprogressSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerprogressSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 进度明细编号(业务主键)
        /// </summary>
        [JsonPropertyName("progress_no")]
        public string ProgressNo { get; set; }
    }
}
