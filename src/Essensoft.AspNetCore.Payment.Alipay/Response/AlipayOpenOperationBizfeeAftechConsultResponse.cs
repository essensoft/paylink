using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechConsultResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 收费项计价结果列表（List<POJO>的JSON对象） POJO中包含feeItemCode收费项编码、eventCode事件码、price计价结果金额、highPrecisionPrice高精度计价结果金额、currency币种、settleType结算类型。
        /// </summary>
        [JsonPropertyName("consult_details")]
        public string ConsultDetails { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }
    }
}
