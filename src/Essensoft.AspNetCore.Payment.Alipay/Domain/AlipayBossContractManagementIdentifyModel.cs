using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossContractManagementIdentifyModel Data Structure.
    /// </summary>
    public class AlipayBossContractManagementIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 访问接口的来源（如：采购系统-ALI_PURCHASE_SYSTEM）
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约批次列表
        /// </summary>
        [JsonPropertyName("contracts")]
        public List<BatchInfo> Contracts { get; set; }
    }
}
