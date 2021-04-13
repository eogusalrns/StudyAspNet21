using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DbHandlingWebApp.Models
{
    public class MaximRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        
        //입력
        public Maxim AddMaxim(Maxim maxim)
        {
            string query = @"Insert into maxim (Name,Contents,RegDate) Values(@name,@Contents,getdate());
                             Select Case(scope_identity() as int);";
            var id = db.Query<int>(query, maxim).Single();
            maxim.Id = id;
            return maxim;
        }
        //조회
        
        //수정
        
        //삭제
    }
}