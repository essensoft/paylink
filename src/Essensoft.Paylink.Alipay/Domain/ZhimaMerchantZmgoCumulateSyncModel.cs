using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateSyncModel Data Structure.
    /// </summary>
    public class ZhimaMerchantZmgoCumulateSyncModel : AlipayObject
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 任务金额型数据，当模版配置为付费模式或金额任务模式时传入
        /// </summary>
        [JsonPropertyName("amount_type_sync_data")]
        public AmountTypeSyncData AmountTypeSyncData { get; set; }

        /// <summary>
        /// 数据回传的动作类型，枚举值，为必传入参。 可取值： ("POSITIVE", "正向回传")，("REVERSE", "逆向回传")。 其中POSITIVE表示回传为正向的，即订单金额累加，优惠累加，任务次数累加；而REVERSE表示回传为逆向的，即订单金额退款，优惠退款，任务次数回退。
        /// </summary>
        [JsonPropertyName("biz_action")]
        public string BizAction { get; set; }

        /// <summary>
        /// 回传数据发生的实际时间，包括：订单交易时间，优惠核销时间，以及任务完成时间。为必传入参。 如：用户在【2019-03-08 00:00:00】核销了一个红包，但是【2019-03-10 00:00:00】才进行数据回传，此时biz_time取值红包核销的时间，也就是【2019-03-08 00:00:00】。
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 回传数据类型，枚举： TASK - 进度型，影响进度 DISCOUNT - 优惠型
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 优惠数据，仅回传优惠数据时传入
        /// </summary>
        [JsonPropertyName("discount_type_sync_data")]
        public DiscountTypeSyncData DiscountTypeSyncData { get; set; }

        /// <summary>
        /// 外部业务号，唯一标识一笔回传数据。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 数据回传的商户ID，即和用户发生业务来往的PID主体。
        /// </summary>
        [JsonPropertyName("provider_pid")]
        public string ProviderPid { get; set; }

        /// <summary>
        /// 逆向对应的正向外部业务号。逆向场景为必传入参。也就是biz_action为REVERSE时为必传入参。 逆向时需通过此字段明确对应的正向的外部业务号。
        /// </summary>
        [JsonPropertyName("refer_out_biz_no")]
        public string ReferOutBizNo { get; set; }

        /// <summary>
        /// 数据回传动作子类型，枚举值，为必传入参。 ADD - 新增数据 UPDATE - 修改数据 备注：UPDATE只能更新金额信息。
        /// </summary>
        [JsonPropertyName("sub_biz_action")]
        public string SubBizAction { get; set; }

        /// <summary>
        /// 任务次数型数据，当选择次数任务时传入
        /// </summary>
        [JsonPropertyName("times_type_sync_data")]
        public TimesTypeSyncData TimesTypeSyncData { get; set; }

        /// <summary>
        /// 用户支付宝userId，蚂蚁统一会员ID。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
