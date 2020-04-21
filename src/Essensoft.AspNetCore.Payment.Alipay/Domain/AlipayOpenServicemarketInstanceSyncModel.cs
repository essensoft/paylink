using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketInstanceSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketInstanceSyncModel : AlipayObject
    {
        /// <summary>
        /// 2088101118588888
        /// </summary>
        [JsonPropertyName("consumer_uid")]
        public string ConsumerUid { get; set; }

        /// <summary>
        /// 生效时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        /// 过期时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 金融科技产品码
        /// </summary>
        [JsonPropertyName("fin_tech_product_code")]
        public string FinTechProductCode { get; set; }

        /// <summary>
        /// 最后修改时间，用做防请求乱序，针对同一条数据的更新，如果值小于上一个请求的值，该次请求会被丢弃。建议使用数据的修改时间，或者乐观锁的version作为参数值。
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public long GmtModified { get; set; }

        /// <summary>
        /// 实例标识
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 金融科技实例状态
        /// </summary>
        [JsonPropertyName("instance_status")]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
