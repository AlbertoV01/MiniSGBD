using opConexión;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opConexión
{
    public static class PlabrasReservadasSql
    {
        //WinAPI para evitar repintado mientras actualizamos
        private const int WM_SETREDRAW = 0x000B;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        // Patrón: palabras reservadas (añade las que quieras). \b asegura "whole words".
        private static readonly string pattern = @"\b(select|from|insert|update|delete|create|alter|drop|truncate|database|where|join|on|group|by|order)\b|\*";

        public static void Resaltar(RichTextBox rtb)
        {
            if (rtb == null) return;

            if (string.IsNullOrEmpty(rtb.Text)) return;

            int selStart = rtb.SelectionStart;
            int selLength = rtb.SelectionLength;
            bool oldHideSelection = rtb.HideSelection;

            try
            {
                // Evitar que se muestre la selección mientras procesamos
                rtb.HideSelection = true;

                // evita congelamiento y parpadeo
                SendMessage(rtb.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);

                // Restaurar formato base
                rtb.SelectAll();
                rtb.SelectionColor = Color.LightGray;
                rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);

                var matches = Regex.Matches(rtb.Text, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

                foreach (Match m in matches)
                {
                    if (!m.Success) continue;

                    rtb.Select(m.Index, m.Length);

                    // si es asterisco lo ponemos azul, si es palabra reservada naranja
                    if (m.Value == "*")
                    {
                        rtb.SelectionColor = Color.Blue;
                        rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Orange;
                        rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
                    }
                }
            }
            finally
            {
                rtb.SelectionStart = selStart;
                rtb.SelectionLength = selLength;
                rtb.HideSelection = oldHideSelection;

                SendMessage(rtb.Handle, WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
                rtb.Invalidate();
            }
        }

    }
}
