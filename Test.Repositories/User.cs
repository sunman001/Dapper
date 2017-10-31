using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Repositories
{
   public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
     
        public int u_id { get; set; }

        /// <summary>
        /// 登录邮件地址
        /// </summary>
      
        public string u_email { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
      
        public string u_password { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
     
        public string u_realname { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
    
        public string u_phone { get; set; }

        /// <summary>
        /// 联系qq
        /// </summary>
      
        public string u_qq { get; set; }

        /// <summary>
        /// 开户银行全称
        /// </summary>
     
        public string u_bankname { get; set; }

        /// <summary>
        /// 开户名
        /// </summary>    
        public string u_name { get; set; }

        /// <summary>
        /// 开户账号
        /// </summary>
      
        public string u_account { get; set; }

        /// <summary>
        /// 类别：0 个人 1 企业
        /// </summary>
     
        public int u_category { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
     
        public string u_idnumber { get; set; }

        /// <summary>
        /// 持证照片地址
        /// </summary>
  
        public string u_photo { get; set; }

        /// <summary>
        /// 身份证反面照片
        /// </summary>
    
        public string u_photof { get; set; }

        /// <summary>
        /// 开户许可证
        /// </summary>
    
        public string u_licence { get; set; }
        /// <summary>
        /// 营业执照照片
        /// </summary>
     
        public string u_blicense { get; set; }

        /// <summary>
        /// 营业执照编号
        /// </summary>
      
        public string u_blicensenumber { get; set; }

        /// <summary>
        /// 用户登录次数
        /// </summary>
   
        public int u_count { get; set; }

        /// <summary>
        /// 账户状态：0 冻结 1 正常
        /// </summary>
      
        public int u_state { get; set; }

        /// <summary>
        /// 手动提款标示（0：自动，1：手动）
        /// </summary>
   
        public int u_drawing { get; set; }

        /// <summary>
        /// 商务id
        /// </summary>
   
        public int u_merchant_id { get; set; }

        /// <summary>
        /// 审核状态：-1 未通过 0 等待审核
        /// </summary>
    
        public int u_auditstate { get; set; }

        /// <summary>
        /// 父级用户ID(0:父级)
        /// </summary>
  
        public int u_topid { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
   
        public string u_address { get; set; }

        ///// <summary>
        ///// 手续费(默认为0)
        ///// </summary>
        //[EntityTracker(Label = "手续费", Description = "手续费")]
        //public decimal u_poundage { get; set; }

        /// <summary>
        /// u_role_id
        /// </summary>
    
        public int u_role_id { get; set; }

        /// <summary>
        /// 关联关系[0:未指定,1:商务,2:代理商]
        /// </summary>
     
        public int relation_type { get; set; }

        /// <summary>
        /// 关联的关系人ID
        /// </summary>
   
        public int relation_person_id { get; set; }

        /// <summary>
        /// 开发者服务费关联表ID(商务或者代理商设置此项,根据relation_type字段)
        /// </summary>
     
        public int ServiceFeeRatioGradeId { get; set; }

        /// <summary>
        /// 是否特批(如果是特批,读取系统表[jmp_system]中的CO_SPECIAL_SERVICE_FEE_RATIO选项的值)
        /// </summary>
      
        public bool IsSpecialApproval { get; set; }

        /// <summary>
        /// 开发者名称
        /// </summary>
      
        public string DisplayName { get; set; }

        /// <summary>
        /// 费率等级名称
        /// </summary>
     
        public string Name { get; set; }

        /// <summary>
        /// 企业法人
        /// </summary>
   
        public string BusinessEntity { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
      
        public string RegisteredAddress { get; set; }

        public decimal ServiceFeeRatio { get; set; }

      
        public decimal CustomerWithoutAgentRatio { get; set; }

        /// <summary>
        /// 特批时需要减掉的服务费率(小数)
        /// </summary>
    
        public decimal SpecialApproval { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
      
        public DateTime? u_time { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
   
        public string u_auditor { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
    
        public string u_paypwd { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
      
        public decimal FrozenMoney { get; set; }
    }
}
