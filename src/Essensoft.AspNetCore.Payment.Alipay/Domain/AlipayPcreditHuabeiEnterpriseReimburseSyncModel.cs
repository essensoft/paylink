using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseSyncModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiEnterpriseReimburseSyncModel : AlipayObject
    {
        /// <summary>
        /// 企业单据id
        /// </summary>
        [JsonPropertyName("biz_reimburse_id")]
        public string BizReimburseId { get; set; }

        /// <summary>
        /// 单据结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 单据开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 若有途径城市，填写途径城市，没有填写单据名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
