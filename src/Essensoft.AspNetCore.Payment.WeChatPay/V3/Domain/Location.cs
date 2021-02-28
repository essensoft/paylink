using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 服务位置
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
    public class Location : WeChatPayObject
    {
        /// <summary>
        /// 服务开始地点
        /// </summary>
        /// <remarks>
        /// 开始使用服务的地点，不超过50个字符，超出报错处理。
        ///【建议】
        ///  1、用户下单时【未确定】服务结束地点，不填写。
        ///  2、服务在同一地点开始和结束，不填写。
        ///  3、用户下单时【已确定】服务结束地点，填写。
        ///示例值：嗨客时尚主题展餐厅
        /// </remarks>
        [JsonPropertyName("start_location")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 预计服务结束位置
        /// </summary>
        /// <remarks>
        /// 1、结束使用服务的地点，不超过50个字符，超出报错处理 。
        /// 2、填写了服务开始地点，才能填写服务结束地点。
        /// 示例值：嗨客时尚主题展餐厅
        /// </remarks>
        [JsonPropertyName("end_location")]
        public string EndLocation { get; set; }
    }
}
