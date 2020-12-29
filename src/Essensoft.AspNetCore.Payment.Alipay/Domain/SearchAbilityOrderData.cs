using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchAbilityOrderData Data Structure.
    /// </summary>
    public class SearchAbilityOrderData : AlipayObject
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
        /// 小程序状态 ON_LINE、OFF_LINE
        /// </summary>
        [JsonPropertyName("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// bizId 为品牌box的boxID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 品牌box的上下架状态 ONLINE OFFLINE
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [JsonPropertyName("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 二级服务信息
        /// </summary>
        [JsonPropertyName("children")]
        public List<SearchAbilityOrderInfoOpenApi> Children { get; set; }

        /// <summary>
        /// 二级服务的唯一标识
        /// </summary>
        [JsonPropertyName("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 服务的唯一标识（优先使用serviceCode可忽略）
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否是老工单
        /// </summary>
        [JsonPropertyName("is_old_data")]
        public string IsOldData { get; set; }

        /// <summary>
        /// 服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效
        /// </summary>
        [JsonPropertyName("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonPropertyName("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 服务的可见性状态
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
