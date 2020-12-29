using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchApplyPageQueryRequest Data Structure.
    /// </summary>
    public class SearchApplyPageQueryRequest : AlipayObject
    {
        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 筛选状态数组 AUDIT AGREE REJECT CANCEL EDIT
        /// </summary>
        [JsonPropertyName("audit_status_list")]
        public List<string> AuditStatusList { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面的显示记录条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 起始记录，起始：0
        /// </summary>
        [JsonPropertyName("start_row")]
        public string StartRow { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [JsonPropertyName("sub_service_code")]
        public string SubServiceCode { get; set; }
    }
}
