using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 当前绑卡状态： BINDED(已绑定) NOT_BIND(未绑定) OTHER_BIND(不同账号绑卡)
        /// </summary>
        [JsonPropertyName("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 买家支付宝账号，将用＊号屏蔽部分内容
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构名称
        /// </summary>
        [JsonPropertyName("card_org_name")]
        public string CardOrgName { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构编号
        /// </summary>
        [JsonPropertyName("card_org_no")]
        public string CardOrgNo { get; set; }

        /// <summary>
        /// 城市编码(格式为：行政区域代码)  多个地市逗号分隔
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 一个支付宝账号绑定了多张医保卡，除本人以外的卡信息
        /// </summary>
        [JsonPropertyName("extend_cards")]
        public List<ExtendMedicalCard> ExtendCards { get; set; }

        /// <summary>
        /// Json格式的业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  签约成功时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 000102020011
        /// </summary>
        [JsonPropertyName("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  医保卡号，敏感信息脱敏输出
        /// </summary>
        [JsonPropertyName("medical_card_no")]
        public string MedicalCardNo { get; set; }

        /// <summary>
        /// 市医保：CITY_INS  省医保:PROVINCE_INS  县医保:COUNTY_INS
        /// </summary>
        [JsonPropertyName("medical_card_type")]
        public string MedicalCardType { get; set; }

        /// <summary>
        /// bind_satus= OTHER_BIND情况下输出,买家支付宝账号，将用*号屏蔽部分内容
        /// </summary>
        [JsonPropertyName("other_user_logon_id")]
        public string OtherUserLogonId { get; set; }

        /// <summary>
        /// bind_satus= OTHER_BIND情况下输出, "off"代表其他账户已注销 "on"代表其他账户未注销
        /// </summary>
        [JsonPropertyName("other_user_status")]
        public string OtherUserStatus { get; set; }

        /// <summary>
        /// 医保卡持卡人证件号码(脱敏)
        /// </summary>
        [JsonPropertyName("out_user_card_no")]
        public string OutUserCardNo { get; set; }

        /// <summary>
        /// 医保卡持有人姓名( 脱敏)
        /// </summary>
        [JsonPropertyName("out_user_name")]
        public string OutUserName { get; set; }

        /// <summary>
        /// 绑定状态  已激活:signed  已解绑:unsigned
        /// </summary>
        [JsonPropertyName("sign_status")]
        public string SignStatus { get; set; }
    }
}
