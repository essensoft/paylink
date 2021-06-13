using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateModifyModel Data Structure.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateModifyModel : AlipayObject
    {
        /// <summary>
        /// 资产id，需要修改的权益模版的id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，由权益结算平台指定，BENEFIT_TEMPLATE表示权益模版
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务时间，业务系统指定业务操作时间
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务号，业务系统填充业务号，具备唯一性
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 过期时间，权益模版新的过期时间
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 权益模版所属商户的支付宝会员id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
