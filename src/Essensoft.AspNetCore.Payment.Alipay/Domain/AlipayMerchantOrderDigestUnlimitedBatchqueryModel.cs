using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderDigestUnlimitedBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderDigestUnlimitedBatchqueryModel : AlipayObject
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
        /// 查询订单所属的appid，该appid必须为签约商户下的appid    注：若为空，则返回订单列表不按照appid进行筛选
        /// </summary>
        [JsonProperty("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商户的uid，即所需查询订单的partnerId
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 所需查询的订单来源    取值范围：  ALL-全部订单来源（默认值）  TINY_APP-来自小程序的订单
        /// </summary>
        [JsonProperty("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 查询条数  取值范围：[1,50]    注：若start_time与end_time之间的总条数大于size，则按照订单支付时间倒序取前size条；若总条数小于size，则按照订单支付时间倒序，返回实际条数
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// 查询开始时间，格式为：yyyy-MM-dd hh:mm:ss    查询返回的订单支付时间在start_time之后，不包括start_time
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
