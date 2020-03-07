using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.certify.verify.idcard
    /// </summary>
    public class AlipayCertifyVerifyIdcardRequest : IAlipayRequest<AlipayCertifyVerifyIdcardResponse>
    {
        /// <summary>
        /// 访问来源，业务系统 用于结算
        /// </summary>
        public string BizFrom { get; set; }

        /// <summary>
        /// 业务主体ID 如userId
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        public string CertName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 认证来源 : 业务BU,如网商银行
        /// </summary>
        public string CertifyFrom { get; set; }

        /// <summary>
        /// Y强制查官网，N缺省，先查本地后官网
        /// </summary>
        public string ForcePublic { get; set; }

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
            return "alipay.certify.verify.idcard";
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
                { "biz_from", BizFrom },
                { "biz_id", BizId },
                { "cert_name", CertName },
                { "cert_no", CertNo },
                { "certify_from", CertifyFrom },
                { "force_public", ForcePublic }
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
