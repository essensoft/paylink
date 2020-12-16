using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtBillingSyncModel : AlipayObject
    {
        /// <summary>
        /// 如果所在学校分校区，传入分校区编号，不传默认为总校或无分校区
        /// </summary>
        [JsonPropertyName("campus_id")]
        public string CampusId { get; set; }

        /// <summary>
        /// 如果所在学校分校区，传入分校区名称，不传默认为总校或无分校区
        /// </summary>
        [JsonPropertyName("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 缴费项目明细
        /// </summary>
        [JsonPropertyName("charge_items")]
        public List<EduPayItems> ChargeItems { get; set; }

        /// <summary>
        /// 学校所在市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 当前就读班级
        /// </summary>
        [JsonPropertyName("current_class")]
        public string CurrentClass { get; set; }

        /// <summary>
        /// 当前就读年级，取值： 小一～小五、中预、中一～中三、高一～高三、大一～大三
        /// </summary>
        [JsonPropertyName("current_grade")]
        public string CurrentGrade { get; set; }

        /// <summary>
        /// 学校所在区
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// 学校所在区国标码
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 业务拓展字段，以json格式传递
        /// </summary>
        [JsonPropertyName("ext_info")]
        public BillSyncExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 账单生成时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 账单更新时间
        /// </summary>
        [JsonPropertyName("gmt_modify")]
        public string GmtModify { get; set; }

        /// <summary>
        /// 交易支付时间，取支付宝支付接口返回的gmt_payment值
        /// </summary>
        [JsonPropertyName("gmt_paytime")]
        public string GmtPaytime { get; set; }

        /// <summary>
        /// isv的账单号，针对教育缴费平台的外部唯一单号
        /// </summary>
        [JsonPropertyName("isv_order_no")]
        public string IsvOrderNo { get; set; }

        /// <summary>
        /// 账单总金额。单位：元，保留两位小数
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 账单状态。0.未支付, 1:支付中, 2:支付成功, 3:支付失败, 4:退款已关闭,5:缴费成功,6:逾期关闭,8:ISV账单关闭
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 交易金额，取支付宝支付接口返回的gmt_payment值。单位：元，保留两位小数
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 实际完成缴费支付的用户支付宝uid，缴费记录挂账在该支付宝账户下
        /// </summary>
        [JsonPropertyName("pay_user_id")]
        public string PayUserId { get; set; }

        /// <summary>
        /// 学校所在省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 学校编号，需保证唯一，公立学校建议用办学许可证号，私立学校用组织机构代码证。 对应直付通进件接口中external_id。
        /// </summary>
        [JsonPropertyName("school_external_id")]
        public string SchoolExternalId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校签约的支付宝主账户PID或直付通进件后的二级商户smid
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学校性质：1-公立学校；2-民办学校；3-教培机构
        /// </summary>
        [JsonPropertyName("school_property")]
        public string SchoolProperty { get; set; }

        /// <summary>
        /// 学校类型。1-学前教育；2-中小学教育；3-高等教育；4-培训机构。
        /// </summary>
        [JsonPropertyName("school_type")]
        public string SchoolType { get; set; }

        /// <summary>
        /// 教育缴费平台的账单来源。1-ISV发送；2-钉钉同步
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 学生编号。只支持字母和数字类型，一般以教育局学号为准，作为学生的唯一标识。
        /// </summary>
        [JsonPropertyName("student_code")]
        public string StudentCode { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [JsonPropertyName("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 缴费账单名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 渠道侧发起支付宝交易的支付宝交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 标价币种, total_amount对应的币种单位，非CNY人民币种需传入。 目前支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 为学生缴费的家长信息
        /// </summary>
        [JsonPropertyName("user")]
        public UserDetails User { get; set; }
    }
}
