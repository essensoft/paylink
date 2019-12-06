using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransCollectSinglemoneytokenCreateModel Data Structure.
    /// </summary>
    public class AlipayFundTransCollectSinglemoneytokenCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务回调通知参数,由业务方定义,用于支付成功后mnotify回调通知透传
        /// </summary>
        [JsonPropertyName("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 收款模式,枚举类型: 0 普通收钱 1 一码一付 2 一人一付，微供场景填2
        /// </summary>
        [JsonPropertyName("collect_mode")]
        public string CollectMode { get; set; }

        /// <summary>
        /// 订单过期时间戳,指定单据过期时间,必须大于当前时间,精确到秒,
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 扩展参数,对于一些CTU需要使用的参数请通过该参数传递
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部单据号,微供1688场景对应商品订单号,用作幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 渠道来源,由接口业务方分配,目前微供1688场景传递1688
        /// </summary>
        [JsonPropertyName("out_channel")]
        public string OutChannel { get; set; }

        /// <summary>
        /// 收款金额,单位元
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 收款备注,显示在支付宝账单,不传不展示,不支持emoji表情符号
        /// </summary>
        [JsonPropertyName("pay_memo")]
        public string PayMemo { get; set; }

        /// <summary>
        /// 进入付款的模式,枚举类型:1吱口令，2二维码
        /// </summary>
        [JsonPropertyName("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 收款方支付宝用户ID,对于微供吱口令场景即微商支付宝用户ID
        /// </summary>
        [JsonPropertyName("payee_user_id")]
        public string PayeeUserId { get; set; }
    }
}
