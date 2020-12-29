using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderCreateRequest Data Structure.
    /// </summary>
    public class SearchOrderCreateRequest : AlipayObject
    {
        /// <summary>
        /// 创建方式
        /// </summary>
        [JsonPropertyName("access_mode")]
        public string AccessMode { get; set; }

        /// <summary>
        /// 搜索直达类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 处理动作 on off
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 小程序名字
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 基础信息申请单提报详情
        /// </summary>
        [JsonPropertyName("base_items")]
        public SearchBaseItems BaseItems { get; set; }

        /// <summary>
        /// bizId 为品牌box的boxID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 品牌box降级
        /// </summary>
        [JsonPropertyName("brand_down_grade")]
        public bool BrandDownGrade { get; set; }

        /// <summary>
        /// 品牌box申请单提报详情
        /// </summary>
        [JsonPropertyName("brand_items")]
        public SearchBrandItems BrandItems { get; set; }

        /// <summary>
        /// 申请单创建来源类型
        /// </summary>
        [JsonPropertyName("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 二级服务唯一标识
        /// </summary>
        [JsonPropertyName("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("descprise")]
        public string Descprise { get; set; }

        /// <summary>
        /// 是否为草稿态
        /// </summary>
        [JsonPropertyName("is_draft")]
        public bool IsDraft { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonPropertyName("key_words")]
        public string KeyWords { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonPropertyName("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 父工单id
        /// </summary>
        [JsonPropertyName("ref_apply_id")]
        public string RefApplyId { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

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
        /// 服务申请单提报信息详情
        /// </summary>
        [JsonPropertyName("service_items")]
        public SearchServiceItems ServiceItems { get; set; }

        /// <summary>
        /// 服务的类型 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [JsonPropertyName("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 搜索模板id 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 搜索模板类型
        /// </summary>
        [JsonPropertyName("template_type")]
        public string TemplateType { get; set; }
    }
}
