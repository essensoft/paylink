using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataVisitQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataVisitQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询数据范围；APP_SUMMARY代表仅查询小程序的访问数据，AREA_DETAIL代表同时查询区域下该小程序的访问数据
        /// </summary>
        [JsonPropertyName("data_scope")]
        public string DataScope { get; set; }

        /// <summary>
        /// 国标六位省份行政区划编码，参考http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/；data_scope传入AREA_DETAIL时该参数有效，传空表示同时查询各省的访问数据，否则同时查询该省份行政区划下的各城市访问数据。
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }
    }
}
