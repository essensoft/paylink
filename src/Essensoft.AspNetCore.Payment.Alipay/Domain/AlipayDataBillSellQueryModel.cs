using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillSellQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillSellQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝交易流水号。如果查询参数中指定流水号，则只查询流水号相关的记录
        /// </summary>
        [JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 卖出交易流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户交易号。如果查询参数中指定交易号，则只查询相关的记录
        /// </summary>
        [JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 卖出交易流水创建时间的起始范围
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 门店编号，模糊搜索
        /// </summary>
        [JsonProperty("store_no")]
        public string StoreNo { get; set; }
    }
}
