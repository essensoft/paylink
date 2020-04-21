using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpRatingInnerInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpRatingInnerInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻企业信用客户评估单号，商户应该妥善关联持久化保存该订单号用于后续的对账。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
