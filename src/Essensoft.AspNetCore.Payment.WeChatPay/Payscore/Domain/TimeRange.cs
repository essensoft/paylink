using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 服务时间段
    /// </summary>
    public class TimeRange : WeChatPayObject
    {
        /// <summary>
        /// 服务开始时间
        /// </summary>
        /// <remarks>
        /// 用户端展示用途。
        /// 用户下单时确认的服务开始时间（比如用户今天下单，明天开始接受服务，这里指的是明天的服务开始时间）。
        /// 支持三种格式：yyyyMMddHHmmss、yyyyMMdd和 OnAccept
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒。
        /// ● 传入20091225默认认为时间为2009年12月25日
        /// ● 传入OnAccept表示用户确认订单成功时间为【服务开始时间】。
        /// 根据传入时间精准度进行校验
        /// 1）若传入时间精准到秒，则校验精准到秒：【服务开始时间】>【商户调用创建订单接口时间
        /// 2）若传入时间精准到日，则校验精准到日：【服务开始时间】>=【商户调用创建订单接口时间】
        /// 示例值：20091225091010
        /// </remarks>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }


        /// <summary>
        /// 服务开始时间备注
        /// </summary>
        /// <remarks>
        /// 服务开始时间备注说明，服务开始时间有填时，可填写服务开始时间备注，不超过20个字符，超出报错处理。
        /// 示例值：开始租借日期
        /// </remarks>
        [JsonPropertyName("start_time_remark")]
        public string StartTimeRemark { get; set; }

        /// <summary>
        /// 预计服务结束时间
        /// </summary>
        /// <remarks>
        /// 用户端展示用途，支持两种格式：yyyyMMddHHmmss和yyyyMMdd
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒。
        /// ● 传入20091225默认认为时间为2009年12月25日
        /// 根据传入时间精准度进行校验
        /// 1、若传入时间精准到秒，则校验精准到秒：
        /// 1）【预计服务结束时间】>【服务开始时间】
        /// 2）【预计服务结束时间】>【商户调用接口时间+1分钟】
        /// 2、若传入时间精准到日，则校验精准到日：
        /// 1）【预计服务结束时间】>=【服务开始时间】
        /// 2）【预计服务结束时间】>=【商户调用接口时间】
        /// 【建议】
        ///    1、用户下单时【未确定】服务结束时间，不填写。
        ///    2、用户下单时【已确定】服务结束时间，填写。
        /// 示例值：20091225121010
        /// </remarks>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预计服务结束时间备注
        /// </summary>
        /// <remarks>
        /// 预计服务结束时间备注说明，预计服务结束时间有填时，可填写预计服务结束时间备注，不超过20个字符，超出报错处理。
        /// 示例值：结束租借时间
        /// </remarks>
        [JsonPropertyName("end_time_remark")]
        public string EndTimeRemark { get; set; }
    }
}
