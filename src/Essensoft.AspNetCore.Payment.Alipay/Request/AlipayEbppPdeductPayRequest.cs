using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ebpp.pdeduct.pay
    /// </summary>
    public class AlipayEbppPdeductPayRequest : IAlipayRequest<AlipayEbppPdeductPayResponse>
    {
        /// <summary>
        /// 渠道码，如用户通过机构通过服务窗进来签约则是PUBLICFORM，此值可随意传，只要不空就行
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 户号，缴费单位用于标识每一户的唯一性的
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 扩展参数。必须以key value形式定义，  转为json为格式：{"key1":"value1","key2":"value2",  "key3":"value3","key4":"value4"}   后端会直接转换为MAP对象，转换异常会报参数格式错误
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        public string FineAmount { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 商户外部业务流水号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款金额，支付总金额，包含滞纳金
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 商户PartnerId
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.ebpp.pdeduct.pay";
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
                { "agent_channel", AgentChannel },
                { "agent_code", AgentCode },
                { "agreement_id", AgreementId },
                { "bill_date", BillDate },
                { "bill_key", BillKey },
                { "extend_field", ExtendField },
                { "fine_amount", FineAmount },
                { "memo", Memo },
                { "out_order_no", OutOrderNo },
                { "pay_amount", PayAmount },
                { "pid", Pid },
                { "user_id", UserId }
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
