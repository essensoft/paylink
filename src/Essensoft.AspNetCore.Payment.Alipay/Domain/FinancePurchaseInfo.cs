using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinancePurchaseInfo Data Structure.
    /// </summary>
    public class FinancePurchaseInfo : AlipayObject
    {
        /// <summary>
        /// 采购内容描述
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文件信息列表
        /// </summary>
        [JsonPropertyName("file_list")]
        public List<FinanceFileInfo> FileList { get; set; }
    }
}
