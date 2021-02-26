using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 修改订单金额API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderModifyModel : WeChatPayScoreModelBase
    {
        /// <summary>
        /// 后付费项目
        /// </summary>
        /// <remarks>
        /// 后付费项目列表，最多包含100条付费项目。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_payments")]
        public List<PostPayment> PostPayments { get; set; }

        /// <summary>
        /// 后付费商户优惠
        /// </summary>
        /// <remarks>
        /// 后付费商户优惠列表，最多包含30条商户优惠。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_discounts")]
        public List<ModifyPostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 总金额       
        /// </summary>
        /// <remarks>
        /// 总金额，单位为分，不能超过完结订单时候的总金额，只能为整数，详见支付金额。此参数需满足：总金额 =（修改后付费项目1…+修改后完结付费项目n）-（修改 后付费商户优惠项目1…+修改后付费商户优惠项目n）
        /// 示例值：50000
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 修改原因
        /// </summary>
        /// <remarks>
        /// 按照字符计算，超过长度报错处理。
        /// 示例值：用户投诉
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
