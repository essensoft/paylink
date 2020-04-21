using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtSchoolinfoModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtSchoolinfoModifyModel : AlipayObject
    {
        /// <summary>
        /// 与浙江网商交易见证平台有交互ISV输入网商交易异步通知回调URL，教育缴费同步账单信息给网商，网商会回调此url，ISV即可获取网商相关的参数，根据教育缴费平台账单发送接口返回的 order_no和网商返回的outer_trade_no来对应账单信息。
        /// </summary>
        [JsonPropertyName("bank_notify_url")]
        public string BankNotifyUrl { get; set; }

        /// <summary>
        /// 与浙江网商交易见证平台有交互的ISV,由交易见证平台分配给合作方业务平台 签约唯一ID ，由网商分配给ISV的渠道参数
        /// </summary>
        [JsonPropertyName("bank_partner_id")]
        public string BankPartnerId { get; set; }

        /// <summary>
        /// 与浙江网商交易见证平台有交互的ISV在创建账户时的uid，也就是ISV平台上的用户ID（字母或数字）
        /// </summary>
        [JsonPropertyName("bank_uid")]
        public string BankUid { get; set; }

        /// <summary>
        /// 对应集团到卡模式的银行编号.学校与支付宝后台签约时，由学校提交给支付宝的编号
        /// </summary>
        [JsonPropertyName("bankcard_no")]
        public string BankcardNo { get; set; }

        /// <summary>
        /// 集团收单模式：分账批次号，支付宝配置后提供的银行卡批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 学校开通直付通卡编号，smid与card_alias_no必须同时填写
        /// </summary>
        [JsonPropertyName("card_alias_no")]
        public string CardAliasNo { get; set; }

        /// <summary>
        /// 城市的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 集团收单模式：BD批量上传银行卡信息后，支付宝系统分配给ISV的每个卡分配的唯一标识
        /// </summary>
        [JsonPropertyName("corporate_branch_pid")]
        public string CorporateBranchPid { get; set; }

        /// <summary>
        /// 区县的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// ISV公司名称 ， 会在账单详情页面展示给用户
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 注意：本参数从1.3版本开始已经废弃，不再需要传递。    由支付宝提供的给已经签约的isv的编码，业务上一般直接采用isv的支付宝PID。
        /// </summary>
        [JsonPropertyName("isv_no")]
        public string IsvNo { get; set; }

        /// <summary>
        /// 此通知地址是为了保持教育缴费平台与ISV商户支付状态一致性。用户支付成功后，支付宝会根据本isv_notify_url(异步通知说明https://docs.open.alipay.com/203/105286/)，通过POST请求的形式将支付结果作为参数通知到商户系统，ISV商户可以根据返回的参数更新账单状态。
        /// </summary>
        [JsonPropertyName("isv_notify_url")]
        public string IsvNotifyUrl { get; set; }

        /// <summary>
        /// ISV的联系方式 ， 会在账单详情页面展示给用户，用户有问题可以直接联系此电话获取帮助
        /// </summary>
        [JsonPropertyName("isv_phone")]
        public string IsvPhone { get; set; }

        /// <summary>
        /// 填写已经签约教育缴费的isv的支付宝PID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 省份的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 学校的校徽或logo，在学校展示页面作为学校的标识。该字段为图片的链接地址，只支持png或jpg图片格式，图片高度为108，宽度为108 ，不大于20k。  注意：此链接要求公网可以访问，否则无法正常展示。
        /// </summary>
        [JsonPropertyName("school_icon")]
        public string SchoolIcon { get; set; }

        /// <summary>
        /// 如果填写了school_icon参数，则此字段不能为空。目前只支持png和jpg两种格式
        /// </summary>
        [JsonPropertyName("school_icon_type")]
        public string SchoolIconType { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校签约支付宝教育缴费支付宝pid,如果是直付通学校，填写直付通返回的smid
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学校(机构)标识码（由教育部按照国家标准及编码规则编制，可以在教育局官网查询）
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 学校的类型：  1：代表托儿所； 2：代表幼儿园；3：代表小学；4：代表初中；5：代表高中。  如果学校兼有多种属性，可以连写，比如：  45：代表兼有初中部高中部；34：代表兼有小学部初中部
        /// </summary>
        [JsonPropertyName("school_type")]
        public string SchoolType { get; set; }

        /// <summary>
        /// 学校开通直付通返回的二级商户id，smid与card_alias_no必须同时填写
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 集团收单模式：分账批次号，支付宝配置后提供的银行卡批次号
        /// </summary>
        [JsonPropertyName("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 与浙江网商交易见证平台有交互的ISV,由网商分配给ISV的渠道参数
        /// </summary>
        [JsonPropertyName("white_channel_code")]
        public string WhiteChannelCode { get; set; }
    }
}
