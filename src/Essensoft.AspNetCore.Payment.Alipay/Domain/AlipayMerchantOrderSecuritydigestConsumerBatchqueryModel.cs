using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSecuritydigestConsumerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSecuritydigestConsumerBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 结束时间，格式为：yyyy-MM-dd hh:mm:ss    查询返回的订单支付时间在end_time之前，不包括end_time    注：为了避免数据重复，可在start_time不变的情况下利用上一次返回列表中最后一条数据的支付时间作为下一次end_time的入参，实现分页查询
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询订单信息，该订单属于请求pid以及传入的appid    注：若为空，则返回订单列表不按照appid进行筛选
        /// </summary>
        [JsonProperty("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 查询条数  取值范围：[1,50]    注：若start_time与end_time之间的总条数大于size，则按照订单支付时间倒序取前size条；若总条数小于size，则按照订单支付时间倒序，返回实际条数
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// 查询开始时间，格式为：yyyy-MM-dd hh:mm:ss    查询返回的订单支付时间在start_time之后，包括start_time
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
