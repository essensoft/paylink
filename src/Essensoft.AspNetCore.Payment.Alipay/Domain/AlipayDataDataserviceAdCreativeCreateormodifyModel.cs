using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 创意交互行为属性实例值
        /// </summary>
        [JsonPropertyName("action_property_list")]
        public List<ActionProperty> ActionPropertyList { get; set; }

        /// <summary>
        /// 落地页动作类型，NO_ACTION-无动作；LP-普通落地页；OPEN_TINYAPP-打开小程序；OPEN_CHANNELS-打开生活号；COLLECT_TINYAPP-收藏小程序；
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 转化监控URL，如留资等
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 创意补充资质
        /// </summary>
        [JsonPropertyName("attachment_list")]
        public List<OuterAttachment> AttachmentList { get; set; }

        /// <summary>
        /// 创意分组标识，多个创意可按业务逻辑标识为一个分组
        /// </summary>
        [JsonPropertyName("batch_tag")]
        public string BatchTag { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 点击监控URL
        /// </summary>
        [JsonPropertyName("click_track_url")]
        public string ClickTrackUrl { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [JsonPropertyName("creative_outer_id")]
        public string CreativeOuterId { get; set; }

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
        /// 展现监控URL
        /// </summary>
        [JsonPropertyName("impression_track_url")]
        public string ImpressionTrackUrl { get; set; }

        /// <summary>
        /// 门店LBS信息，目前仅口碑使用，格式为：经度:纬度:半径(单位:KM,无半径限制直接设置为0)
        /// </summary>
        [JsonPropertyName("lbs_list")]
        public List<string> LbsList { get; set; }

        /// <summary>
        /// 创意关联物料元素列表
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialUnit> MaterialList { get; set; }

        /// <summary>
        /// 创意名称，同一单元下的创意名称不能重复，默认设置为门店名称+outer_id
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门店创意关联的城市ID列表，目前仅口碑使用
        /// </summary>
        [JsonPropertyName("region_list")]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// 创意状态，ENABLE-生效；PAUSE-暂停
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店创意关联门店ID，目前仅口碑使用
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 落地页关联的支付宝生活号或小程序关联appId
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
    }
}
