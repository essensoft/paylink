using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceGroup Data Structure.
    /// </summary>
    public class DeviceGroup : AlipayObject
    {
        /// <summary>
        /// 业务类型-代表不同的业务场景 distribution表示服务分发
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 该分组的设备数
        /// </summary>
        [JsonPropertyName("device_count")]
        public long DeviceCount { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
