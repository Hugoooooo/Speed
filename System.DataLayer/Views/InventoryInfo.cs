using System;
using System.Framework.DataLayer;

namespace System.DataLayer.Views
{
    /// <summary>
    /// Account 的摘要描述。
    /// </summary>
    public class InventoryInfo : BaseView
    {
        #region Name Config
        public enum ncConditions { serno,sernolist , verdor, status , LKverdor, LKname, LKtype, NINsernolist , statuslist }
        public enum ncOrderBy { ODBverdor, ODBname, ODBstatus, ODBmodifydttm }
        public enum ncFields { INV_SERNO, INV_VENDOR, INV_NAME, INV_STATUS, INV_INAMT, INV_INDTTM, INV_INCOMMENT, INV_OUTAMT, INV_OUTDTTM, INV_OUTCOMMENT, INV_OUTDEALER, INV_MODIFIEDBY, INV_MODIFIEDDTTM, INV_RETURNAMT, INV_RETURNCOMMENT, INV_RETURNDTTM, INV_TYPE, INV_COLOR, INV_SIZE }
        #endregion

        #region Fields
        
        /// <summary>序號</summary>
        public string INV_SERNO = "";
        /// <summary>商品代號</summary>
        public string INV_VENDOR = "";
        /// <summary>商品名稱</summary>
        public string INV_NAME = "";
        /// <summary>商品類型</summary>
        public string INV_TYPE = "";
        /// <summary>商品顏色</summary>
        public string INV_COLOR = "";
        /// <summary>商品尺寸</summary>
        public string INV_SIZE = "";
        /// <summary>狀態</summary>
        public string INV_STATUS = "";
        /// <summary>進貨金額</summary>
        public int INV_INAMT = 0;
        /// <summary>進貨備註</summary>
        public string INV_INCOMMENT = "";
        /// <summary>出貨金額</summary>
        public int INV_OUTAMT = 0;
        /// <summary>出貨備註</summary>
        public string INV_OUTCOMMENT = "";
        /// <summary>負責人</summary>
        public string INV_OUTDEALER = "";
        /// <summary>修改人員</summary>
        public string INV_MODIFIEDBY = "";
        /// <summary>進貨日期</summary>
        public DateTime INV_INDTTM;
        /// <summary>出貨日期</summary>
        public DateTime INV_OUTDTTM;
        /// <summary>修改日期</summary>
        public DateTime INV_MODIFIEDDTTM;
        /// <summary>退貨金額</summary>
        public int INV_RETURNAMT = 0;
        /// <summary>退貨備註</summary>
        public string INV_RETURNCOMMENT = "";
        /// <summary>退貨日期</summary>
        public DateTime INV_RETURNDTTM;
        
        #endregion

        public InventoryInfo(IConnection AConn)
            : base(AConn)
        {
            base.Fields = @"INV_SERNO,INV_VENDOR,INV_NAME,INV_STATUS,INV_INAMT,INV_INDTTM,INV_INCOMMENT,INV_OUTAMT,INV_OUTDTTM,INV_OUTCOMMENT,INV_OUTDEALER,INV_MODIFIEDBY,INV_MODIFIEDDTTM,INV_RETURNAMT,INV_RETURNCOMMENT,INV_RETURNDTTM,INV_TYPE,INV_COLOR,INV_SIZE";
            base.From = "INVENTORY";
            //base.OrderBy = "INV_VENDOR,INV_INDTTM desc";
            base.ConditionDictionary.Add("sernolist", " INV_SERNO  IN (?) ");
            base.ConditionDictionary.Add("NINsernolist", " INV_SERNO  NOT IN (?) ");
            base.ConditionDictionary.Add("serno", " INV_SERNO = N'?' ");
            base.ConditionDictionary.Add("verdor", " INV_VENDOR = N'?' ");
            base.ConditionDictionary.Add("LKverdor", " INV_VENDOR LIKE N'%?%' ");
            base.ConditionDictionary.Add("LKname", " INV_NAME LIKE N'%?%' ");
            base.ConditionDictionary.Add("LKtype", " INV_TYPE LIKE N'%?%' ");
            base.ConditionDictionary.Add("statuslist", " INV_STATUS  IN (?) ");
            base.ConditionDictionary.Add("status", " INV_STATUS = N'?' ");
            base.OrderByDictionary.Add("ODBverdor", " INV_VENDOR ASC");
            base.OrderByDictionary.Add("ODBname", " INV_NAME ASC");
            base.OrderByDictionary.Add("ODBstatus", " INV_STATUS ASC");
            base.OrderByDictionary.Add("ODBmodifydttm", " INV_MODIFIEDDTTM desc");
        }
       

    }

}
