using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardDeleteResponse.
    /// </summary>
    public class AlipayMarketingCardDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝端删卡业务流水号
        /// </summary>
        [JsonProperty("biz_serial_no")]
        public string BizSerialNo { get; set; }
    }
}
