using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 完结支付分订单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml">微信支付分 - 完结支付分订单API</a> - 最新更新时间：2020.06.02</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderOutOrderNoCompleteBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 服务订单的主键，唯一定义此资源的标识
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 后付费项目
        /// </summary>
        /// <remarks>
        /// 后付费项目列表，最多包含100条付费项目。
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
        public List<PostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 总金额       
        /// </summary>
        /// <remarks>
        /// 1、金额：数字，必须≥0（单位：分），只能为整数，详见支付金额。
        /// 2、总金额 =（完结付费项目1…+完结付费项目n）-（完结商户优惠项目1…+完结商户优惠项目n）
        /// 3、总金额上限
        ///   1）【评估不通过：交押金】模式：总金额≤创单时填写的“订单风险金额”
        ///   2）【评估不通过：拒绝】模式：总金额≤“每个服务ID的风险金额上限”
        /// <para>示例值：50000</para>
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 服务时间段
        /// </summary>
        /// <remarks>
        /// 服务时间范围，创建订单未填写服务结束时间，则完结的时候，服务结束时间必填
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("time_range")]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置
        /// </summary>
        /// <remarks>
        /// 服务位置
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 微信支付服务分账标记
        /// </summary>
        /// <remarks>
        /// 完结订单分账接口标记。分账开通流程，详见
        /// false：不分账，默认：false
        /// true：分账。
        /// <para>示例值：false</para>
        /// </remarks>
        [JsonPropertyName("profit_sharing")]
        public bool ProfitSharing { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        /// <remarks>
        /// 订单优惠标记，代金券或立减金优惠的参数，说明详见代金券或立减金优惠
        /// <para>示例值：goods_tag</para>
        /// </remarks>
        [JsonPropertyName("goods_tag")]
        public string GoodsTag { get; set; }
    }
}
