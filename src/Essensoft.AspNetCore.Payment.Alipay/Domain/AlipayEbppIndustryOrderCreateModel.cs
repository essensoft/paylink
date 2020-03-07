using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 能力码是由支付宝分配的标识code
        /// </summary>
        [JsonPropertyName("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// 账单的账期，例如201703表示2017年3月的账单。
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 业务账户号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 用户创建订单时涉及到的业务总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00)，精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("biz_amount")]
        public string BizAmount { get; set; }

        /// <summary>
        /// 机构简称例如杭州电力HZELECTRIC
        /// </summary>
        [JsonPropertyName("biz_inst_short_name")]
        public string BizInstShortName { get; set; }

        /// <summary>
        /// 业务类型，缴费业务为JF，还款业务HK，公服行业为IND。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扩展属性，json串(key-value对)
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金额，单位：元
        /// </summary>
        [JsonPropertyName("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 身份标识号，例如身份证号、纳税人识别号等。
        /// </summary>
        [JsonPropertyName("identity_no")]
        public string IdentityNo { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// ISV流水号，用于控制幂等，须确保全局唯一
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 拥有该订单的用户姓名
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 子业务类型，水费为WATER，燃气费为GAS，社保为SI，公积金为HF，社保+公积金为SIHF
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
