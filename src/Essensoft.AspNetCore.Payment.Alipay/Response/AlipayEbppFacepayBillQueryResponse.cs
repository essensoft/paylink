using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppFacepayBillQueryResponse.
    /// </summary>
    public class AlipayEbppFacepayBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝交易流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 仅缴税业务返回，业务状态  CLOSED: 已关闭  TO_PAY：待支付  PAID: 已支付  BIZ_SUC: 业务成功。对缴税来说，意味着银行已明确返回缴税成功。  BIZ_FAIL: 业务失败（用户支付的资金会原路退回）。对缴税来说，意味着缴税一定没有做成。
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 出账机构代码（缴税业务：指征收机关英文代码，例如南京玄武国税（NJXWGS））
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构账单ID（缴税业务：用外部申报号）
        /// </summary>
        [JsonPropertyName("inst_no")]
        public string InstNo { get; set; }

        /// <summary>
        /// ISV流水号，用于控制幂等，须确保全局唯一（缴税业务：可采用{征收机关代码}-{外部申报号}的形式）
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// SUCCESS - 付款成功（只有明确得到此状态，才能认为付款成功）  FAIL - 付款失败（明确得到此状态，机构可认为本次支付失败，再次扫码）  WAIT_PAY - 等待用户输入密码支付（得到此状态，需轮询10次，每隔3s一次，若一直得不到明确结果需要调用撤销接口，认为支付失败）  UNKNOWN - 状态未知（得到此状态，需轮询2次，每隔5s一次，若一直得不到明确结果需要调用撤销接口，认为支付失败）  注1：缴费业务如果需要支付宝销账，则不支持撤销。  注2：缴税业务比较特殊，不能调用撤销。如果查询得到WAIT_PAY，就需要一定间隔后（建议3s）再次查询，直到拿到SUCCESS/FAIL为止；如果查询得到UNKNOWN，也要轮询下去（建议5s为间隔），若轮询超限（建议3次以上）仍未拿到确定结果，可尝试重新发起扣款。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易付款日期
        /// </summary>
        [JsonPropertyName("trade_date")]
        public string TradeDate { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
