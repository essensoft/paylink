using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoCumulationSyncModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoCumulationSyncModel : AlipayObject
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。为必传入参。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 金额类型数据。商户回传的数据为金额类型，包括交易金额和优惠金额。累计类型为AMOUNT或AMOUNT_TASK时，为必传入参。也就是cumulate_data_type为AMOUNT或AMOUNT_TASK时，为必传参数。
        /// </summary>
        [JsonPropertyName("amount_type_data")]
        public AmountTypeData AmountTypeData { get; set; }

        /// <summary>
        /// 数据回传的动作类型，为枚举值，为必传入参。 可取值： ("ORDER_PAID", "正向支付")，("ORDER_REFUND", "逆向退款")。 其中ORDER_PAID表示回传为正向的，即订单金额累加，优惠累加，任务次数累加；而ORDER_REFUND表示回传为逆向的，即订单金额退款，优惠退款，任务次数回退。
        /// </summary>
        [JsonPropertyName("biz_action")]
        public string BizAction { get; set; }

        /// <summary>
        /// 交易发生时间，包括：订单交易时间，优惠核销时间，以及任务完成时间。为必传入参。 如：用户在【2019-03-08 00:00:00】核销了一个红包，但是【2019-03-10 00:00:00】才进行数据回传，此时biz_time取值红包核销的时间，也就是【2019-03-08 00:00:00】。
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 累计类型。为枚举值，为必传入参。 可取值：("AMOUNT", "金额类型")，("TASK", "任务类型")，("AMOUNT_TASK", "额度和任务类型")。 其中，交易解耦模式仅允许AMOUNT或TASK。而交易绑定模式下，仅允许AMOUNT_TASK。
        /// </summary>
        [JsonPropertyName("cumulate_data_type")]
        public string CumulateDataType { get; set; }

        /// <summary>
        /// 扩展字段，格式为Json格式的字符串，非必传。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否为支付宝交易。仅在累计模式为【交易绑定模式】下被消费。当芝麻Go模板配置的累计模式为交易绑定模式时，此时需传入扩展参数是否为支付宝交易。若是支付宝交易，传值true，否则为false。若不传此字段，默认为false。 若为true，则会对交易号trade_no进行校验，校验是否为支付宝交易，以及用户userId和商户partnerId是否一致，若校验不通过，累计失败。
        /// </summary>
        [JsonPropertyName("has_alipay_trade")]
        public bool HasAlipayTrade { get; set; }

        /// <summary>
        /// 外部业务号。需保证唯一，为必传入参。 若接口调用失败，提示信息为更换幂等号，商户更换此字段重新发起调用。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID，为必传入参。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 逆向对应的正向外部业务号。逆向场景为必传入参。也就是biz_action为ORDER_REFUND时为必传入参。 逆向时需通过此字段明确对应的正向的外部业务号。
        /// </summary>
        [JsonPropertyName("pay_out_biz_no")]
        public string PayOutBizNo { get; set; }

        /// <summary>
        /// 取固定值ExternalMerchantSource，为必传入参。表示数据回传来源为外部商户，数据回传内部逻辑需感知。
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 任务类型数据。商户回传的数据为任务类型，包含任务名称。累计类型为TASK时，为必传入参。也就是cumulate_data_type为TASK时为必传参数。
        /// </summary>
        [JsonPropertyName("task_type_data")]
        public TaskTypeData TaskTypeData { get; set; }

        /// <summary>
        /// 用户userId，蚂蚁统一会员ID，为必传入参。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
