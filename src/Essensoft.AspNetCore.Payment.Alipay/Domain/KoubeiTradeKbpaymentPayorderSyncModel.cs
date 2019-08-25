using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeKbpaymentPayorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeKbpaymentPayorderSyncModel : AlipayObject
    {
        /// <summary>
        /// 附加数据，在查询API和支付通知中原样返回，该字段主要用于第三方系统携带订单的自定义数据
        /// </summary>
        [JsonProperty("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY
        /// </summary>
        [JsonProperty("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 口碑触发外部支付时，对应的口碑支付单据号；
        /// </summary>
        [JsonProperty("fund_command_id")]
        public string FundCommandId { get; set; }

        /// <summary>
        /// 第三方支付回执状态标识；SUCCESS：标识支付成功；FAIL：标识支付失败
        /// </summary>
        [JsonProperty("fund_status")]
        public string FundStatus { get; set; }

        /// <summary>
        /// 一笔支付行为中，使用的红包和代金券列表
        /// </summary>
        [JsonProperty("fund_tool_list")]
        public List<KbpFundTool> FundToolList { get; set; }

        /// <summary>
        /// 支付完成时间，当fund_status=SUCCESS时必填；格式为yyyyMMddHHmmss，如2009年12月25日9点10分10秒表示为20091225091010
        /// </summary>
        [JsonProperty("gmt_finish")]
        public string GmtFinish { get; set; }

        /// <summary>
        /// 第三方支付单据号，比如在微信支付场景下，为微信支付订单号
        /// </summary>
        [JsonProperty("out_pay_id")]
        public string OutPayId { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 第三方支付单总金额；单位：分；在回执报文传入成功时，会校验该值，如果不一致，不会驱动业务；该值为正整数数值字符串；
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
    }
}
