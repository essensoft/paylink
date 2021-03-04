using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryprocsumQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNotaryprocsumQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 法链业务ID,用于查询上链状态
        /// </summary>
        [JsonPropertyName("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 操作记录列表
        /// </summary>
        [JsonPropertyName("record_list")]
        public List<QueryRecord> RecordList { get; set; }
    }
}
