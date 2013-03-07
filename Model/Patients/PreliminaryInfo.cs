using System;
using System.Collections;

namespace Model.Patients
{
    public struct PreliminaryInfo
    {
        public string CaseNo;
        public string FaceWoundHistory;
        public string IsCuring;
        public string Type;
        public string Extent;
        public string Periods;
        public string ExludedCases;
        public DateTime PreliminaryDate;
        
        public Hashtable ToHashtable()
        {
            var ht = new Hashtable();
            if (FaceWoundHistory != string.Empty)
            {
                ht.Add("面部创伤史：", FaceWoundHistory);
            }
            if (IsCuring != string.Empty)
            {
                ht.Add("是否正在进行其他治疗：", IsCuring);
            }
            if (Type != string.Empty)
            {
                ht.Add("错颌类型：", Type);
            }
            if (Extent != string.Empty)
            {
                ht.Add("严重程度：", Extent);
            }
            if (Periods != string.Empty)
            {
                ht.Add("换牙期：", Periods);
            }
            if (ExludedCases != string.Empty)
            {
                ht.Add("是否排除病历：", ExludedCases);
            }

            return ht;
        }
    }
}