using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntLinkeDevopsMobiledeviceApplyModel Data Structure.
    /// </summary>
    public class AntLinkeDevopsMobiledeviceApplyModel : AlipayObject
    {
        /// <summary>
        /// device_id+唯一+如果包含则用来校验设备对应的信息+之前调用返回结果
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// model+唯一+指定使用的产品类型+2c4g/4c8g+显示指定+需要使用的产品类型,如果不指定则随机返回,2c4g优先
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// region+唯一+设备需要匹配的机房+参数
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// take_time+唯一+指定租用时长+显示指定+非必选+默认值120分钟
        /// </summary>
        [JsonPropertyName("take_time")]
        public long TakeTime { get; set; }
    }
}
