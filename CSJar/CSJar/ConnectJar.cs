using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSJar
{
    class ConnectJar
    {
        /// <summary>
        /// .jar実行
        /// </summary>
        /// <param name="msg">メッセージ</param>
        /// <returns>True:成功/False:失敗</returns>
        public static bool Excecute(string msg)
        {
            bool result = false;
            Process jar = null;
            try
            {
                // .jarをプロセスとして起動
                using (jar = Process.Start("java", "-jar Sample.jar " + msg))
                {
                    // 終了待ち
                    jar.WaitForExit();
                    // 結果取得(0:正常終了)
                    if (jar.ExitCode == 0) result = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("例外発生\n" + e.Message);
            }
            return result;
        }
    }
}
