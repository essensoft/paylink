using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 内容信息详情
    /// </summary>
    public class SyncDetail : WeChatPayObject
    {
        /// <summary>
        /// 收款成功时间
        /// </summary>
        /// <remarks>
        /// 支付成功时间，支持两种格式：yyyyMMddHHmmss和yyyyMMdd
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒。
        /// ● 传入20091225默认认为时间为2009年12月25日0点0分0秒。
        /// 用户通过其他方式付款成功的实际时间需满足条件：服务开始时间＜调用商户完结订单接口的时间＜用户通过其他方式付款成功的实际时间≤商户调用支付分订单同步接口的时间。
        ///【服务开始时间】
        /// 1、当完结订单有填写【实际服务开始时间】时，【服务开始时间】=完结订单【实际服务开始时间】。
        /// 2、当完结订单未填写【实际服务开始时间】时，【服务开始时间】=创建订单【服务开始时间】
        /// 场景类型为Order_Paid时，必填。
        /// 支持两种格式：yyyyMMddHHmmss和yyyyMMdd
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒。
        /// ● 传入20091225表示时间为2009年12月25日23点59分59秒。
        /// 注意：微信支付分会根据此时间更新用户侧的守约记录、负面记录信息；因此请务必如实填写用户实际付款成功时间，以免造成不必要的客诉。
        /// <para>示例值：20091225091210</para>
        /// </remarks>
        [JsonPropertyName("paid_time")]
        public string PaidTime { get; set; }
    }
}
