using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntfarmUserDonationInfo Data Structure.
    /// </summary>
    public class AntfarmUserDonationInfo : AlipayObject
    {
        /// <summary>
        /// 用户捐爱心记录列表
        /// </summary>
        [JsonPropertyName("donation_record_list")]
        public List<AntfarmUserDonationRecord> DonationRecordList { get; set; }

        /// <summary>
        /// 捐赠标的物 id
        /// </summary>
        [JsonPropertyName("donation_target_id")]
        public string DonationTargetId { get; set; }

        /// <summary>
        /// 捐赠标的物名称
        /// </summary>
        [JsonPropertyName("donation_target_name")]
        public string DonationTargetName { get; set; }

        /// <summary>
        /// 捐赠项目 id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 捐赠项目名称
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }
    }
}
