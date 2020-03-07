using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthSignApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthSignApplyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的用户id。用于水平校验，当传入用户id与实际唤起支付宝用户id不一致时，签约申请失败。特殊业务(用户在商户侧已经绑定了支付宝A，不允许支付宝B进行开通花芝)需求定制，无特殊需求时不要传入此商户
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部渠道标识
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 自定义冻结金额，单位：元。部分商户开放，需要申请
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 外部请求号，对应一次请求交互流水，由调用方生成
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部签约号，调用方需要保证唯一
        /// </summary>
        [JsonPropertyName("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 支付宝商家ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 模版ID，对接时联系技术支持确定
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚完成时间，逾期支付宝将关闭。取值范围：1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m。 订单关闭时，会发送关闭的商户通知，商户需要进行处理并标记对应的订单作废。默认为1h
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
