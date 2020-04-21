using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotWifiStatusQueryResponse.
    /// </summary>
    public class AlipayCommerceIotWifiStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前wifi名称
        /// </summary>
        [JsonPropertyName("cur_ssid")]
        public string CurSsid { get; set; }

        /// <summary>
        /// 设备扫码出来的ssid名称列表
        /// </summary>
        [JsonPropertyName("ssid_list")]
        public List<string> SsidList { get; set; }

        /// <summary>
        /// 当前设备的wifi状态  1.表示2G联网  2.表示wifi联网
        /// </summary>
        [JsonPropertyName("wifi_type")]
        public long WifiType { get; set; }
    }
}
