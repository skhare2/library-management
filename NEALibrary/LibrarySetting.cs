using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class LibrarySetting
    {
        private int SettingId;
        private string SettingName;
        private string SettingValue;
        public LibrarySetting(int settingid, string settingname, string settingvalue) 
        { 
            SettingId = settingid;
            SettingName = settingname;
            SettingValue = settingvalue;
        }
        public LibrarySetting()
        {
            
        }

        public string? GetSettingValue(string SettingName) // For a particular setting its returns its set value
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT SettingValue FROM LibrarySettings WHERE SettingName = @SettingName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SettingName", SettingName);
                        con.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        return null;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
            
        }

        public void ModifySettingValue(string SettingName, string SettingValue) // For a particular setting its set value is edited
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE LibrarySettings SET SettingValue = @SettingValue WHERE SettingName = @SettingName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SettingName", SettingName);
                        cmd.Parameters.AddWithValue("@SettingValue", SettingValue);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        
                    }
                }
                MessageBox.Show($"{SettingName} changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }
    }
}
