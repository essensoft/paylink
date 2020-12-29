using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderDetailDataInfo Data Structure.
    /// </summary>
    public class SearchOrderDetailDataInfo : AlipayObject
    {
        /// <summary>
        /// 申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序类目名
        /// </summary>
        [JsonPropertyName("app_category")]
        public string AppCategory { get; set; }

        /// <summary>
        /// 小程序图标
        /// </summary>
        [JsonPropertyName("app_icon")]
        public string AppIcon { get; set; }

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
        /// 小程序id
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [JsonPropertyName("base_order_status")]
        public OrderStatusData BaseOrderStatus { get; set; }

        /// <summary>
        /// bizid 业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 服务box状态
        /// </summary>
        [JsonPropertyName("box_order_status")]
        public OrderStatusData BoxOrderStatus { get; set; }

        /// <summary>
        /// 上下架状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [JsonPropertyName("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 品牌box状态
        /// </summary>
        [JsonPropertyName("brandbox_orderstatus")]
        public OrderStatusData BrandboxOrderstatus { get; set; }

        /// <summary>
        /// 是否可修改关键词
        /// </summary>
        [JsonPropertyName("can_modify_keyword")]
        public bool CanModifyKeyword { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 基础工单详情信息
        /// </summary>
        [JsonPropertyName("detail_base_items")]
        public SearchOrderDetailDataBaseItems DetailBaseItems { get; set; }

        /// <summary>
        /// 品牌工单详情数据
        /// </summary>
        [JsonPropertyName("detail_brand_items")]
        public SearchOrderDetailDataBrandItems DetailBrandItems { get; set; }

        /// <summary>
        /// 服务工单数据详情
        /// </summary>
        [JsonPropertyName("detail_service_items")]
        public SearchOrderDetailDataServiceItems DetailServiceItems { get; set; }

        /// <summary>
        /// 最终状态
        /// </summary>
        [JsonPropertyName("final_status")]
        public string FinalStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonPropertyName("gmtmodified")]
        public string Gmtmodified { get; set; }

        /// <summary>
        /// 关键词的修改时间
        /// </summary>
        [JsonPropertyName("keyword_gmt_modified")]
        public string KeywordGmtModified { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonPropertyName("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 操作人员类型
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 查询服务提供者生态类型 一二三方 1 | 2 | 3
        /// </summary>
        [JsonPropertyName("partner_type")]
        public string PartnerType { get; set; }

        /// <summary>
        /// 驳回节点
        /// </summary>
        [JsonPropertyName("reject_node")]
        public string RejectNode { get; set; }

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
        /// 服务code
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [JsonPropertyName("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
