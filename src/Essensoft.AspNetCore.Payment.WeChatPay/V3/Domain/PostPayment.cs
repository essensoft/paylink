using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 付款项目
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
    public class PostPayment : WeChatPayObject
    {
        /// <summary>
        /// 付费项目名称       
        /// </summary>
        /// <remarks>
        /// 相同订单号下不能出现相同的付费项目名称，当参数长度超过20个字符时，报错处理。
        /// 示例值：就餐费用, 服务费
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 金额 
        /// </summary>
        /// <remarks>
        /// 此付费项目总金额，大于等于0，单位为分，等于0时代表不需要扣费，只能为整数，详见支付金额。
        /// 示例值：40000       
        /// </remarks>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 计费说明      
        /// </summary>
        /// <remarks>
        /// 描述计费规则，不超过30个字符，超出报错处理
        /// 示例值：就餐人均100元，服务费：100/小时 
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 付费数量   
        /// </summary>
        /// <remarks>
        /// 付费项目的数量。
        /// 特殊规则：数量限制100，不填时默认1。
        /// 示例值：4    
        /// </remarks>
        [JsonPropertyName("count")]
        public uint? Count { get; set; }
    }
}
