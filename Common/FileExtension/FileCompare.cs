using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace OASystem.Common
{
    /// <summary>
    /// kineditor文本编辑器，文件名排序
    /// </summary>
    public class FileCompare:IComparer
    {
        public int Compare(object x,object y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x==null)
            {
                return -1;
            }
            else if(y == null)
            {
                return 1;
            }
            FileInfo xInfo = new FileInfo(x.ToString());
            FileInfo yInfo = new FileInfo(y.ToString());

            return xInfo.FullName.CompareTo(yInfo.FullName);
        }
        
    }
}
