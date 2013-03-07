using System;
using System.Data;
using Model.Database;

namespace Model.Patients
{
    public class PatientsService
    {
        public static bool SavePatientInfo(PatientsInfo info)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO patientInfo(caseno, patientname, sex, age, fromHosp, birthday, folk, phone, mobilephone, school, address, email, favorMatter, dislikeMatter, cooperation, selfregulating, other, registerDate, registerHour,photo) " +
                    @"VALUES ('{0}', '{1}', {2}, {3}, '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}','{12}', '{13}', '{14}', '{15}', '{16}','{17}','{18}', '{19}')",
                    info.CaseNo, info.Name, info.Sex, info.Age, info.From,
                    info.Birthtime.ToString("MM/dd/yyyy"),
                    info.Folk, info.Phone, info.Mobilephone,
                    info.School, info.Address, info.Email,
                    info.FavorMatter, info.DislikeMatter,
                    info.Cooperation, info.SelfControl,
                    info.Other, DateTime.Now.Date.ToShortDateString(),
                    DateTime.Now.Hour, info.Picture);

            RunNoQuery(cmd);

            return true;
        }

        public static bool UpdatePatientInfo(PatientsInfo info)
        {
            string cmd =
                string.Format(
                    @"UPDATE patientInfo SET patientname = '{1}', sex = {2}, age = {3}, fromHosp = '{4}', birthday = '{5}', folk = '{6}', phone = '{7}', mobilephone = '{8}', school = '{9}', 
                    address = '{10}', email = '{11}', favorMatter = '{12}', dislikeMatter = '{13}', cooperation = '{14}', selfregulating = '{15}', other = '{16}', registerDate = '{17}', registerHour = '{18}',photo = '{19}' WHERE caseno = '{0}' ",
                    info.CaseNo, info.Name, info.Sex, info.Age, info.From,
                    info.Birthtime.ToString("MM/dd/yyyy"),
                    info.Folk, info.Phone, info.Mobilephone,
                    info.School, info.Address, info.Email,
                    info.FavorMatter, info.DislikeMatter,
                    info.Cooperation, info.SelfControl,
                    info.Other, DateTime.Now.Date.ToShortDateString(),
                    DateTime.Now.Hour, info.Picture);

            RunNoQuery(cmd);

            return true;
        }

        public static bool SavePreliminaryInfo(PreliminaryInfo info)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO preliminaryInfo(caseno,  facewoundhistory,iscuring, type, degree, phase, caseexcluded, datetimepreliminary)" +
                    @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}' )",
                    info.CaseNo,
                    info.FaceWoundHistory,
                    info.IsCuring,
                    info.Type,
                    info.Extent,
                    info.Periods,
                    info.ExludedCases,
                    info.PreliminaryDate.ToString("yyyy-M-d"));
            RunNoQuery(cmd);

            return true;
        }

        public static bool UpdatePreliminaryInfo(PreliminaryInfo info)
        {
            string cmd =
                string.Format(
                    @"UPDATE preliminaryInfo SET facewoundhistory = '{1}',iscuring = '{2}', type = '{3}', degree = '{4}', phase = '{5}', caseexcluded = '{6}', datetimepreliminary = '{7}' WHERE caseno = '{0}'",
                    info.CaseNo,
                    info.FaceWoundHistory,
                    info.IsCuring,
                    info.Type,
                    info.Extent,
                    info.Periods,
                    info.ExludedCases,
                    info.PreliminaryDate.ToString("yyyy-M-d"));
            RunNoQuery(cmd);

            return true;
        }

        public static bool SaveDiagnosedInfo(DiagnosedInfo info)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO diagnosedInfo(caseno, patientname, writer, filltime, type, score, personalcontext, sickhistorynow,sickhistorybefore,keywords,checkinfo,diagnoseinfo,cureinfo,picture)" +
                    @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}', '{11}','{12}', '{13}')",
                    info.CaseNo, info.PatientName, info.Writer, info.Filltime, info.Type, info.Score,
                    info.PersonalContext, info.SickHistoryNow,
                    info.SickHistoryBefore, info.KeyWords,
                    info.CheckInfo, info.DiagnoseInfo, info.CureInfo, info.Picture);

           RunNoQuery(cmd);
            return true;
        }

        public static bool SaveOrderInfo(OrderInfo info)
        {
            string cmd = string.Format(
                @"INSERT INTO orderInfo(caseno, patientname, doctorname, ndays, orderdatetime, ordercontext, mobilephone, msgstate, orderstate)" +
                @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                info.CaseNo,
                info.PatientName,
                info.DoctorName,
                info.NDays,
                info.OrderDatetime,
                info.OrderContext,
                info.MobilePhone,
                info.MsgState,
                info.OrderState);
            RunNoQuery(cmd);
            return true;
        }

        public static bool DeleteOrder(string caseno)
        {
            string cmd = string.Format(
                @"DELETE FROM orderInfo WHERE caseno = '{0}'", caseno);

            RunNoQuery(cmd);
            return true;
        }

        public static bool ModifyOrderInfo(OrderInfo info)
        {
            string cmd = string.Format(
                @"UPDATE orderInfo SET doctorname = '{0}', orderdatetime = '{1}', ordercontext = '{2}' WHERE caseno = '{3}'",
                info.DoctorName, info.OrderDatetime, info.OrderContext, info.CaseNo);

           RunNoQuery(cmd);

            return true;
        }

        public static bool ModifyOrderState(string caseno, string state)
        {
            string cmd = string.Format(@"UPDATE orderInfo SET orderstate = '{0}' WHERE caseno = '{1}'", state, caseno);
            RunNoQuery(cmd);

            return true;
        }

        public static DataTable QuerOrders(DateTime fromDate, DateTime toDate, string doctor, string patientname)
        {
            string cmd = "SELECT * FROM [orderInfo]";

            //cmd += string.Format(@" WHERE orderdatetime >= '{0}' and orderdatetime <= '{1}'",
            //                     fromDate.ToString("yyyy/M/d 00:00:00"), toDate.ToString("yyyy/M/d 23:59:59"));

            cmd += string.Format(@" WHERE [orderdatetime] Between '{0}' AND '{1}'",
                                 fromDate.ToString("yyyy/M/d 00:00:00"), toDate.ToString("yyyy/M/d 23:59:59"));

            if (!string.IsNullOrEmpty(doctor))
            {
                cmd += string.Format(@" AND doctorname LIKE '%{0}%'", doctor);
            }
            if (!string.IsNullOrEmpty(patientname))
            {
                cmd += string.Format(@" AND patientname LIKE '%{0}%'", patientname);
            }

            return RunQuery(cmd);
        }

        public static DataTable QueryCaseNo()
        {
            string cmd = string.Format(@"SELECT caseno FROM [patientInfo]");
            return RunQuery(cmd);
        }

        public static DataTable QueryOrders(string item = "", string value = "")
        {
            string cmd = item != string.Empty
                             ? string.Format(@"SELECT * FROM [orderInfo] WHERE {0} like '%{1}%'  ", item, value)
                             : string.Format(@"SELECT * FROM [orderInfo]");

            return RunQuery(cmd);
        }

        public static DataTable QueryPatients(string item = "", string value = "")
        {
            string cmd = value != string.Empty
                             ? string.Format(@"SELECT * FROM [patientInfo] WHERE {0} like '%{1}%'  ", item, value)
                             : string.Format(@"SELECT * FROM [patientInfo]");

            return RunQuery(cmd);
        }

        public static DataTable EasyQueryPatients(string name, string caseno, string sex, string age, string hospital)
        {
            var cond = new string[5];
            string cmd = @"SELECT * FROM [patientInfo]";
            if (!string.IsNullOrEmpty(name))
                cond[0] = string.Format(@" patientname LIKE '%{0}%'", name);
            if (!string.IsNullOrEmpty(caseno))
                cond[1] = string.Format(@" caseno = '{0}'", caseno);
            if (!string.IsNullOrEmpty(sex))
            {
                var sexsymbol = sex == "男" ? 1 : 0;
                cond[2] = string.Format(@" sex = {0}", sexsymbol);
            }
            if (!string.IsNullOrEmpty(age))
            {
                var agesymbol = Convert.ToInt32(age);
                cond[3] = string.Format(@" age = {0}", agesymbol);
            }
            if (!string.IsNullOrEmpty(hospital))
                cond[4] = string.Format(@" fromHosp LIKE '%{0}%'", hospital);

            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrEmpty(cond[i]) && !flag)
                {
                    cmd += " WHERE";
                    flag = true;

                    cmd += cond[i];
                }
                else if (!string.IsNullOrEmpty(cond[i]))
                {
                    cmd += " AND" + cond[i];
                }
            }

            return RunQuery(cmd);
        }

        public static DataTable QueryPreliminaryInfo(string item, string value)
        {
            string cmd =
                string.Format(@"SELECT * FROM [preliminaryInfo] WHERE {0} = '{1}'", item, value);
            return RunQuery(cmd);
        }

        public static DataTable QueryDiagnosedInfo(string item, string value)
        {
            string cmd =
                string.Format(@"SELECT * FROM  [diagnosedInfo] WHERE  {0} = '{1}'", item, value);
            return RunQuery(cmd);
        }

        public static void SaveSalaryInfo(SalaryInfo info)
        {
            string cmd = string.Format(
                @"INSERT INTO salaryInfo(caseno, generalCharge, cleanCharge,inmouthCharge,pulltoothCharge, surgeryCharge, 
                fixrestoreCharge, restoreCharge, orthodonticCharge, emitCharge, drugCharge, foreignmedicineCharge, planttoothCharge, otherCharge)" +
                @"VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                info.CaseNo, info.GeneralCharge, info.CleanCharge, info.InMouthCharge,
                info.PullToothCharge, info.SurgeryCharge, info.FixRestoreCharge, 
                info.RestoreCharge, info.OrthodonticCharge, info.EmitCharge,
                info.DrugCharge, info.ForeignMedicineCharge, info.PlantToothCharge, info.OtherCharge);

            RunNoQuery(cmd);
        }

        public static DataTable QueryPrescriptions()
        {
            string cmd = string.Format(@"SELECT * From [prescriptiontemplate]");
            return RunQuery(cmd);
        }

        public static void SaveReVisitInfo(ReVisitInfo info)
        {
            string cmd = string.Format(
                @"INSERT INTO revisit(caseno, revisitdate, isvisit, context, service, quality, remark)" +
                @"VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                info.Caseno, info.Date, info.IsVisit, info.Context, info.Service, info.Quality, info.Remark
                );
            RunNoQuery(cmd);
        }

        public static DataTable QueryTodayVisitor()
        {
            string cmd =
                string.Format(
                    @"SELECT caseno, patientname, sex, age, revisitdate, isvisit, context, service, quality, remark
                                                        FROM [patientInfo], [revisit] WHERE patientInfo.caseno = revisit.caseno");

            return RunQuery(cmd);
        }

        private static DataTable RunQuery(string cmd)
        {
            return DbSingleton.Instance.RunQuery(cmd);
        }

        private static void RunNoQuery(string cmd)
        {
            DbSingleton.Instance.RunNoQuery(cmd);
        }
    }
}