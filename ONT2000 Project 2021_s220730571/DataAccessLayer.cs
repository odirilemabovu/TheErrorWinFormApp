using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ONT2000_Project_2021_s220730571
{
    public class DataAccessLayer
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //Get Data
        public DataTable GetUserData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetUserData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetRoleData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetRoleDetails", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetUserDataByID(int UserID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetUserDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleDataByID(int ModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetYearDataByID(int YearID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetYearDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearID", YearID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetYearData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetYearData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetStudentData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetStudent", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetStudentUserData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetStudentUserData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLoginInfo(string Username,string Password)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UserLogin", dbConn);
            dbComm.Parameters.AddWithValue("@Username", Username);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetTopicData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetTopicData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetTopicDataByID(int TopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetTopicDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicID", TopicID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleTopicData()//(int ModuleTopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleTopicData", dbConn);

            //dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleTopicDataByID(int ModuleTopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetModuleTopicDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetErrorData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetErrorData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetErrorDataByID(int ErrorID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetErrorDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", ErrorID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetProgLanguageData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetProgLanguageData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetProgLanguageDataByID(int ProgLanguageID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetProgLanguageDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID", ProgLanguageID);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetSolutionData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetSolutionData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetSolutionDataByID(int SolutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetSolutionDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SolutionID", SolutionID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetErrorSolutionData()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetErrorSolutionData", dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetErrorSolutionDataByID(int ErrorSolutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetErrorSolutionDataByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorSolutionID", ErrorSolutionID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }

        //Insert Data
        public int InsertModuleData(string ModuleDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertModuleData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            //dbComm.Parameters.AddWithValue("@action", action);
            dbComm.Parameters.AddWithValue("@ModuleDescription", ModuleDescription);
            // 

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertUser(int RoleID, string username, string Surname, string Gender, string Email, string Password, string userstatus)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleID", RoleID);
            dbComm.Parameters.AddWithValue("@Username", username);
            dbComm.Parameters.AddWithValue("@Surname", Surname);
            dbComm.Parameters.AddWithValue("@Gender", Gender);
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbComm.Parameters.AddWithValue("@UserStatus", userstatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertYearData(string YearDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertYearData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            //dbComm.Parameters.AddWithValue("@action", action);
            dbComm.Parameters.AddWithValue("@YearDescription", YearDescription);
            // 

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertAssignTopic(int RoleID, string username)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertAssignTopic", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleID", RoleID);
            dbComm.Parameters.AddWithValue("@Username", username);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertTopicData(string TopicDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicDescription", TopicDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertModuleTopicData(int ModuleID,int TopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertModuleTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@TopicID", TopicID);
            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertErrorData(int StudentID,string ErrorDescription,int ProgLanguageID, string ErrorStatus, string ErrorDate)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertErrorData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@StudentID", StudentID);
            dbComm.Parameters.AddWithValue("@ErrorDescription", ErrorDescription);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", ProgLanguageID);
            //dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", ErrorStatus);
            dbComm.Parameters.AddWithValue("@ErrorDate", ErrorDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertSolutionData(int LecturerID, string SolutionDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@LecturerID", LecturerID);
            dbComm.Parameters.AddWithValue("@SolutionDescription", SolutionDescription);
           
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertErrorSolutionData(int SolutionID, int ErrorID, string SolutionDate)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertErrorSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@ErrorID", ErrorID);
            dbComm.Parameters.AddWithValue("@SolutionID", SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", SolutionDate);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int InsertProgLangData(string ProgLangaugeDesc)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertProgLangData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            //dbComm.Parameters.AddWithValue("@action", action);
            dbComm.Parameters.AddWithValue("@ProgLanguageDesc", ProgLangaugeDesc);
            // 

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        //Update Data
        public int UpdateModuleData(int ModuleID, string ModuleDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateModuleData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleDescription", ModuleDescription);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateYearData(int YearID, string YearDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateYearData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearID", YearID);
            dbComm.Parameters.AddWithValue("@YearDescription", YearDescription);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateUserData(int UserID, string username, string Surname, string Gender, string Email, string Password, string userstatus)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateUserData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@Username", username);
            dbComm.Parameters.AddWithValue("@Surname", Surname);
            dbComm.Parameters.AddWithValue("@Gender", Gender);
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbComm.Parameters.AddWithValue("@UserStatus", userstatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateTopicData(int TopicID,string TopicDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicDescription", TopicDescription);
            dbComm.Parameters.AddWithValue("@TopicID", TopicID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateModuleTopicData(int ModuleID,int TopicID,int ModuleTopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateModuleTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicID", TopicID);
            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateErrorData(int ErrorID,int StudentID, string ErrorDescription, int ProgLanguageID, string ErrorStatus, string ErrorDate)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateErrorData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", ErrorID);
            dbComm.Parameters.AddWithValue("@StudentID", StudentID);
            dbComm.Parameters.AddWithValue("@ErrorDescription", ErrorDescription);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", ProgLanguageID);
            //dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", ErrorStatus);
            dbComm.Parameters.AddWithValue("@ErrorDate", ErrorDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateSolutionData(int SolutionID, int LecturerID, string SolutionDescription)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            
            dbComm.Parameters.AddWithValue("@LecturerID", LecturerID);
            dbComm.Parameters.AddWithValue("@SolutionDescription", SolutionDescription);
            dbComm.Parameters.AddWithValue("@SolutionID", SolutionID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateErrorSolutionData(int SolutionID, int ErrorID, int ErrorSolutionID,string SolutionDate)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateErrorSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@ErrorID", ErrorID);
            dbComm.Parameters.AddWithValue("@ErrorSolutionID", ErrorSolutionID);
            dbComm.Parameters.AddWithValue("@SolutionID", SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", SolutionDate);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateProgLangData(int ProgLanguageID, string ProgLanguageDesc)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateProgLangData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID", ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ProgLanguageDesc", ProgLanguageDesc);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Delete Data
        public int DeleteModuleData(int ModuleID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteModuleData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteYearData(int YearID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteYearData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearID", YearID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }  
        public int DeleteUserData(int UserID)
        {
            try
            {
                dbConn.Open();
                    
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteUserData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", UserID);
            //dbComm.Parameters.AddWithValue("@StudentID", UserID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteTopicData(int TopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicID", TopicID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteModuleTopicData(int ModuleTopicID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteModuleTopicData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleTopicID", ModuleTopicID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteErrorData(int ErrorID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteErrorData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", ErrorID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteSolutionData(int SolutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SolutionID", SolutionID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteErrorSolutionData(int ErrorSolutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteErrorSolutionData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorSolutionID", ErrorSolutionID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProgLangData(int ProgLanguageID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteProgLangData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID", ProgLanguageID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //STATS

        public int CountUserAdmin()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_CountUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            //dbComm.Parameters.AddWithValue("@UserID", UserID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }



    }


}
