using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSpayAuthConsultModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiSpayAuthConsultModel : AlipayObject
    {
        /// <summary>
        /// 月月付的资产编码类型；月月付接口，此处必须传：ALICREDITFF
        /// </summary>
        [JsonPropertyName("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 月月付业务类型，目前只有一个有效值：MONTH
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务场景： hbff.stanard.other 淘外标准版（默认） hbff.stanard.telecom 淘外运营商合约购
        /// </summary>
        [JsonPropertyName("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 鉴权请求扩展信息；
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public ExtInfos ExtInfos { get; set; }

        /// <summary>
        /// 费用的承担比例，目前没有启用。
        /// </summary>
        [JsonPropertyName("fee_rate_percent")]
        public string FeeRatePercent { get; set; }

        /// <summary>
        /// 费用的收费主体；目前没有启用。
        /// </summary>
        [JsonPropertyName("fee_taker_role")]
        public string FeeTakerRole { get; set; }

        /// <summary>
        /// 商户和蚂蚁的对接模式，直连模式用：DIRECT_LINK
        /// </summary>
        [JsonPropertyName("link_mode")]
        public string LinkMode { get; set; }

        /// <summary>
        /// 商户的身份信息
        /// </summary>
        [JsonPropertyName("merchant")]
        public MerchantIDInfo Merchant { get; set; }

        /// <summary>
        /// PAY_MONTHLY表达按月均匀支付；
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// RECEIVE_IN_ONE_TIME:表达一次性提前收款服务 RECEIVE_BY_PERIOD:按照周期收款
        /// </summary>
        [JsonPropertyName("receive_mode")]
        public string ReceiveMode { get; set; }

        /// <summary>
        /// 分次支付的次数，必须为整数，目前支支持传入10
        /// </summary>
        [JsonPropertyName("total_install_num")]
        public long TotalInstallNum { get; set; }

        /// <summary>
        /// 支付总金额，不是单期支付金额，单位为元；最多支持小数点后面2位小数；
        /// </summary>
        [JsonPropertyName("total_payment_amount")]
        public string TotalPaymentAmount { get; set; }

        /// <summary>
        /// 用户身份信息，蚂蚁统一会员ID user_id、蚂蚁会员登陆ID login_id（邮箱、手机号），此字段中user_id、login_id和user_id字段三选一必传
        /// </summary>
        [JsonPropertyName("user")]
        public UserDInfo User { get; set; }

        /// <summary>
        /// 买家的蚂蚁统一会员ID，建议使用新的 user字段，当前字段仍然保持兼容支持；此字段和user字段中user_id、login_id三选一必传
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
