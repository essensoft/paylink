using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 付款项目
    /// </summary>
    public class PostPayment : WeChatPayObject
    {
        /// <summary>
        /// 付费项目名称       
        /// </summary>
        /// <remarks>
        /// 相同订单号下不能出现相同的付费项目名称，当参数长度超过20个字符时，报错处理。
        /// <para>示例值：就餐费用, 服务费</para>
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 金额 
        /// </summary>
        /// <remarks>
        /// 此付费项目总金额，大于等于0，单位为分，等于0时代表不需要扣费，只能为整数，详见支付金额。
        /// <para>示例值：40000</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 计费说明      
        /// </summary>
        /// <remarks>
        /// 描述计费规则，不超过30个字符，超出报错处理
        /// <para>示例值：就餐人均100元，服务费：100/小时 </para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 付费数量   
        /// </summary>
        /// <remarks>
        /// 付费项目的数量。
        /// 特殊规则：数量限制100，不填时默认1。
        /// <para>示例值：4</para>
        /// </remarks>
        [JsonPropertyName("count")]
        public uint? Count { get; set; }
    }
}
