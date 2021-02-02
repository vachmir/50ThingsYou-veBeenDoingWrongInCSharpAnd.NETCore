using System;
using System.Threading;
using System.Threading.Tasks;
using MisusingCSharpPrimitives.MisusingStructsAndBoxingMistakes;

namespace MisusingCSharpPrimitives
{
    class Program
    {
       
        static void Main(string[] args)
        {

            //2.1 with        using MisusingCSharpPrimitives.MisusingDateTime;
            #region Misusing DateTime 
            //DateTimes.GeneralDateTimeUsage();            
            //DateTimes.TimeMeausure();
            //DateTimes.Scheduling();
            #endregion



            //2.2 with       using MisusingCSharpPrimitives.StringAndLocalizationMistakes;
            #region String And Localization Mistakes
            //Strings.String();
            #endregion



            //2.3 with       using using MisusingCSharpPrimitives.IssuesWithIntAndLong;
            #region Issues With Int and Long
            //Task.Run(IntLong.DoWorkIntWrong);
            //IntLong.x = 1;

            ////wrong
            //IntLong.y = 1;

            ////wrong
            //var z = IntLong.y;

            ////correct
            //Interlocked.Exchange(ref IntLong.y, 1);

            ////correct
            //var z2 = Interlocked.Read(ref IntLong.y);
            #endregion



            //2.4 with       using MisusingCSharpPrimitives.IssuesWithFloatDoubleAndDecimal;
            #region Issues With Float, Double and Decimal
            //Floats.Types();
            #endregion



            //2.5 with       using MisusingCSharpPrimitives.MisusingStructsAndBoxingMistakes;
            #region String and Localization Mistakes
            Structs.Struct();
            #endregion


        }

    }
}
