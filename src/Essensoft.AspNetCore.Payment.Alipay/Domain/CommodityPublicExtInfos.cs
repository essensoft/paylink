using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommodityPublicExtInfos Data Structure.
    /// </summary>
    public class CommodityPublicExtInfos : AlipayObject
    {
        /// <summary>
        /// 前置url
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 应用展台id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [JsonPropertyName("create_user_id")]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 挂载ID，用于确认唯一记录的主键对象
        /// </summary>
        [JsonPropertyName("displayapp_id")]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 城市服务说明
        /// </summary>
        [JsonPropertyName("displayapp_memo")]
        public string DisplayappMemo { get; set; }

        /// <summary>
        /// 服务别名
        /// </summary>
        [JsonPropertyName("displayapp_name")]
        public string DisplayappName { get; set; }

        /// <summary>
        /// 状态 1:上架；0：下架；2:维护中
        /// </summary>
        [JsonPropertyName("displayapp_status")]
        public string DisplayappStatus { get; set; }

        /// <summary>
        /// 用户访问地址
        /// </summary>
        [JsonPropertyName("displayapp_url")]
        public string DisplayappUrl { get; set; }

        /// <summary>
        /// 外部展示地址
        /// </summary>
        [JsonPropertyName("export_url")]
        public string ExportUrl { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [JsonPropertyName("property_id")]
        public string PropertyId { get; set; }
    }
}
