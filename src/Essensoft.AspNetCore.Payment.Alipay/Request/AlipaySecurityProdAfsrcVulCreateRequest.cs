using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.security.prod.afsrc.vul.create
    /// </summary>
    public class AlipaySecurityProdAfsrcVulCreateRequest : IAlipayUploadRequest<AlipaySecurityProdAfsrcVulCreateResponse>
    {
        /// <summary>
        /// 漏洞附件
        /// </summary>
        public FileItem Attachment { get; set; }

        /// <summary>
        /// 漏洞所属业务
        /// </summary>
        public Nullable<long> Business { get; set; }

        /// <summary>
        /// 漏洞所属公司
        /// </summary>
        public Nullable<long> Company { get; set; }

        /// <summary>
        /// 漏洞详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// HavanaId(淘宝uid)
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 用户上报漏洞等级
        /// </summary>
        public Nullable<long> Level { get; set; }

        /// <summary>
        /// 白帽子提交漏洞时填写的手机号
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 漏洞状态
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        public string SubmitTime { get; set; }

        /// <summary>
        /// 子平台漏洞一级类型 ID
        /// </summary>
        public string TypeSubFirstId { get; set; }

        /// <summary>
        /// 一级漏洞类型名称
        /// </summary>
        public string TypeSubFirstName { get; set; }

        /// <summary>
        /// 子平台漏洞二级类型 ID
        /// </summary>
        public string TypeSubSecondId { get; set; }

        /// <summary>
        /// 二级漏洞类型名称
        /// </summary>
        public string TypeSubSecondName { get; set; }

        /// <summary>
        /// 统一平台漏洞一级类型 ID
        /// </summary>
        public Nullable<long> TypeUnionFirstId { get; set; }

        /// <summary>
        /// 统一平台漏洞二级类型 ID
        /// </summary>
        public Nullable<long> TypeUnionSecondId { get; set; }

        /// <summary>
        /// 漏洞 URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 支付宝 ID
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
            return "alipay.security.prod.afsrc.vul.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "business", Business },
                { "company", Company },
                { "detail", Detail },
                { "hid", Hid },
                { "level", Level },
                { "mobile_phone", MobilePhone },
                { "name", Name },
                { "nick", Nick },
                { "status", Status },
                { "submit_time", SubmitTime },
                { "type_sub_first_id", TypeSubFirstId },
                { "type_sub_first_name", TypeSubFirstName },
                { "type_sub_second_id", TypeSubSecondId },
                { "type_sub_second_name", TypeSubSecondName },
                { "type_union_first_id", TypeUnionFirstId },
                { "type_union_second_id", TypeUnionSecondId },
                { "url", Url },
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "attachment", Attachment }
            };
            return parameters;
        }

        #endregion
    }
}
