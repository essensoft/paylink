using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenIotDeviceQueryResponse.
    /// </summary>
    public class AlipayOpenIotDeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回设备-商户绑定关系相关数据。注意事项：1）设备绑定接口传入的merchantId字段，间连场景返回smid字段，直连场景返回pid字段；2）如果没有查询到相关绑定信息，则返回为空。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
