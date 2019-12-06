using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoFeeReceiveConfirmModel Data Structure.
    /// </summary>
    public class AlipayInsAutoFeeReceiveConfirmModel : AlipayObject
    {
        /// <summary>
        /// 外部业务单号，幂等字段，必填。和保险公司交互时同收单系统的outTradeNo
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易总金额 ;单位分
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public long TradeAmount { get; set; }
    }
}
