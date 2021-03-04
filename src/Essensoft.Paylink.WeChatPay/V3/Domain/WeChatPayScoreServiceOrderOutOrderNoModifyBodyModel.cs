using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 修改订单金额 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">微信支付分 - 修改订单金额API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderOutOrderNoModifyBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系。
        /// 此参数需在本系统先进行配置，并与创建订单时的appid保持一致。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限，需要与创建订单时保持一致。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

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
        public List<PostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 总金额       
        /// </summary>
        /// <remarks>
        /// 总金额，单位为分，不能超过完结订单时候的总金额，只能为整数，详见支付金额。此参数需满足：总金额 =（修改后付费项目1…+修改后完结付费项目n）-（修改 后付费商户优惠项目1…+修改后付费商户优惠项目n）
        /// <para>示例值：50000</para>
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 修改原因
        /// </summary>
        /// <remarks>
        /// 按照字符计算，超过长度报错处理。
        /// <para>示例值：用户投诉</para>
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
