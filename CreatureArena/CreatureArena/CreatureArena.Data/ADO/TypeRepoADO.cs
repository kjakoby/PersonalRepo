using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;
using System.Data.SqlClient;
using System.Data;

namespace CreatureArena.Data.ADO
{
    public class TypeRepoADO : ITypeRepo
    {
        public List<Models.Tables.Type> GetAll()
        {
            List<Models.Tables.Type> types = new List<Models.Tables.Type>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("TypeSelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Models.Tables.Type currentRow = new Models.Tables.Type();
                        currentRow.TypeID = (int)dr["TypeID"];
                        currentRow.TypeName = dr["TypeName"].ToString();
                        currentRow.TypeIcon = dr["TypeIcon"].ToString();
                        currentRow.TypeStrength = (int)dr["TypeStrength"];
                        currentRow.TypeWeakness = (int)dr["TypeWeakness"];

                        types.Add(currentRow);
                    }
                }
            }

            return types;
        }

        public Models.Tables.Type GetByID(int typeID)
        {
            //need to complete

            throw new NotImplementedException();

            //Models.Tables.Type type = null;

            //using (var cn = new SqlConnection(Settings.GetConnectionString()))
            //{
            //    SqlCommand cmd = new SqlCommand()
            //}
        }
    }
}
