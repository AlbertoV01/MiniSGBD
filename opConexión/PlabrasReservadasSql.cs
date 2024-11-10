using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using opConexión;
using System.Data.Sql;
using System.Data.SqlClient;

namespace opConexión
{
    public static class PlabrasReservadasSql
    {
        // DML (Data Manipulation Lenguage)
        public static void Select(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            rtb_Consulta.SelectAll();
            rtb_Consulta.SelectionColor = Color.LightGray;
            

            int p = 0;
            while ((p = rtb_Consulta.Find("select", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font,FontStyle.Bold);

                p += 1;
            }


            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void From(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;
      
            int p = 0;
            while ((p = rtb_Consulta.Find("from", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 4;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();

        }

        public static void Insert(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("insert", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 5;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();

        }

        public static void Update(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("update", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void Delete(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("delete", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();

        }

        public static void Asterisco(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("*", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 1;
                rtb_Consulta.SelectionColor = Color.Blue;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void Database(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("database", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 8;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        //DDL (Data Definition Lenguaje)

        public static void Create(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("create", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength =6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);

                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void Alter(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("alter", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 5;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);

                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }
        public static void Drop(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("drop", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 4;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void Truncate(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("truncate", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 8;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }
        public static void Comment(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("coment", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();
        }

        public static void Rename(RichTextBox rtb_Consulta)
        {
            var sel_start = rtb_Consulta.SelectionStart;
            var sel_len = rtb_Consulta.SelectionLength;

            int p = 0;
            while ((p = rtb_Consulta.Find("rename", p, RichTextBoxFinds.None)) >= 0)
            {
                rtb_Consulta.SelectionStart = p;
                rtb_Consulta.SelectionLength = 6;
                rtb_Consulta.SelectionColor = Color.Orange;
                rtb_Consulta.SelectionFont = new Font(rtb_Consulta.Font, FontStyle.Bold);


                p += 1;
            }

            rtb_Consulta.SelectionStart = sel_start;
            rtb_Consulta.SelectionLength = sel_len;

            rtb_Consulta.Invalidate();

        }





    }
}
