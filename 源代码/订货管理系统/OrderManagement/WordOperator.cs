using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace OrderManagement
{
    public class WordOperator
    {
        Application WordApp; //word应用对象
        Document WordDoc; //word文档对象

        public WordOperator()
        {
            WordApp = new Application(); //创建word应用对象
            WordApp.Visible = true; //显示word文档
        }

        public void CreateWord()
        {
            WordDoc = WordApp.Documents.Add(); //创建word文档对象
            WordDoc.PageSetup.Orientation = WdOrientation.wdOrientPortrait; //横版还是竖版
            WordDoc.PageSetup.LeftMargin = WordApp.CentimetersToPoints(0.5f); //左边距
            WordDoc.PageSetup.RightMargin = WordApp.CentimetersToPoints(0.5f); //右边距
            WordDoc.PageSetup.TopMargin = WordApp.CentimetersToPoints(0.5f); //上边距
            WordDoc.PageSetup.BottomMargin = WordApp.CentimetersToPoints(0.5f); //下边距
            WordDoc.PageSetup.PageWidth = 400; //页宽
            WordDoc.PageSetup.PageHeight = 600; //页高
        }
    }
}
