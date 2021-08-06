using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRelationshipCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityRelationshipCreateModel : AlipayObject
    {
        /// <summary>
        /// 每个小区默认的收款帐号为授权物业的支付宝账号，默认不用传该参数。  但为满足部分物业公司财务要求，允许开发者为每个小区服务传入一个指定的物业收款帐号，开发者需要在直付通中设置银行卡相关信息
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 每个小区默认的收款账号为授权物业的支付宝账号，默认不用传该参数。用户完成缴费后实时入账至该支付宝账号，后续由物业财务系统根据缴费异步通知和支付宝对账文件进行资金清分。    但为了满足部分物业公司的财务清结算需求，允许在授权物业账号下已设置支付宝收款子账号限制集的前提下，由开发者为指定小区服务传入一个物业公司的支付宝收款子帐号，目前只支持银行卡的分账模式：    BANK_CARD_ID - 银行卡号     注意：若传递的收款子账号事先未在支付宝配置，开发者在上线前的支付验证环节会提示不支持收款到该账户，请联系物业公司完成配置事宜。
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 物业费允许跳缴 （1允许，0不允许，默认1） 若服务商接口设置小区“不允许跳缴” ，则物业缴费单页，用户点击“完成选择”时，针对费用类型为“物业费、公共维护金、公共能耗费、水费公摊费、电费公摊费、储藏室物业费”的账单选择板块， 均新增逻辑判断 （如下判断是各费种各自独立判断） 1）若最早账期的账单已勾选、且勾选的账单月份连续、且服务商/物业设置的必勾选的账单均已勾选，则流程继续 2）若最早账期的账单未勾选、或者出现勾选的账单月份不连续的情况，则弹框提示“根据物业公司要求，部分费用类型的账单不允许跳缴（跳缴：跳过前序未缴费月份进行账单缴费）”、且无法进入下一步
        /// </summary>
        [JsonPropertyName("allow_skip_pay")]
        public string AllowSkipPay { get; set; }

        /// <summary>
        /// 外部户号查询跳转链接,占位符使用#xxx#模式，xxx为占位符枚举，目前支持的枚举值为:communityShortName
        /// </summary>
        [JsonPropertyName("billkey_url")]
        public string BillkeyUrl { get; set; }

        /// <summary>
        /// 小区短名, 创建小区时创建
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 日常服务开始时间，例如24:00
        /// </summary>
        [JsonPropertyName("daily_end")]
        public string DailyEnd { get; set; }

        /// <summary>
        /// 日常服务开始时间，例如00:00
        /// </summary>
        [JsonPropertyName("daily_start")]
        public string DailyStart { get; set; }

        /// <summary>
        /// 绑定关系额外字段
        /// </summary>
        [JsonPropertyName("extend_field")]
        public CommunityRelationshipExtendField ExtendField { get; set; }

        /// <summary>
        /// 外部账单页面跳转链接，占位符使用#xxx#模式，xxx为占位符枚举，目前支持的枚举值为:communityShortName，roomId
        /// </summary>
        [JsonPropertyName("out_bill_url")]
        public string OutBillUrl { get; set; }

        /// <summary>
        /// 物业公司的短名,在创建物业公司时生成
        /// </summary>
        [JsonPropertyName("property_short_name")]
        public string PropertyShortName { get; set; }

        /// <summary>
        /// 服务结束时间，格式：yyyy-MM-dd HH:mm:ss（精度只到日期）
        /// </summary>
        [JsonPropertyName("service_end")]
        public string ServiceEnd { get; set; }

        /// <summary>
        /// 服务开始时间，格式为yyyy-MM-dd HH:mm:ss（精度只到日期）
        /// </summary>
        [JsonPropertyName("service_start")]
        public string ServiceStart { get; set; }

        /// <summary>
        /// 服务类型，不传默认为物业缴费     THIRD_PARTY_COMMUNITY_JIAOFEI(物业缴费),     CENTRAL_SCAN_CODE_PASS(扫码通行联动门禁),     OPEN_SESAME(扫码通行无门禁),     H5_SCAN_CODE_PASS(扫码通行内部H5模式)
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// accountType不为空时，需要传入结算的二级商户id
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
