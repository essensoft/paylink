using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Response;

namespace Essensoft.AspNetCore.Alipay.Request
{
    /// <summary>
    /// AOP API: alipay.pass.tpl.update
    /// </summary>
    public class AlipayPassTplUpdateRequest : IAlipayRequest<AlipayPassTplUpdateResponse>
    {
        /// <summary>
        /// 模版内容
        /// </summary>
        public string TplContent { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        public string TplId { get; set; }

        #region IAlipayRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AlipayObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return returnUrl;
        }

        public void SetTerminalType(string terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return terminalType;
    	}

    	public void SetTerminalInfo(string terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return terminalInfo;
    	}

        public void SetProdCode(string prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.pass.tpl.update";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "tpl_content", TplContent },
                { "tpl_id", TplId }
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
