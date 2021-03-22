using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossContractGeneralCreateModel Data Structure.
    /// </summary>
    public class AlipayBossContractGeneralCreateModel : AlipayObject
    {
        /// <summary>
        /// 上游平台唯一识别
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 上游签约平台来源
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约列表,一个批次可能包含多个合约信息
        /// </summary>
        [JsonPropertyName("contract_list")]
        public List<ContractStartInfoOpenApiVO> ContractList { get; set; }

        /// <summary>
        /// 发起方式。 1、如果上游平台选择FULL_INFO方式，那么就按照格式传递信息。 2、如果上游平台与关联交易平台约定了通过某种方式反查合约信息，则可以省略传递字段
        /// </summary>
        [JsonPropertyName("start_type")]
        public string StartType { get; set; }
    }
}
