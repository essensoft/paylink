using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchAbilityOrderInfoOpenApi Data Structure.
    /// </summary>
    public class SearchAbilityOrderInfoOpenApi : AlipayObject
    {
        /// <summary>
        /// 申请单类型
        /// </summary>
        [JsonPropertyName("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        [JsonPropertyName("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 运营申请单详情biz_id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 上架状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌模板id
        /// </summary>
        [JsonPropertyName("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 二级服务唯一标识
        /// </summary>
        [JsonPropertyName("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否老工单
        /// </summary>
        [JsonPropertyName("is_old_data")]
        public bool IsOldData { get; set; }

        /// <summary>
        /// 服务主状态
        /// </summary>
        [JsonPropertyName("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonPropertyName("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 小程序可见性
        /// </summary>
        [JsonPropertyName("open_status")]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 下架操作者
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [JsonPropertyName("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("search_app_id")]
        public string SearchAppId { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [JsonPropertyName("sepc_code")]
        public string SepcCode { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 子功能描述
        /// </summary>
        [JsonPropertyName("sub_service_desc")]
        public string SubServiceDesc { get; set; }

        /// <summary>
        /// 子功能名称
        /// </summary>
        [JsonPropertyName("sub_service_name")]
        public string SubServiceName { get; set; }
    }
}
