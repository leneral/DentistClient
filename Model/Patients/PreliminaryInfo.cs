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
                ht.Add("�沿����ʷ��", FaceWoundHistory);
            }
            if (IsCuring != string.Empty)
            {
                ht.Add("�Ƿ����ڽ����������ƣ�", IsCuring);
            }
            if (Type != string.Empty)
            {
                ht.Add("������ͣ�", Type);
            }
            if (Extent != string.Empty)
            {
                ht.Add("���س̶ȣ�", Extent);
            }
            if (Periods != string.Empty)
            {
                ht.Add("�����ڣ�", Periods);
            }
            if (ExludedCases != string.Empty)
            {
                ht.Add("�Ƿ��ų�������", ExludedCases);
            }

            return ht;
        }
    }
}