using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingExchangevoucherTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingExchangevoucherTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 品牌名。用于在卡包中展示，长度不能超过12个字符。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 扩展字段，JSON字符串。目前支持使用模式扩展：{"useMode":"H5","useModeData":{"url":"http://www.yourdomian.com/yourusepage.htm","signKeys":"voucherId,userId,tag","charset":"UTF-8","signType":"RSA2","tag":"this is my tag"}}，  其中useMode表示自定义的使用模式类型，必填，目前仅支持"H5"，表示在券详情页按钮跳转至自定义H5页面；useModeData表示使用模式对象数据，必填，其中url字段表示客制化使用按钮跳转链接，必填，在券详情使用时点击效果将会跳转此链接，链接将进行白名单过滤，如果无法接入成功请联系技术支持；signKeys字段表示跳转至客制链接时的加签字段，如果不传默认为voucherId,userId,tag；signType为加签类型，目前支持RSA及RSA2,如果不传则不会加签；charset为链接编码格式，不传默认为UTF-8；tag为自定义参数，会直接透传回使用链接。本例中当传入合法加签信息后，券使用链接将为http://www.yourdomain.com/yourusepage.htm?voucherId=当前券id&userId=当前用户id&tag=传入tag&sign=对应算法及key生成的加签数据。
        /// </summary>
        [JsonPropertyName("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 券变动异步通知地址，传入此字段后，券的核销将会进行异步通知。
        /// </summary>
        [JsonPropertyName("notify_uri")]
        public string NotifyUri { get; set; }

        /// <summary>
        /// 外部业务单号。用作幂等控制。同一个pid下相同的外部业务单号作唯一键。
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
        /// 用户核销方式设置，必填。目前仅支持：H5
        /// </summary>
        [JsonPropertyName("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 券可用时段，JSON数组字符串，空数组即[]，表示不限制，指定每周时间段示例：[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]，数组中每个元素都包含三个key：day_rule, time_begin, time_end，其中day_rule表示周几，取值范围[1, 2, 3, 4, 5, 6, 7]（周7表示星期日），多个值使用英文逗号隔开；time_begin和time_end分别表示生效起始时间和结束时间，格式为HH:mm:ss。另外，数组中各个时间规则是或关系。例如，[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]表示在每周的一，二，三，四，五的早上9点到晚上10点券可用或者每周的星期六和星期日的早上8点到晚上11点券可用。
        /// </summary>
        [JsonPropertyName("voucher_available_time")]
        public string VoucherAvailableTime { get; set; }

        /// <summary>
        /// 券使用说明。JSON数组字符串，最多可以有10条，每条最多50字。不采用时输入"[]"
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券名称。用于在卡包中展示，长度不能超过20个字符。展示的实际名称为：券名称+兑换券。如，voucher_name为咖啡。则，卡包展示名称为：咖啡兑换券。
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值必须是大于0的整数。
        /// </summary>
        [JsonPropertyName("voucher_quantity")]
        public long VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型，目前仅支持兑换券，即：EXCHANGE_VOUCHER
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券有效期。有两种类型：绝对时间和相对时间。使用JSON字符串表示。绝对时间有3个key：type、start、end，type取值固定为"ABSOLUTE"，start和end分别表示券生效时间和失效时间，格式为yyyy-MM-dd HH:mm:ss。绝对时间示例：{"type": "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发券时间开始到往后推duration个单位时间为止作为券的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发券，那么该券从现在开始生效1(duration)天(unit)后失效。
        /// </summary>
        [JsonPropertyName("voucher_valid_period")]
        public string VoucherValidPeriod { get; set; }
    }
}
