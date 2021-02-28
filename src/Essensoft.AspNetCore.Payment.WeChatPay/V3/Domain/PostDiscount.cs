using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 商户优惠
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">创单结单合并API</a> - 最新更新时间：2020.04.23</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml">创建支付分订单API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a> - 最新更新时间：2020.05.25</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml">完结支付分订单API</a> - 最新更新时间：2020.06.02</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_21.shtml">确认订单回调通知API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_22.shtml">支付成功回调通知API</a> - 最新更新时间：2020.05.25</para>
    /// </remarks>
    public class PostDiscount : WeChatPayObject
    {
        /// <summary>
        /// 优惠名称
        /// </summary>
        /// <remarks>
        /// 1、商户优惠项目名称，不超过20个字符。
        /// 2、优惠项目名称不可重复。
        /// 示例值：满20减1元 
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠说明
        /// </summary>
        /// <remarks>
        /// 1、优惠使用条件说明，不超过30个字符。
        /// 示例值：不与其他优惠叠加
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        /// <remarks>
        /// 1、商户优惠项目金额，大于等于0，单位为分。
        /// 示例值：100
        /// </remarks>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 优惠数量
        /// </summary>
        /// <remarks>
        /// 优惠的数量，不填时默认为1个。
        /// 特殊规则：数量限制100，不填时默认1
        /// 示例值：2
        /// </remarks>
        [JsonPropertyName("count")]
        public uint? Count { get; set; }
    }
}
