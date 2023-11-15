﻿using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(MeasureWait) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(MeasureFile) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(MeasureFileArray) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(MeasureFlag) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(MeasureValue) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(MeasureQuery) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(MeasureWait) + ':',
                String.Empty + MeasureWait,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(MeasureFile) + ':',
                String.Empty + MeasureFile,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(MeasureFileArray) + ':',
                String.Empty + MeasureFileArray,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(MeasureFlag) + ':',
                String.Empty + MeasureFlag,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(MeasureValue) + ':',
                String.Empty + MeasureValue,
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(MeasureQuery) + ':',
                String.Empty + MeasureQuery
            });
        }
    }
}
