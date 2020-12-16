using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserTwostageCommonUseModel Data Structure.
    /// </summary>
    public class AlipayUserTwostageCommonUseModel : AlipayObject
    {
        /// <summary>
        /// 商户扫描用户的付款码值。
        /// </summary>
        [JsonPropertyName("dynamic_id")]
        public string DynamicId { get; set; }

        /// <summary>
        /// 传1表示 校验pid(pay_pid)和来支付的时候的pid一致性； 传2表示校验pid(pay_pid)和来支付的时候的pid一致性、校验scene_no和来支付时DYNAMIC_TOKEN_OUT_BIZ_NO属性一致；                        不传值和value=2的表现一致
        /// </summary>
        [JsonPropertyName("pay_check_strategy")]
        public string PayCheckStrategy { get; set; }

        /// <summary>
        /// 商家进行二阶段支付的PID信息。
        /// </summary>
        [JsonPropertyName("pay_pid")]
        public string PayPid { get; set; }

        /// <summary>
        /// 外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.user.twostage.common.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致。
        /// </summary>
        [JsonPropertyName("sence_no")]
        public string SenceNo { get; set; }
    }
}
