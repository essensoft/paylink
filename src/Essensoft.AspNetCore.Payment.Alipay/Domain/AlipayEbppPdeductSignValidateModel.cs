using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppPdeductSignValidateModel Data Structure.
    /// </summary>
    public class AlipayEbppPdeductSignValidateModel : AlipayObject
    {
        /// <summary>
        /// 机构签约代扣来源渠道  PUBLICPLATFORM：服务窗
        /// </summary>
        [JsonPropertyName("agent_channel")]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 从服务窗发起则为该服务窗的appid的值
        /// </summary>
        [JsonPropertyName("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 签约类型,可为空。目前类型有INST_DIRECT_DEDUCT
        /// </summary>
        [JsonPropertyName("deduct_type")]
        public string DeductType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置，本期预留字段，固定传空。
        /// </summary>
        [JsonPropertyName("notify_config")]
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 外部机构签约的协议id
        /// </summary>
        [JsonPropertyName("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名，户主真实姓名
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置，目前可为空。类型有：BALANCE;CARTOON;BIGAMOUNT_CREDIT_CARTOON;DEBIT_EXPRESS;OPTIMIZED_MOTO;PCREDIT_PAY;MONEY_FUND
        /// </summary>
        [JsonPropertyName("pay_config")]
        public string PayConfig { get; set; }

        /// <summary>
        /// 商户签约支付宝账号的userid，2088开头16位长度的字符串，在支付宝系统中唯一
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        [JsonPropertyName("sign_expire_date")]
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户支付宝账号id，2088开头16位长度的字符串，在支付宝系统中唯一
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
