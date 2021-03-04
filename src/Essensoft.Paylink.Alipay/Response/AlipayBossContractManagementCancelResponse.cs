using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossContractManagementCancelResponse.
    /// </summary>
    public class AlipayBossContractManagementCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 撤销操作提示
        /// </summary>
        [JsonPropertyName("result_set")]
        public string ResultSet { get; set; }
    }
}
