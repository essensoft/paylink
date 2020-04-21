using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCashlessitemvoucherTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashlessitemvoucherTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 代金券面额。 当voucher_type为无资金单品代金券（ITEM_CASHLESS_FIX_VOUCHER）时必选。币种为人民币，单位为元。该数值不能小于0.1，且不能大于999元，代表订单金额达到使用门槛后，本券可抵扣相应面额资金。 代金券面额以门槛消费金额为基准，换算成折扣，不能低于9.95折。 当voucher_type为无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）和无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）时此值必须为空。
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商家品牌名称。最多12个字符  商户自定义，在通用模板中展示在券LOGO下方。根据券使用场景的不同，该信息的展示位置可能会有不同。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 单品价格可以享受的折扣力度（如填写0.9就表示9折）。 该值必须大于等于0.1且小于1，小数点以后最多保留两位，voucher_type为无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）时必选，其他券类型场景此值必须为0。
        /// </summary>
        [JsonPropertyName("discount")]
        public long Discount { get; set; }

        /// <summary>
        /// 消费门槛金额。  达到消费门槛金额以后用户可以享受优惠，消费门槛金额不能小于0.1元，不能超过9999元。
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 所有商品最多可享折扣数量。 当用户购买多件时，最多可以对几件特价支付。假设券类型为无资金单品特价券(ITEM_CASHLESS_SPE_VOUCHER)，商品编码填写A、B，此参数传入2，则订单中不管是A或者B，一共只能优惠2件，第3件以上原价。必须是整数，最低数量为1，最高99。券类型为无资金单品折扣券(ITEM_CASHLESS_DISCOUNT_VOUCHER)和无资金单品特价券(ITEM_CASHLESS_SPE_VOUCHER)时必填，无资金单品代金券下此值必须为0。 特别注意：此字段折扣数量的计算方式，相对老版本版本发生了变化。老版本的计算方式如下： 同样假设券类型为无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER），商品编码填写A、B，此参数传入3，则订单中A、B两个单品分别最多3件特价X元，第4件以上原价。必须是整数，最低数量为1，最高99。 voucher_type为无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）和无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）时必填，无资金单品代金券下此值必须为0。可以直接通过产品文档说明中的API的版本信息或者创建券模板返回结果中的的最大优惠字段（voucher_discount_limit）来确认具体使用的哪种折扣方式。
        /// </summary>
        [JsonPropertyName("goods_ceiling_quantity")]
        public string GoodsCeilingQuantity { get; set; }

        /// <summary>
        /// 单品券封面图片。  请先通过图片上传接口：alipay.marketing.material.image.upload上传图片。通过图片上传接口获取获得图片资源id以后，将该图片资源id传入，单张大小不超过2MB，格式支持png、gif、jpg、jpeg、bmp，尺寸为800X600
        /// </summary>
        [JsonPropertyName("goods_cover_image_id")]
        public string GoodsCoverImageId { get; set; }

        /// <summary>
        /// 单品券详情图片。  请先通过图片上传接口：alipay.marketing.material.image.upload上传图片。通过图片上传接口获取获得图片资源id以后，将该图片资源id传入，单张大小不超过2MB，格式支持png、gif、jpg、jpeg、bmp，尺寸为800X600。  最多支持3张单品详情图片，图片资源id用英文逗号分隔，不可含有重复资源ID。
        /// </summary>
        [JsonPropertyName("goods_detail_image_ids")]
        public string GoodsDetailImageIds { get; set; }

        /// <summary>
        /// 可优惠商品编码。多个编码标点隔开，不能含有重复id，最多3千个单品数量。当用户支付时，交易中的商品编码和单品券配置的商品编码有任一匹配时，可以使用单品优惠券。
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品描述信息。  用于券面展示，向用户介绍商品，最多120字。
        /// </summary>
        [JsonPropertyName("goods_info")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 商品名称。最多12个字
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品原价。 当voucher_type为无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）和无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）时必选，无资金单品代金券（ITEM_CASHLESS_FIX_VOUCHER）类型下此值必须为空。用于计算最大优惠价格（最大优惠价格的计算方式请参考产品说明文档）。
        /// </summary>
        [JsonPropertyName("goods_origin_price")]
        public string GoodsOriginPrice { get; set; }

        /// <summary>
        /// 券变动异步通知地址
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
        /// 规则配置，JSON字符串，{"PID": "2088512417841101,2088512417841102", "STORE": "123456,678901"}，其中PID表示可以核销该券的pid列表，多个值用英文逗号隔开，PID为必传且需与接口调用PID或授权PID同属一个商家，必须签约当面付，STORE表示可以核销该券的内部门店ID，多个值用英文逗号隔开 。仅支持PID和STOREID核销规则，PID列表和门店ID列表均不能含有重复ID，并且门店ID数量最多支持3000个。
        /// </summary>
        [JsonPropertyName("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 特价面额。使用特定价格购买单品，币种为人民币，最高特价面额不能超过999元。voucher_type为无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）时必选，其他券类型场景此值必须为空。
        /// </summary>
        [JsonPropertyName("special_price")]
        public string SpecialPrice { get; set; }

        /// <summary>
        /// 券可用时段，JSON数组字符串，空数组即[]，表示不限制，指定每周时间段示例：[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]，数组中每个元素都包含三个key：day_rule, time_begin, time_end，其中day_rule表示周几，取值范围[1, 2, 3, 4, 5, 6, 7]（周7表示星期日），多个值使用英文逗号隔开；time_begin和time_end分别表示生效起始时间和结束时间，格式为HH:mm:ss。另外，数组中各个时间规则是或关系。例如，[{"day_rule": "1,2,3,4,5", "time_begin": "09:00:00", "time_end": "22:00:00"}, {"day_rule": "6,7", "time_begin": "08:00:00", "time_end": "23:00:00"}]表示在每周的一，二，三，四，五的早上9点到晚上10点券可用或者每周的星期六和星期日的早上8点到晚上11点券可用。
        /// </summary>
        [JsonPropertyName("voucher_available_time")]
        public string VoucherAvailableTime { get; set; }

        /// <summary>
        /// 券使用说明。JSON数组字符串，最多可以有10条，每条最多50字。必须写明券的使用条件、领取条件、退款规则，请参考示例；
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public List<string> VoucherDescription { get; set; }

        /// <summary>
        /// 券发放数量
        /// </summary>
        [JsonPropertyName("voucher_quantity")]
        public string VoucherQuantity { get; set; }

        /// <summary>
        /// 无资金单品券券类型，目前仅支持无资金单品代金券（ITEM_CASHLESS_FIX_VOUCHER）、无资金单品折扣券（ITEM_CASHLESS_DISCOUNT_VOUCHER）、无资金单品特价券（ITEM_CASHLESS_SPE_VOUCHER）
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
