using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCashvoucherTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashvoucherTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 面额。每张代金券可以抵扣的金额。币种为人民币，单位为元。该数值不能小于0.1，小数点以后最多保留两位。
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 创建券模板时录入的品牌信息，由商户自定义，在通用模板中展示在券LOGO下方。根据券使用场景的不同，该信息的展示位置可能会有不同。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 扩展字段,JSON字符串。目前支持使用模式扩展：{"useMode":"H5","useModeData":{"url":"http://www.yourdomian.com/yourusepage.htm","signKeys":"voucherId,userId,tag","charset":"UTF-8","signType":"RSA2","tag":"this is my tag"}}  其中如果useMode表示自定义的使用模式类型，目前仅支持"H5",表示在券详情页按钮跳转至自定义H5页面，当传入useMode参数后，将会检查useModeData对象数据，其中的url为必传参数;url字段表示客制化使用按钮跳转链接，传入该字段后在券详情使用时点击效果将会跳转此链接，链接将进行白名单过滤，如果无法接入成功请联系技术支持;signKeys字段表示跳转至客制链接时的加签字段，如果不传默认为voucherId,userId,tag;signType为加签类型，目前支持RSA及RSA2,如果不传则不会加签;charset为链接编码格式，不传默认为UTF-8;tag为自定义参数，会直接透传回使用链接;当传入合法加签信息后，券使用链接将为http://www.yourdomain.com/yourusepage.htm?voucherId=当前券id&userId=当前用户id&tag=传入tag&sign=对应算法及key生成的加签数据
        /// </summary>
        [JsonPropertyName("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 最低额度。设置券使用门槛，只有订单金额大于等于最低额度时券才能使用。币种为人民币，单位为元。该数值不能小于0，小数点以后最多保留两位。
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 出资人登录账号。用于发券的资金会从该账号划拨到发券专用账户上。当调用创建接口成功后，会返回付款订单页面，仅当前传入资金账号可进行付款，付款完成后券变更为激活状态，可进行发放。
        /// </summary>
        [JsonPropertyName("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 券变动异步通知地址，传入此字段后，券的核销将会进行异步通知，通知具体内容见下方触发异步通知字段描述
        /// </summary>
        [JsonPropertyName("notify_uri")]
        public string NotifyUri { get; set; }

        /// <summary>
        /// 外部业务单号。用作幂等控制。同一个pid下相同的外部业务单号作唯一键，参数不变的情况下，再次请求返回同样的模板id。请求成功后，修改参数再次提交，需要更换订单号。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发券。券的发放结束时间和发放开始时间跨度不能大于90天。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间，早于该时间不能发券。发放开始时间不能大于当前时间15天。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 重定向地址。支付成功后需要重定向的地址，如果为空则不做重定向。
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 规则配置，JSON字符串，格式为K-V模式，当同一个KEY下规则为多个值时，用英文逗号进行分隔。目前支持的规则KEY有：核销商户ID(PID),核销内部门店ID(STORE),指定收款账户(payeeUserId),子产品交易码(bizProduct),缴费机构/类型(CUSTOMBUSINESS),缴费户号(EBPPUSERNUM)。一旦商户设置了规则，当前券实例必须满足指定规则才能进行核销。了解更多规则相关具体属性，请联系技术支持。
        /// </summary>
        [JsonPropertyName("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 券标语，用于拼接券名称，最多6个字符，券名称=券标语+券面额+’元代金券’,此字段已弃用
        /// </summary>
        [JsonPropertyName("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 券使用说明。JSON数组字符串，最多可以有10条，每条最多50字。如果未传入该字段，将填充为默认描述
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值必须是大于0的整数。
        /// </summary>
        [JsonPropertyName("voucher_quantity")]
        public long VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型。可枚举，暂时只支持"代金券"(FIX_VOUCHER)，使用示例voucher_type=FIX_VOUCHER
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券使用场景。可枚举，目前支持“支付宝充值中心话费流量通用现金券”(ALIPAY_RECHARGE)，“支付宝缴费业务代金券”(ALIPAY_FEE)，“支付宝通用现金代金券”(ALIPAY_COMMON)。场景值会关联当前券的展示模板，默认描述等信息，若需特殊场景接入，请联系技术支持。
        /// </summary>
        [JsonPropertyName("voucher_use_scene")]
        public string VoucherUseScene { get; set; }

        /// <summary>
        /// 券有效期。有两种类型：绝对时间和相对时间。使用JSON字符串表示。绝对时间有3个key：type、start、end，type取值固定为"ABSOLUTE"，start和end分别表示券生效时间和失效时间，格式为yyyy-MM-dd HH:mm:ss。绝对时间示例：{"type": "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发券时间开始到往后推duration个单位时间为止作为券的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发券，那么该券从现在开始生效1(duration)天(unit)后失效。
        /// </summary>
        [JsonPropertyName("voucher_valid_period")]
        public string VoucherValidPeriod { get; set; }
    }
}
