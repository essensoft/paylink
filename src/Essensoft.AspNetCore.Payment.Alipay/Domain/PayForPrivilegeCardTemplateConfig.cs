using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateConfig Data Structure.
    /// </summary>
    public class PayForPrivilegeCardTemplateConfig : AlipayObject
    {
        /// <summary>
        /// 卡模板的辅助信息项列表
        /// </summary>
        [JsonPropertyName("auxiliary_item_list")]
        public List<PayForPrivilegeCardTemplateAuxiliaryItem> AuxiliaryItemList { get; set; }

        /// <summary>
        /// 卡模板头部设置
        /// </summary>
        [JsonPropertyName("header")]
        public PayForPrivilegeCardTemplateHeaderConfig Header { get; set; }

        /// <summary>
        /// 卡模板的操作项列表
        /// </summary>
        [JsonPropertyName("operation_item_list")]
        public List<PayForPrivilegeCardTemplateOperationItem> OperationItemList { get; set; }

        /// <summary>
        /// 二级区域列表
        /// </summary>
        [JsonPropertyName("secondary_item_list")]
        public List<PayForPrivilegeCardTemplateSecondaryItem> SecondaryItemList { get; set; }
    }
}
