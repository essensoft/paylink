using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SmartAddressInfo Data Structure.
    /// </summary>
    public class SmartAddressInfo : AlipayObject
    {
        /// <summary>
        /// 行政区代码-区，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【区】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [JsonPropertyName("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 行政区代码-市，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【市】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [JsonPropertyName("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 自助售货机地址
        /// </summary>
        [JsonPropertyName("machine_address")]
        public string MachineAddress { get; set; }

        /// <summary>
        /// 行政区代码-省，使用蚂蚁标准行政区划代码，可参考 http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/2020/index.html 注意：【省】 代码请使用由左开始的 6 位数字。
        /// </summary>
        [JsonPropertyName("province_code")]
        public long ProvinceCode { get; set; }
    }
}
