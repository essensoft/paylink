using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointAccountLog Data Structure.
    /// </summary>
    [Serializable]
    public class PointAccountLog : AlipayObject
    {
        /// <summary>
        /// 账务流水号,与"我的集分宝"页面流水号保持一致
        /// </summary>
        [JsonProperty("account_log_id")]
        public string AccountLogId { get; set; }

        /// <summary>
        /// 该笔交易后该账户余额，值为集分宝个数
        /// </summary>
        [JsonProperty("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号,集分宝充值时淘宝传递给微账务的订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易金额,集分宝个数,如果个数小于0则是支出,大于0是收入
        /// </summary>
        [JsonProperty("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 子交易代码
        /// </summary>
        [JsonProperty("sub_trans_code")]
        public string SubTransCode { get; set; }

        /// <summary>
        /// 子交易代码对应中文翻译,如果不想依赖我们的枚举可以使用这个值
        /// </summary>
        [JsonProperty("sub_trans_code_cn")]
        public string SubTransCodeCn { get; set; }

        /// <summary>
        /// 交易代码
        /// </summary>
        [JsonProperty("trans_code")]
        public string TransCode { get; set; }

        /// <summary>
        /// 账务执行时间
        /// </summary>
        [JsonProperty("trans_date")]
        public string TransDate { get; set; }

        /// <summary>
        /// 交易备注信息
        /// </summary>
        [JsonProperty("trans_memo")]
        public string TransMemo { get; set; }
    }
}
