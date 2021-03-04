using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 服务位置
    /// </summary>
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
        /// <para>示例值：嗨客时尚主题展餐厅</para>
        /// </remarks>
        [JsonPropertyName("start_location")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 预计服务结束位置
        /// </summary>
        /// <remarks>
        /// 1、结束使用服务的地点，不超过50个字符，超出报错处理 。
        /// 2、填写了服务开始地点，才能填写服务结束地点。
        /// <para>示例值：嗨客时尚主题展餐厅</para>
        /// </remarks>
        [JsonPropertyName("end_location")]
        public string EndLocation { get; set; }
    }
}
