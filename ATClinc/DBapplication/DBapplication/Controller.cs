using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public DataTable SelectPrescriptions(string Pnum)
        {
            string query = "Select Medicines as 'Procedure' , Comment , Diagnose , AppointmentDate from Presc where PatPhone = '" + Pnum + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllAboutPatient(string P_num)
        {
            string query = "Select FirstName  , MidName as middleName , LName as LastName, P_num as PhoneNumber , VisitDate , NextVisit from Patient p , PatDate pp  where p.P_num = pp.phone_number and P_num = '" + P_num + " '"; 
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetPhotosDetails(string P_num)
        {
            string query = "Select ID from PatPic where phoneNumber = '" + P_num + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetALLPhoto(string Pnum, string maxID, string minID)
        {
            string query = "select ID, img from PatPic where phoneNumber = '" + Pnum + "' and id <= " + maxID + " and id >= " + minID + " ;";
            return dbMan.GetPhotos(query);
        }

        public int UpdateNextVisit(string Pnum, string Date)
        {
            string query = "UPDATE PatDate set NextVisit = '" + Date + "' WHERE PatDate.phone_number ='" + Pnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateVisitDate(string Pnum)
        {
            string query = "UPDATE PatDate set VisitDate = NextVisit WHERE phone_number ='" + Pnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPatient(string FName, string MidName, string LName, string Pnum, string age, string Gend)
        {

            string query = "INSERT INTO Patient " +
                            "Values ('" + FName + "','" + MidName + "','" + LName + "','"+Pnum+"'," + age + ",'"+Gend+"' );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPatDate(string Date, string Pnum)
        {

            string query = "INSERT INTO PatDate (VisitDate, NextVisit , phone_number)" +
                            "Values ('" + Date +"','"+Date+ "','" + Pnum + "' );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertDesc(string Desc, string Comm, string Diag, string Pnum)
        {

            string query = "insert into Presc values((select VisitDate from PatDate  where PatDate.phone_number = '" + Pnum + "'), '" + Pnum + "' , '" + Desc + "','" + Comm + "','" + Diag+"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteImg(string PNum, string ID)
        {
            string query = "delete from PatPic where phoneNumber = '" + PNum + "' and ID = " + ID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
