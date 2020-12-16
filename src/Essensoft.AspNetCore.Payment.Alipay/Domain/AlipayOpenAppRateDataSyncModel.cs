using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppRateDataSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppRateDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 管控状态
        /// </summary>
        [JsonPropertyName("control_status")]
        public long ControlStatus { get; set; }

        /// <summary>
        /// 支付宝用户信息: in_biz_account和out_biz_account必须要有一个
        /// </summary>
        [JsonPropertyName("in_biz_account")]
        public string InBizAccount { get; set; }

        /// <summary>
        /// 操作类型.INSERT:插入,UPDATE:更新
        /// </summary>
        [JsonPropertyName("oper_type")]
        public string OperType { get; set; }

        /// <summary>
        /// 业务私域用户信息：in_biz_account和out_biz_account必须要有一个
        /// </summary>
        [JsonPropertyName("out_biz_account")]
        public string OutBizAccount { get; set; }

        /// <summary>
        /// 评价ID：type=Rated时必填
        /// </summary>
        [JsonPropertyName("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// 评分：type=NotRated时必填
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 评价来源.KOUBEI:口碑,MINIAPP:小程序,OFFLINE:线下门店
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 数据类型.Rated:评价完成消息,NotRated:逾期未评价信息
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
