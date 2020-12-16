using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 买家在支付宝的用户id。通过userid+请求流水号组合查询时，此字段不可为空。
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧花呗冻结、解冻操作单据id。在原先的冻结或者解冻接口调用中同步返回给商户，或者通过商户通知返回给商户。按订单号查询时，此字段不可为空。
        /// </summary>
        [JsonPropertyName("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 商户原先调用冻结、解冻接口传入的请求流水号。按照流水号查询订单时，此字段不能为空。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
