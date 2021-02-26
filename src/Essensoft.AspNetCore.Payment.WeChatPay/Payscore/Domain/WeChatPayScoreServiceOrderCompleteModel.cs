using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 完结支付分订单
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml">完结支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderCompleteModel : WeChatPayScoreModelBase
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
        /// 服务时间范围
        /// </summary>
        [JsonPropertyName("time_range")]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置信息
        /// 如果传入，用户侧则显示此参数。
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 微信支付服务分账标记
        /// </summary>
        /// <remarks>
        /// 完结订单分账接口标记。分账开通流程，详见
        /// false：不分账，默认：false
        /// true：分账。
        /// 示例值：false
        /// </remarks>
        [JsonPropertyName("profit_sharing")]
        public bool ProfitSharing { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        /// <remarks>
        /// 订单优惠标记，代金券或立减金优惠的参数，说明详见代金券或立减金优惠
        /// 示例值：goods_tag
        /// </remarks>
        [JsonPropertyName("goods_tag")]
        public string GoodsTag { get; set; }
    }
}
