using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 分账接收方对象
    /// </summary>
    public class Receiver : WeChatPayObject
    {
        /// <summary>
        /// 分账接收方类型
        /// </summary>
        /// <remarks>
        /// MERCHANT_ID：商户号（mch_id或者sub_mch_id）
        /// <para>示例值: MERCHANT_ID</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// </summary>
        /// <remarks>
        /// 申请本功能商户号
        /// <para>示例值: 1900000100</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账动账金额
        /// </summary>
        /// <remarks>
        /// 分账动账金额，单位为分，只能为整数
        /// <para>示例值: 888</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 分账/回退描述
        /// </summary>
        /// <remarks>
        /// 分账/回退描述
        /// <para>示例值: 运费/交易分账/及时奖励</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
