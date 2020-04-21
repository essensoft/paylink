using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainOrderApplyResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainOrderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 法链业务ID,用于查询上链状态
        /// </summary>
        [JsonPropertyName("bas_data_id")]
        public string BasDataId { get; set; }
    }
}
