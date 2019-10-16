using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthSignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAuthSignApplyModel : AlipayObject
    {
        /// <summary>
        /// 外部渠道标识
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部请求号，对应一次请求交互流水，由调用方生成
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部签约号，调用方需要保证唯一
        /// </summary>
        [JsonProperty("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 支付宝商家ID
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 模版ID，对接时联系技术支持确定
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚完成时间，逾期支付宝将关闭。取值范围：1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m。 订单关闭时，会发送关闭的商户通知，商户需要进行处理并标记对应的订单作废。默认为1h
        /// </summary>
        [JsonProperty("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
