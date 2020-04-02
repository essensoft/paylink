using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeSettleReceivablesQueryModel Data Structure.
    /// </summary>
    public class AlipayTradeSettleReceivablesQueryModel : AlipayObject
    {
        /// <summary>
        /// 收单产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public SettleEntity MerchantInfo { get; set; }

        /// <summary>
        /// 外部请求号，32个字符以内，可包含字母、数字、下划线。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 查询历史日期，格式为 yyyyMMdd ，取值范围为昨日起至往前30日内； 不传入时，查询实时待结算余额返回； 传入过去某一天日期，查询对应日期的日终待结算余额返回（注意：日常场景下，昨日日终待结算余额只可在当天 02:00 后查询，在当天 02:00 前查询返回查询错误；大促场景下昨日日终可查时间会适当延后）； 传入过去某一天非近30天内，返回参数错误；
        /// </summary>
        [JsonPropertyName("query_his_date")]
        public string QueryHisDate { get; set; }
    }
}
