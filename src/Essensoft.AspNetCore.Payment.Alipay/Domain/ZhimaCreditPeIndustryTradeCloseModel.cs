using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryTradeCloseModel : AlipayObject
    {
        /// <summary>
        /// 关闭时间,接入方通过其他渠道实际收款时间,应小于当前时间. 可空,不传将默认取服务器当前时间
        /// </summary>
        [JsonProperty("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作类型,close:资金单关闭,finish:资金单完结,已经通过其他渠道完成交易
        /// </summary>
        [JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 商户扣款时传入的扣款资金单号，需要保证唯一
        /// </summary>
        [JsonProperty("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonProperty("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
