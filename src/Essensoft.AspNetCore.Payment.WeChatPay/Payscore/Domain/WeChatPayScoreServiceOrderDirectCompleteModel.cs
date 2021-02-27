using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 创单结单合并
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">创单结单合并API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderDirectCompleteModel : WeChatPayScoreModelBase
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部服务订单号（不是交易单号），要求此参数只能由数字、大小写字母_-|*组成，且在同一个商户号下唯一。
        /// 详见[商户订单号]。示例值：1234323JKHDFE1243252
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        /// <remarks>
        /// 服务信息，用于介绍本订单所提供的服务 ，当参数长度超过20个字符时，报错处理。
        /// 示例值：某某酒店
        /// </remarks>
        [JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; }

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
        /// 总金额       
        /// </summary>
        /// <remarks>
        /// 1、金额：数字，必须≥0（单位：分）
        /// 2、总金额 =（完结付费项目1…+完结付费项目n）-（完结商户优惠项目1…+完结商户优惠项目n）
        /// 3、总金额上限：总金额≤“服务风险金额”
        /// 示例值：50000
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

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

        /// <summary>
        /// 商户数据包
        /// </summary>
        /// <remarks>
        /// 商户数据包可存放本订单所需信息，需要先urlencode后传入。 当商户数据包总长度超出256字符时，报错处理。
        /// 示例值：Easdfowealsdkjfnlaksjdlfkwqoi&wl3l2sald
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 商户回调地址
        /// </summary>
        /// <remarks>
        /// 商户接收用户确认订单和付款成功回调通知的地址。
        /// 示例值：https://api.test.com
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
