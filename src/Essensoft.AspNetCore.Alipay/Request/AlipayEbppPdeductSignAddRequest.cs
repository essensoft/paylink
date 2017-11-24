using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Response;

namespace Essensoft.AspNetCore.Alipay.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.add
    /// </summary>
    public class AlipayEbppPdeductSignAddRequest : IAlipayRequest<AlipayEbppPdeductSignAddResponse>
    {
        /// <summary>
        /// 机构签约代扣来源渠道  PUBLICPLATFORM：服务窗
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 从服务窗发起则为publicId的值
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 签约类型可为空
        /// </summary>
        public string DeductType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置，可为空
        /// </summary>
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名，户主真实姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置，目前可为空
        /// </summary>
        public string PayConfig { get; set; }

        /// <summary>
        /// 用户签约时，跳转到支付宝独立密码校验页面，校验成功后会将token和对应的用户ID缓存下来，然后跳回到机构页面生成token带回给机构，机构签约时必须传入token
        /// </summary>
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值
        /// </summary>
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.ebpp.pdeduct.sign.add";
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
                { "agent_channel", AgentChannel },
                { "agent_code", AgentCode },
                { "bill_key", BillKey },
                { "biz_type", BizType },
                { "charge_inst", ChargeInst },
                { "deduct_type", DeductType },
                { "extend_field", ExtendField },
                { "notify_config", NotifyConfig },
                { "out_agreement_id", OutAgreementId },
                { "owner_name", OwnerName },
                { "pay_config", PayConfig },
                { "pay_password_token", PayPasswordToken },
                { "pid", Pid },
                { "sign_expire_date", SignExpireDate },
                { "sub_biz_type", SubBizType },
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
