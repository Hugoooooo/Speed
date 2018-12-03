using System;
using System.Framework.DataLayer;

namespace System.DataLayer.Views
{
    /// <summary>
    /// Account ���K�n�y�z�C
    /// </summary>
    public class InventoryInfo : BaseView
    {
        #region Name Config
        public enum ncConditions { serno,sernolist , verdor, status , LKverdor, LKname, LKtype, NINsernolist , statuslist }
        public enum ncOrderBy { ODBverdor, ODBname, ODBstatus, ODBmodifydttm }
        public enum ncFields { INV_SERNO, INV_VENDOR, INV_NAME, INV_STATUS, INV_INAMT, INV_INDTTM, INV_INCOMMENT, INV_OUTAMT, INV_OUTDTTM, INV_OUTCOMMENT, INV_OUTDEALER, INV_MODIFIEDBY, INV_MODIFIEDDTTM, INV_RETURNAMT, INV_RETURNCOMMENT, INV_RETURNDTTM, INV_TYPE, INV_COLOR, INV_SIZE }
        #endregion

        #region Fields
        
        /// <summary>�Ǹ�</summary>
        public string INV_SERNO = "";
        /// <summary>�ӫ~�N��</summary>
        public string INV_VENDOR = "";
        /// <summary>�ӫ~�W��</summary>
        public string INV_NAME = "";
        /// <summary>�ӫ~����</summary>
        public string INV_TYPE = "";
        /// <summary>�ӫ~�C��</summary>
        public string INV_COLOR = "";
        /// <summary>�ӫ~�ؤo</summary>
        public string INV_SIZE = "";
        /// <summary>���A</summary>
        public string INV_STATUS = "";
        /// <summary>�i�f���B</summary>
        public int INV_INAMT = 0;
        /// <summary>�i�f�Ƶ�</summary>
        public string INV_INCOMMENT = "";
        /// <summary>�X�f���B</summary>
        public int INV_OUTAMT = 0;
        /// <summary>�X�f�Ƶ�</summary>
        public string INV_OUTCOMMENT = "";
        /// <summary>�t�d�H</summary>
        public string INV_OUTDEALER = "";
        /// <summary>�ק�H��</summary>
        public string INV_MODIFIEDBY = "";
        /// <summary>�i�f���</summary>
        public DateTime INV_INDTTM;
        /// <summary>�X�f���</summary>
        public DateTime INV_OUTDTTM;
        /// <summary>�ק���</summary>
        public DateTime INV_MODIFIEDDTTM;
        /// <summary>�h�f���B</summary>
        public int INV_RETURNAMT = 0;
        /// <summary>�h�f�Ƶ�</summary>
        public string INV_RETURNCOMMENT = "";
        /// <summary>�h�f���</summary>
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
