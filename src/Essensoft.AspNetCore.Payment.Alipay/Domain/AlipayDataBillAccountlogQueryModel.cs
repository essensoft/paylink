using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillAccountlogQueryModel Data Structure.
    /// </summary>
    public class AlipayDataBillAccountlogQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务流水创建时间的起始范围
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
