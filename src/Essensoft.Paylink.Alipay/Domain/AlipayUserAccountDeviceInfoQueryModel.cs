using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAccountDeviceInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备号数组，对应设备类型为device_type字段代表的设备类型。为兼容而保留，参数已经被devices取代。devices不存在的时候是必填。
        /// </summary>
        [JsonPropertyName("device_ids")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 设备类型，包括OAID，IMEI、IDFA、MOBILE(大小写敏感）。为兼容而保留，参数已经被devices取代。devices不存在的时候是必填。
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 1. devices字段内容为JSON串； 2. devices每一个直接的key代表一个设备 3. 一个设备可以包含一个或多个设备类型信息（IDFA，IMEI，OAID，MOBILE），类型信息不许重复；  示例： {   "unique_key_1": { // 唯一key，调用方自己定义，用来标识设备     "OAID": {       "device_id": "id1",       "encrypt_type": "MD5"     },     "IMEI": {       "device_id": "id2",       "encrypt_type": "MD5"     },     "IDFA": {       "device_id": "id3",       "encrypt_type": "MD5"     },     "MOBILE": {       "device_id": "id4",       "encrypt_type": "MD5"     }   },   "unique_key_2": { // 唯一key，调用方自己定义，用来标识设备     ... // 填写需要咨询的设备类型，ID和加密类型   } }
        /// </summary>
        [JsonPropertyName("devices")]
        public string Devices { get; set; }

        /// <summary>
        /// 设备id的加密方式，不传认为设备号没有加密。当前支持类型为MD5。为兼容而保留，参数已经被devices取代。
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 扩展参数，如设备系统类型，系统版本等,格式为基本字符串组成的json串
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 一般代表调用的合作机构名称，可写简称，大小写敏感。为兼容而保留，参数已经被devices取代。devices不存在的时候是必填。
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }
    }
}
