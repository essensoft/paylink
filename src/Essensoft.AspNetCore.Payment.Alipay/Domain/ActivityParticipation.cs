using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityParticipation Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityParticipation : AlipayObject
    {
        /// <summary>
        /// 承诺消费活动模型
        /// </summary>
        [JsonProperty("activity")]
        public Activity Activity { get; set; }

        /// <summary>
        /// 商户是否可以免除用户退回优惠
        /// </summary>
        [JsonProperty("can_dispense")]
        public bool CanDispense { get; set; }

        /// <summary>
        /// 合约已支付金额，只支持两位小数点的正数
        /// </summary>
        [JsonProperty("consumed_amount")]
        public string ConsumedAmount { get; set; }

        /// <summary>
        /// 合约已消费次数，单位次
        /// </summary>
        [JsonProperty("consumed_times")]
        public long ConsumedTimes { get; set; }

        /// <summary>
        /// 承诺合约号
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合约状态，在下列值中：  ACT_EFFECTIVE - 生效中  ACT_PENDING_PAY - 到期未完成待支付  ACT_CANCELLED_PENDING_PAY - 用户取消合约等待支付  ACT_FINISH_NOT_EXPIRE - 已守约未到期  ACT_OVERDUE - 到期未完成已逾期  E_UNFINISH_PAID - 到期未完成已支付  E_FINISHED - 已守约  E_CANCELLED - 未到期取消
        /// </summary>
        [JsonProperty("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合约状态描述  生效中 - ACT_EFFECTIVE  到期未完成待支付 - ACT_PENDING_PAY  用户取消合约等待支付 - ACT_CANCELLED_PENDING_PAY  已守约未到期 - ACT_FINISH_NOT_EXPIRE  到期未完成已逾期 - ACT_OVERDUE  到期未完成已支付 - E_UNFINISH_PAID  已守约 - E_FINISHED  未到期取消 - E_CANCELLED
        /// </summary>
        [JsonProperty("contract_status_desc")]
        public string ContractStatusDesc { get; set; }

        /// <summary>
        /// 合约状态标签，用于展示
        /// </summary>
        [JsonProperty("contract_status_tag")]
        public ContractStatusTag ContractStatusTag { get; set; }

        /// <summary>
        /// 合约已优惠总金额,只支持两位小数点的正数
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 用户参加活动，即合约生效时间，标准格式：2018-12-12 00:00:00
        /// </summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 用户参加活动逾期时间, 标准格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 用户是否参加活动
        /// </summary>
        [JsonProperty("participated")]
        public bool Participated { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 合约违约金额
        /// </summary>
        [JsonProperty("violation_amount")]
        public string ViolationAmount { get; set; }

        /// <summary>
        /// 内部资产平台券是否可用
        /// </summary>
        [JsonProperty("voucher_available")]
        public bool VoucherAvailable { get; set; }
    }
}
