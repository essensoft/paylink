using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractInfo Data Structure.
    /// </summary>
    public class ContractInfo : AlipayObject
    {
        /// <summary>
        /// 合同金额（元）
        /// </summary>
        [JsonPropertyName("contract_amount")]
        public string ContractAmount { get; set; }

        /// <summary>
        /// 合同文件信息列表
        /// </summary>
        [JsonPropertyName("contract_file_infos")]
        public List<ContractFileInfo> ContractFileInfos { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 币种（如：CNY）
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 合同对手方公司名称列表
        /// </summary>
        [JsonPropertyName("parse_participant_infos")]
        public List<string> ParseParticipantInfos { get; set; }

        /// <summary>
        /// 合同本方公司名称列表
        /// </summary>
        [JsonPropertyName("self_participant_infos")]
        public List<string> SelfParticipantInfos { get; set; }
    }
}
