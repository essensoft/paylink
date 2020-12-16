using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreativeDetail Data Structure.
    /// </summary>
    public class CreativeDetail : AlipayObject
    {
        /// <summary>
        /// 落地页动作类型，NO_ACTION-无动作；LP-普通落地页；OPEN_TINYAPP-打开小程序；OPEN_CHANNELS-打开生活号；COLLECT_TINYAPP-收藏小程序；
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 创意最新审核工单号
        /// </summary>
        [JsonPropertyName("audit_order_id")]
        public string AuditOrderId { get; set; }

        /// <summary>
        /// 创意分组标识，多个创意可按业务逻辑标识为一个分组
        /// </summary>
        [JsonPropertyName("batch_tag")]
        public string BatchTag { get; set; }

        /// <summary>
        /// 创意点击量
        /// </summary>
        [JsonPropertyName("click")]
        public long Click { get; set; }

        /// <summary>
        /// 创意消费数据，单元：分
        /// </summary>
        [JsonPropertyName("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 广告投放平台生成的创意ID
        /// </summary>
        [JsonPropertyName("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [JsonPropertyName("creative_outer_id")]
        public string CreativeOuterId { get; set; }

        /// <summary>
        /// 创意关联的描述列表
        /// </summary>
        [JsonPropertyName("desc_list")]
        public List<TextInstance> DescList { get; set; }

        /// <summary>
        /// 创意业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放单元对应的外部资源ID
        /// </summary>
        [JsonPropertyName("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 创意关联的图片物料列表
        /// </summary>
        [JsonPropertyName("img_list")]
        public List<MaterialDetail> ImgList { get; set; }

        /// <summary>
        /// 创意展现量
        /// </summary>
        [JsonPropertyName("impression")]
        public long Impression { get; set; }

        /// <summary>
        /// 门店LBS信息，目前仅口碑使用，格式为：经度:纬度:半径(单位:KM,无半径限制直接设置为0)
        /// </summary>
        [JsonPropertyName("lbs_list")]
        public List<string> LbsList { get; set; }

        /// <summary>
        /// 创意名称，同一单元下的创意名称不能重复，默认设置为门店名称+outer_id
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放计划对应的外部资源ID
        /// </summary>
        [JsonPropertyName("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 广告投放平台生成委托人ID
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 创意审核拒绝的扩展信息
        /// </summary>
        [JsonPropertyName("refuse_extend_info")]
        public CreativeRefuseExtendInfo RefuseExtendInfo { get; set; }

        /// <summary>
        /// 创意审核拒绝原因
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 门店创意关联的城市ID列表，目前仅口碑使用
        /// </summary>
        [JsonPropertyName("region_list")]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// 创意状态，ENABLE-生效；PAUSE-暂停；DELETE-删除；AUDIT-审核中；REFUSED-审核拒绝
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店创意关联门店ID，目前仅口碑使用
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 落地页appId
        /// </summary>
        [JsonPropertyName("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 创意落地页url地址
        /// </summary>
        [JsonPropertyName("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 创意关联模板ID，由投放平台管理生成
        /// </summary>
        [JsonPropertyName("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 创意关联的标题列表
        /// </summary>
        [JsonPropertyName("title_list")]
        public List<TextInstance> TitleList { get; set; }

        /// <summary>
        /// 广告投放平台生成广告主/代理商ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 创意关联的视频物料列表
        /// </summary>
        [JsonPropertyName("video_list")]
        public List<MaterialDetail> VideoList { get; set; }
    }
}
