using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.marketing.campaign.rule.tag.create
    /// </summary>
    public class AlipayMarketingCampaignRuleTagCreateRequest : IAlipayUploadRequest<AlipayMarketingCampaignRuleTagCreateResponse>
    {
        /// <summary>
        /// 每行格式如下的csv文件，以,隔开，文件最大50M  2088004384251514,2088102344258114,13888888888,aaa@bbb.com,34032198407138000,北京市海淀区  分别意义：16位随机数字,userid,手机号码,邮件地址,身份证号,地区
        /// </summary>
        public FileItem Customerdata { get; set; }

        /// <summary>
        /// 签约商户下属子机构唯一编号
        /// </summary>
        public string Mpid { get; set; }

        /// <summary>
        /// 针对自定义人群的操作，可以创建或者删除，当创建时，自定义标签可为空
        /// </summary>
        public string Operatetype { get; set; }

        /// <summary>
        /// 自定义标签id，创建时可为空
        /// </summary>
        public string Selftag { get; set; }

        /// <summary>
        /// 自定义人群标签的描述信息（操作为CREATE时使用）
        /// </summary>
        public string Tagdesc { get; set; }

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.marketing.campaign.rule.tag.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "mpid", Mpid },
                { "operatetype", Operatetype },
                { "selftag", Selftag },
                { "tagdesc", Tagdesc }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "customerdata", Customerdata }
            };
            return parameters;
        }

        #endregion
    }
}
