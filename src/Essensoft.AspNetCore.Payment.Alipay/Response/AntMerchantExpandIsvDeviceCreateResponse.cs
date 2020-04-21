using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 机具申请物料订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
