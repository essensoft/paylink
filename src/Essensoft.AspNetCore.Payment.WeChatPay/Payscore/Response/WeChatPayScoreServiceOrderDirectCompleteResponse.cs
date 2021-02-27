using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response
{
    /// <summary>
    ///  微信支付分 - 创单结单合并
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">创单结单合并API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderDirectCompleteResponse : WeChatPayScoreResponseBase
    {
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
        /// 服务订单状态
        /// </summary>
        /// <remarks>
        /// 表示当前单据状态。
        ///  枚举值：
        ///  1、DOING：服务订单进行中
        ///  2、DONE：服务订单完成
        ///  示例值：DOING
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        /// <remarks>
        /// 对服务订单"进行中"状态的附加说明。
        /// 1、MCH_COMPLETE：商户完结
        /// 示例值：MCH_COMPLETE
        /// </remarks>
        [JsonPropertyName("state_description")]
        public string StateDescription { get; set; }
        
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

        /// <summary>
        /// 商户收款总金额
        /// </summary>
        /// <remarks>
        /// 总金额，大于等于0的数字，单位为分，只能为整数，详见支付金额。
        /// 此参数需满足：总金额=后付费项目金额之和-后付费商户优惠项目金额之和，且小于等于订单风险金额。取消订单时，该字段必须为0。
        /// 示例值：40000
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }
    }
}
