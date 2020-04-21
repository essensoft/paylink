using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandClassificationCreateormodifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandClassificationCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 标签Key（英文标识），不存在的Key是无法执行的
        /// </summary>
        [JsonPropertyName("classification_key")]
        public string ClassificationKey { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonPropertyName("classification_value")]
        public string ClassificationValue { get; set; }

        /// <summary>
        /// 可选：商户PID、间连SMID、店铺ShopID，具体根据target_type入参值决定
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 决定target_id的类型  target_type取值为0，target_id为间连SMID  target_type取值为2，target_id为商户PID  target_type取值为5，target_id为店铺ShopID
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }
    }
}
