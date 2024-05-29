
using BTLQlSV;
using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
using System.Reflection;
using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace BTLQLSV
    {
        public class Database
        {
            private string connectionString = @"Data Source=ducanh\DUCANH; Initial Catalog = Quanlysinhvienhumg; User ID = sa; Password = 123123";
            private SqlConnection conn;
            private DataTable dt;
            private SqlCommand cmd;
            public Database()
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failse:" + ex.Message);
                }

            }

            public DataTable SelectData(string sql, List<CustomParameter> lstpara)
            {
                try
                {   
                    conn.Open();//Mở kết nối
                    cmd = new SqlCommand(sql, conn);//Truyền giá trị vào cmd
                    cmd.CommandType = CommandType.StoredProcedure;//set command type cho cmd
                    foreach (var para in lstpara)//gans cacs tham số cho cmd
                    {
                        cmd.Parameters.AddWithValue(para.Key, para.Value);
                    }
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());//Thực thi câu lệnh
                    return dt;//Trả về kết quả

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy xuất dữ liệu:" + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();//Đóng kết nối
                }
            }

            public DataRow Select(string sql)
            {
                try
                {   
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt.Rows[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy xuất dữ liệu:" + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }

            public int Execute(string sql, List<CustomParameter> Istpara)
            {
                try {
                    conn.Open();//Mở kết nối
                    cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach ( var p in Istpara)//Gắn các tham số cho cmd
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }    
                    var rs = cmd.ExecuteNonQuery();//Lấy kết quả thực thi truy vấn
                    return (int)rs;    
                }
                catch (Exception ex)
                {
                     MessageBox.Show("Lỗi truy xuất dữ liệu:" + ex.Message);
                     return -100;
                }
                finally { conn.Close(); }
            }
        }
    }


