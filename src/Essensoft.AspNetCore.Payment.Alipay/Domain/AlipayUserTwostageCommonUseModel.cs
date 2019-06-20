using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserTwostageCommonUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserTwostageCommonUseModel : AlipayObject
    {
        /// <summary>
        /// 商户扫描用户的付款码值。
        /// </summary>
        [JsonProperty("dynamic_id")]
        public string DynamicId { get; set; }

        /// <summary>
        /// 商家进行二阶段支付的PID信息。
        /// </summary>
        [JsonProperty("pay_pid")]
        public string PayPid { get; set; }

        /// <summary>
        /// 此项为商户收单时的商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复。（请参考alipay.trade.pay接口的out_trade_no字段）
        /// </summary>
        [JsonProperty("sence_no")]
        public string SenceNo { get; set; }
    }
}
