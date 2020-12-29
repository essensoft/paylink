using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ebpp.bill.add
    /// </summary>
    public class AlipayEbppBillAddRequest : IAlipayRequest<AlipayEbppBillAddResponse>
    {
        /// <summary>
        /// 外部订单号
        /// </summary>
        public string BankBillNo { get; set; }

        /// <summary>
        /// 账单的账期，例如201203表示2012年3月的账单。
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单的服务费。
        /// </summary>
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficRegulations { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ebpp.bill.add";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "bank_bill_no", BankBillNo },
                { "bill_date", BillDate },
                { "bill_key", BillKey },
                { "charge_inst", ChargeInst },
                { "extend_field", ExtendField },
                { "merchant_order_no", MerchantOrderNo },
                { "mobile", Mobile },
                { "order_type", OrderType },
                { "owner_name", OwnerName },
                { "pay_amount", PayAmount },
                { "service_amount", ServiceAmount },
                { "sub_order_type", SubOrderType },
                { "traffic_location", TrafficLocation },
                { "traffic_regulations", TrafficRegulations }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
