using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IotDeviceModel Data Structure.
    /// </summary>
    public class IotDeviceModel : AlipayObject
    {
        /// <summary>
        /// 该型号所属类目的类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 型号支持的配网链接类型, 取值可为WiFi，BlueTooth
        /// </summary>
        [JsonPropertyName("connection_types")]
        public List<string> ConnectionTypes { get; set; }

        /// <summary>
        /// 配网链接地址
        /// </summary>
        [JsonPropertyName("connection_url")]
        public string ConnectionUrl { get; set; }

        /// <summary>
        /// 关于型号的描述信息
        /// </summary>
        [JsonPropertyName("decription")]
        public string Decription { get; set; }

        /// <summary>
        /// 型号的图标图片地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识一个设备型号的型号id
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备型号的名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }
    }
}
