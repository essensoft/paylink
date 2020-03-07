using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoUploadModel Data Structure.
    /// </summary>
    public class AlipayUserAccountDeviceInfoUploadModel : AlipayObject
    {
        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonPropertyName("call_back")]
        public string CallBack { get; set; }

        /// <summary>
        /// 设备id，必须和device_type一一对应，即如果传的是device_type=IDFA，则改字段传设备id，如果device_type=IMEI，传设备IMEI号.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型:IMEI、IDFA、MOBILE等(大小写敏感)
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备id的加密方式,如没有加 密,可以不传。一般sha256即可满足需求,如其他方式,请提前和支付宝技术支持联系
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 扩展参数，如设备系统类型，系统版本等,格式为基本字符串组成的json串
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 链接参数信息，格式为基本字符串组成的json串
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 一般代表调用的合作机构名称,可写简称,大小写敏感
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }
    }
}
