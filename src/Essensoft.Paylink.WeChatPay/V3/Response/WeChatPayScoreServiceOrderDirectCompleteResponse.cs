using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 微信支付分 - 创单结单合并 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">微信支付分 - 创单结单合并API</a> - 最新更新时间：2020.04.23</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderDirectCompleteResponse : WeChatPayResponse
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 调用接口提交的公众账号ID
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        /// <remarks>
        /// 调用接口提交的商户号。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户服务订单号
        /// </summary>
        /// <remarks>
        /// 调用接口提交的商户服务订单号。
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 调用该接口提交的服务ID。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        /// <remarks>
        /// 服务信息，用于介绍本订单所提供的服务。
        /// <para>示例值：某某酒店</para>
        /// </remarks>
        [JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; }

        /// <summary>
        /// 服务订单状态
        /// </summary>
        /// <remarks>
        /// 表示当前单据状态。
        /// 枚举值：
        /// 1、DOING：服务订单进行中
        /// 2、DONE：服务订单完成
        /// <para>示例值：DOING</para>
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        /// <remarks>
        /// 对服务订单"进行中"状态的附加说明。
        /// 1、MCH_COMPLETE：商户完结
        /// <para>示例值：MCH_COMPLETE</para>
        /// </remarks>
        [JsonPropertyName("state_description")]
        public string StateDescription { get; set; }

        /// <summary>
        /// 付费项目
        /// </summary>
        /// <remarks>
        /// 付费项目列表，最多包含100条付费项目。
        /// </remarks>
        [JsonPropertyName("post_payments")]
        public List<PostPayment> PostPayments { get; set; }

        /// <summary>
        /// 付费商户优惠
        /// </summary>
        /// <remarks>
        /// 付费商户优惠列表，最多包含30条商户优惠。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_discounts")]
        public List<PostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 服务时间段
        /// </summary>
        /// <remarks>
        /// 服务时间范围
        /// </remarks>
        [JsonPropertyName("time_range")]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置
        /// </summary>
        /// <remarks>
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 商户数据包
        /// </summary>
        /// <remarks>
        /// 商户数据包可存放本订单所需信息，需要先urlencode后传入。 当商户数据包总长度超出256字符时，报错处理。
        /// <para>示例值：Easdfowealsdkjfnlaksjdlfkwqoi&amp;wl3l2sald</para>
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 商户回调地址
        /// </summary>
        /// <remarks>
        /// 商户接收用户确认订单和付款成功回调通知的地址。
        /// <para>示例值：https://api.test.com</para>
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 商户收款总金额
        /// </summary>
        /// <remarks>
        /// 1、金额：数字，必须≥0（单位：分）
        /// 2、总金额 =（完结付费项目1…+完结付费项目n）-（完结商户优惠项目1…+完结商户优惠项目n）
        /// <para>示例值：50000</para>
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }
    }
}
