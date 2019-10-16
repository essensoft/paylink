using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBenefitRecordQueryModel : AlipayObject
    {
        /// <summary>
        /// 任务有奖-1688 L1会场优惠资格权益
        /// </summary>
        [JsonProperty("benefit_instance_id")]
        public string BenefitInstanceId { get; set; }

        /// <summary>
        /// 查询额外所需要的扩展信息
        /// </summary>
        [JsonProperty("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部传入的账号  CBU的userId
        /// </summary>
        [JsonProperty("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 查询数据的页码
        /// </summary>
        [JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 查询的分页 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 发放记录的状态  GRANTED:发放成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
